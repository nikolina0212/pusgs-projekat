﻿using Microsoft.AspNetCore.Http;

namespace Backend.DTO
{
    public class AddArticleDto
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
