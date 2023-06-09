﻿namespace BlazorAppFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public string[]? Images { get; set; }
        public string? Image { get; set; }

    }

    public class Product2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public string? Image { get; set; }
        public DateTime Fecha { get; set; }
        public bool? Estado { get; set; }
        //public char? Tipo { get; set; }
        //public Dictionary<string,List<object>> diccionario { get; set; }
    }
}
