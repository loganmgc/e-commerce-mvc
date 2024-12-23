﻿using App.Data.Repositories.Implenemtations;
using App.Data.Repositories.Interfaces;
using App.Service.Helpers;
using App.Service.Services.Implementations;
using App.Service.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace App.Shared
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductCommentRepository, ProductCommentRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IContactFormRepository, ContactFormRepository>();
            services.AddScoped<IDiscountRepository, DiscountRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICartItemRepository, CartItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();

            return services;
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductCommentService, ProductCommentService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IContactFormService, ContactFormService>();
            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICartItemService, CartItemService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IFileService, FileService>();

            return services;
        }

        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }

        public static IServiceCollection AddHelpers(this IServiceCollection services)
        {
            services.AddScoped<ProductCommentHelper>();

            return services;
        }
    }
}
