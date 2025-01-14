#pragma checksum "C:\Users\MaxX\Source\Repos\Ferreteria_G1\FerreteriaNetCore\FerreteriaNetCore\Views\Product\ProductSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "771bff5c6008fcb4bc3c2e1c584eb4122862870e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductSearch), @"mvc.1.0.view", @"/Views/Product/ProductSearch.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MaxX\Source\Repos\Ferreteria_G1\FerreteriaNetCore\FerreteriaNetCore\Views\_ViewImports.cshtml"
using FerreteriaNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MaxX\Source\Repos\Ferreteria_G1\FerreteriaNetCore\FerreteriaNetCore\Views\_ViewImports.cshtml"
using FerreteriaNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771bff5c6008fcb4bc3c2e1c584eb4122862870e", @"/Views/Product/ProductSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0477c17337381e2d3c7fffbeea4eca989102578e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MaxX\Source\Repos\Ferreteria_G1\FerreteriaNetCore\FerreteriaNetCore\Views\Product\ProductSearch.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Product search";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" id=""tabla_productos"">
    <div class=""col"">
        <table 
            class=""table table-striped table-borderer"" 
            id=""grilla_productos"" 
            style=""100%"">
            
            <thead>
                <tr class=""text-center"">
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Marca</th>
                    <th scope=""col"">Descripción</th>
                    <th scope=""col"">Categoría</th>
                    <th scope=""col"">Stock disponible</th>
                    <th scope=""col"">Acciones</th>
                </tr>
            </thead>
            <tbody>

            </tbody>
        </table>
    </div>
</div>

<script>
    $(document).ready(function(){
        var columnas = [{
            //Todo emma: ver los attr de producto como se mapean
            ""data"": ""name"",
            ""sercheable"": true,
            ""visible"": true,
            ""orderable"": true,
            defaultContent: """"
        ");
            WriteLiteral(@"}, {
            ""data"": ""brand"",
            ""sercheable"": true,
            ""visible"": true,
            ""orderable"": true,
            defaultContent: """"
        }, {
            ""data"": ""description"",
            ""sercheable"": true,
            ""visible"": true,
            ""orderable"": true,
            defaultContent: """"
        }, {
            ""data"": ""category"",
            ""sercheable"": true,
            ""visible"": true,
            ""orderable"": true,
            defaultContent: """"
        }, {
            ""data"": ""quantity"",
            ""sercheable"": true,
            ""visible"": true,
            ""orderable"": true,
            defaultContent: """"
        }, {
            ""data"": function(row, type, set){
                let s = `<div>`;

                s += `<a  id='edit_${row.id}'
                            type='button'
                            class='btn btn-sm btn-secondary mr-1'
                            href='${urlContent}Product/Edit/${row.id}'>
         ");
            WriteLiteral(@"                   Editar
                        </a>`;
                s += `</div>`;
                return s;
            },
            ""sercheable"": false,
            ""visible"": true,
            ""orderable"": false
        }];

        crearGrilla(
            ""#grilla_productos"", 
            ""Product/ListarProductosPaginado"", 
            ""Producto"", 
            columnas, 
            null, 
            true);
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
