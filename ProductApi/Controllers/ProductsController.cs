using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products =
    [
        new Product
        {
            Id = 1,
            Name = "Portátil MSI",
            Price = 999
        },
        new Product
        {
            Id = 2,
            Name = "Monitor",
            Price = 250
        },
        new Product
        {
            Id = 3,
            Name = "Teclado mecánico",
            Price = 89
        }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return Ok(Products);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return NotFound(new
            {
                Message = $"No existe ningún producto con id {id}"
            });
        }

        return Ok(product);
    }
}