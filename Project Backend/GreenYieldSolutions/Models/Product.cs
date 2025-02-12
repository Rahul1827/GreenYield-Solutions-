﻿namespace GreenYieldSolutions.Models
{
    public class Product
    {
     
            public int Id { get; set; }
            public string Name { get; set; }
            public string Brand { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string? ImagePath { get; set; } // Save only  path in DB
        

    }
}
