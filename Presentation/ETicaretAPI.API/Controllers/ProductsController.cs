using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    readonly IProductWriteRepository _productWriteRepository;
    readonly IProductReadRepository _productReadRepository;

    /*public ProductsController( ) //interface referansına karsılık gelen somut sınıfı constructor injection ile alıyoruz. Perssitancedakı concrete sınıfın nesnesı gelecek
    {
    }*/
    public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
    {
        _productWriteRepository = productWriteRepository;
        _productReadRepository = productReadRepository;
    }

    [HttpGet]
    public async Task Get()
    {
        //await _productWriteRepository.AddRangeAsync(new(){
        //     new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Stock = 10 },
        //     new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, Stock = 20 },
        //     new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, Stock = 110 },
        // });
        //var count = await _productWriteRepository.SaveAsync();

        Product p =  await _productReadRepository.GetByIdAsync("2a60dd93-4c6b-439a-8f89-44f883f50b21");  // aynı dbcontext ı kullandıkları için eklenen ürünün id sini vererek o ürünü çekebiliyoruz. aynı dbcontext üzerinden işlem yapıldığı için eklenen ürünü görebiliyoruz.
        p.Name = "Updated Product Name";
        await _productWriteRepository.SaveAsync();

        //Product p =  await _productReadRepository.GetByIdAsync("2a60dd93-4c6b-439a-8f89-44f883f50b21",false);   yukarıdakı ıslemı yapamasın takıp edemesın ıstersem asnotrackingggg
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var product = await _productReadRepository.GetByIdAsync(id);
        return Ok(product);
    }



    /* [HttpGet]
     public IActionResult GetProducts()
     {
         //var products = _productService.GetProducts();
         //return Ok(products);
     }*/

}
 