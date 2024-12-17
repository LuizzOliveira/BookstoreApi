using Bookstore.Communication.Request;
using Bookstore.Communication.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Bookstore.Controllers;

public class BookstoreController : MyApiControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Books), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult Get()
    {
        // Criar uma lista de livros (substitua por sua lógica real de obtenção de dados)
        var books = new List<Book>
        {
        new Book { Id = 1, Title = "O Senhor dos Anéis", Author = "J.R.R. Tolkien", Gender = "Fantasia", Price = 50.00, QuantityStock = 10 },
        new Book { Id = 2, Title = "1984", Author = "George Orwell", Gender = "Ficção Científica", Price = 30.00, QuantityStock = 5 },
        new Book { Id = 3, Title = "Dom Quixote", Author = "Miguel de Cervantes", Gender = "Literatura Clássica", Price = 40.00, QuantityStock = 8 }
        };

        return Ok(books);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] ResponseRegisteredBookJson request)
    {
        var response = new ResponseRegisteredBookJson
        {
            Title = request.Title,
            Author = request.Author,    
            Gender = request.Gender,
            Price = request.Price,  
            QuantityStock = request.QuantityStock
        };

        return Created(string.Empty, response);
    }


    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Delete()
    {
        return NoContent();
    }




}
