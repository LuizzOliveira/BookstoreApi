namespace Bookstore;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public string Gender { get; set; }

    public double Price { get; set; }

    public int QuantityStock { get; set; }

}
//Um livro deverá ter os seguintes campos:

//- Um id único pra identificar cada livro;
//- Um título;
//- Um autor;
//- Um gênero;
//* Você pode definir gêneros como* `ficção`, `romance`, `mistério`*, por exemplo;*
//- Um preço;
//- Quantidade em estoque.