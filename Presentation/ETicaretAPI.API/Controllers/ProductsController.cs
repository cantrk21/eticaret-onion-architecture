using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    public ProductsController( ) //interface referansına karsılık gelen somut sınıfı constructor injection ile alıyoruz. Perssitancedakı concrete sınıfın nesnesı gelecek
    {
    }

   /* [HttpGet]
    public IActionResult GetProducts()
    {
        //var products = _productService.GetProducts();
        //return Ok(products);
    }*/

}
 