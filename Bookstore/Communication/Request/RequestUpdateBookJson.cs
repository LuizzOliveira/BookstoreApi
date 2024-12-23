﻿namespace Bookstore.Communication.Request;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public double Price { get; set; } 
    public int QuantityStock { get; set; } = int.MaxValue;
}
