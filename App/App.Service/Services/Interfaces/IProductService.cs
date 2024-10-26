﻿using App.Service.Models.ProductDTOs;

namespace App.Service.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDto>> GetAllProductsAsync();
        Task<IEnumerable<GetProductDto>> GetAllNotEnableProductsAsync();
        Task<GetProductDto> GetProductByIdAsync(int id);
        Task<IEnumerable<GetProductDto>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<GetProductDto>> GetProductsBySellerAsyınc(int sellerId);
        Task AddProductAsync(AddProductDto productDto);
        Task<bool> UpdateAsync(int id, UpdateProductDto productDto);
        Task<(bool isDeleted, string message)> DeleteProductAsync(int id);
        Task<IEnumerable<ProductListingDto>> GetFeaturedProductsAsync();
        Task<IEnumerable<ProductListingDto>> GetFilteredProductsAsync(int count, string filterType);
    }
}
