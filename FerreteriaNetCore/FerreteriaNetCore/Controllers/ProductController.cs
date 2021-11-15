using FerreteriaNetCore.DAO;
using FerreteriaNetCore.Models.DTOs.ResponseDTO;
using FerreteriaNetCore.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoFerreteria.Models.DTOs;

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

    }
}
