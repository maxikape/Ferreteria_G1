/*************************************
    Copyright (C) 2021 ITSC - Ing. de Software

    Este programa es software libre: usted puede redistribuirlo y/o modificarlo 
    bajo los términos de la Licencia Pública General GNU publicada 
    por la Fundación para el Software Libre, ya sea la versión 3 
    de la Licencia, o (a su elección) cualquier versión posterior.

    Este programa se distribuye con la esperanza de que sea útil, pero 
    SIN GARANTÍA ALGUNA; ni siquiera la garantía implícita 
    MERCANTIL o de APTITUD PARA UN PROPÓSITO DETERMINADO. 
    Consulte los detalles de la Licencia Pública General GNU para obtener 
    una información más detallada. 

    Debería haber recibido una copia de la Licencia Pública General GNU 
    junto a este programa. 
    En caso contrario, consulte http://www.gnu.org/licenses/gpl-3.0.html
 ************************************/

using System.Collections.Generic;
using FerreteriaNetCore.DAO;
using FerreteriaNetCore.DAO.comun;
using FerreteriaNetCore.Models.DTOs.ResponseDTO;
using FerreteriaNetCore.Models.Entities;
using FerreteriaNetCore.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FerreteriaNetCore.Models.DTOs;

namespace FerreteriaNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(){
            UserResponse userResponse = HttpContext.Session.Get<UserResponse>("UsuarioLogueado");
            if (userResponse != null)
            {
                return View("~/Views/Product/ProductEdit.cshtml");
            }
            else{
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult SaveProduct(ProductEditDTO productDto)
        {
            using(DAOFactory daoFactory = new DAOFactory()){

                IProductBO newProduct = new ProductBO();
                newProduct = newProduct.buildNewProduct(productDto);

                if(newProduct.applies()){
                    ProductModel existingProduct = daoFactory.ProductDAO.GetProduct(newProduct.Name, newProduct.Brand);
                    if (existingProduct != null)
                    {
                        newProduct.updateQuantity(existingProduct);

                        daoFactory.BeginTrans();
                        daoFactory.ProductDAO.SaveProduct(existingProduct); 
                        daoFactory.Commit();

                    }else{

                        daoFactory.BeginTrans();
                        daoFactory.ProductDAO.SaveProduct(newProduct);
                        daoFactory.Commit();
                    }
                }
                
                return RedirectToAction("Index", "Product");
            }
        }
        public JsonResult ListarProductosPaginado(ModeloConsultaGrilla modeloConsulta)
        {
            UserResponse usuarioResponse = 
                HttpContext.Session.Get<UserResponse>("UsuarioLogueado");

            if(usuarioResponse == null)
            {
                return Json(JsonReturn.RedireccionarIndex());
            }
            
            try
            {
                long cantidadTotal = 0;
                List<PsearchDTO> productosResponse = new List<PsearchDTO>();

                using(DAOFactory df = new DAOFactory())
                {
                    Ordenamiento ordenamiento = obtenerOrdenamientoProductos(modeloConsulta);
                    List<Asociacion> asociaciones = null;
                    List<AtributoBusqueda> atributosBusqueda = obtenerAtributosBusquedaProducto();

                    Paginado paginado = new Paginado
                    {
                        Comienzo = modeloConsulta.start,
                        Cantidad = modeloConsulta.length
                    };

                    IList<ProductModel> productos = df.ProductDAO.GetProducts(
                        atributosBusqueda,
                        modeloConsulta.search.value,
                        paginado,
                        ordenamiento,
                        asociaciones,
                        out cantidadTotal);

                    foreach(ProductModel producto in productos)
                    {
                        productosResponse.Add(new PsearchDTO
                        {
                            Name = producto.Name,
                            Brand = producto.Brand,                            
                            Description = producto.Description,
                            Category = producto.Category,
                            Quantity = producto.Quantity.ToString("#,##0.00")
                        });
                    }

                    return Json(JsonReturn.SuccessConRetorno(new ConsultaGrillaResponse
                    {
                        draw = modeloConsulta.draw,
                        recordsFiltered = productosResponse.Count,
                        recordsTotal = cantidadTotal,
                        data = productosResponse
                    }));
                }
            }
            catch(System.Exception ex)
            {
                return Json(JsonReturn.ErrorConMsjSimple(
                    "Se generó un error mientras intentabamos listar los productos<br><br>" +
                    "Más info:<br>" + ex.Message));
            }   
        }

        private static List<AtributoBusqueda> obtenerAtributosBusquedaProducto()
        {
            List<AtributoBusqueda> atributosBusqueda = new List<AtributoBusqueda>();

            atributosBusqueda.Add(new AtributoBusqueda
            {
                NombreAtributo = "ProductModel.Name",
                TipoDato = TipoDato.String
            });

            atributosBusqueda.Add(new AtributoBusqueda
            {
                NombreAtributo = "ProductModel.Brand",
                TipoDato = TipoDato.String
            });

            atributosBusqueda.Add(new AtributoBusqueda
            {
                NombreAtributo = "ProductModel.Description",
                TipoDato = TipoDato.String
            });

            atributosBusqueda.Add(new AtributoBusqueda
            {
                NombreAtributo = "ProductModel.Category",
                TipoDato = TipoDato.String
            });

            atributosBusqueda.Add(new AtributoBusqueda
            {
                NombreAtributo = "ProductModel.Quantity",
                TipoDato = TipoDato.Int32
            });

            return atributosBusqueda;
        }
        private static Ordenamiento obtenerOrdenamientoProductos(
            ModeloConsultaGrilla modeloConsulta)
        {
            Ordenamiento ordenamiento = new Ordenamiento
            {
                Atributo = "ProductModel.Brand",
                Direccion = "asc"
            };

            if (modeloConsulta.order != null &&
                modeloConsulta.order.Count > 0)
            {
                int columnIndex = modeloConsulta.order[0].column;
                string col = modeloConsulta.columns[columnIndex].data;

                if (col == "Nombre") col = "ProductModel.Name";
                else if (col == "Marca") col = "ProductModel.Brand";
                else if (col == "Descripción") col = "ProductModel.Description";
                else if (col == "Categoría") col = "ProductModel.Category";
                else if (col == "Stock disponible") col = "ProductModel.Quantity";
                else col = "ProductModel.Description";

                ordenamiento.Atributo = col;
                ordenamiento.Direccion =
                    modeloConsulta.order[0].dir == ModeloDireccion.desc ? "desc" : "asc";
            }

            return ordenamiento;
        }

    }
}
