﻿namespace App.Admin.Models.ViewModels.Category
{
    public class CategoryListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string IconCssClass { get; set; } = null!;
    }
}