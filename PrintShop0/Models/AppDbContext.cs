using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintShop0.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Shirts", Description = "All printed shirts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Mugs", Description = "Printed mugs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Mouse Pads", Description = "Printed mouse pads" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Hoodies", Description = "All printed hoodies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Caps", Description = "All printed caps" });

            //seed products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Printed Shirt",
                Price = 79.95M,
                ShortDescription = "Printed T-Shirt",
                LongDescription =
                    "T-Shirt printed with a picture or logo of your choice.  Assorted colours and sizes.",
                CategoryId = 1,
                ImageUrl = "https://wp-en.oberlo.com/wp-content/uploads/2020/01/morning-1772286_1280.jpg , https://www.palmgear.com/wp-content/uploads/2019/11/How-Much-Does-It-Cost-To-Print-A-T-shirt.jpg , https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTaMjzqUIT3ihCKXTL47d9rpCwPKGFJNw8wxA&usqp=CAU",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://wp-en.oberlo.com/wp-content/uploads/2020/01/morning-1772286_1280.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Printed Mug",
                Price = 45.95M,
                ShortDescription = "Printed Mug",
                LongDescription = "A white coffee mug with a picture or logo printed on it.",
                CategoryId = 2,
                ImageUrl = "https://lh3.googleusercontent.com/proxy/FIfkzJvAauxcOfBaFQ5f7GE9GFnNY0zgnhWoVKldCCxZGHtUu27Km5x1rxTMWwWuYn_bM0dvqAtLwiQEES7Z9TFi_aJqIRtnLs2kNUkXGOYiZuxndN1JwFngGw , https://img3.exportersindia.com/product_images/bc-full/2018/11/1788827/white-custom-mug-printing-1543206414-4470638.jpeg , https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR4d8_u5B5HZL_WpzrFJ6ZXHfC7M6uyhR3cBg&usqp=CAU",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR4d8_u5B5HZL_WpzrFJ6ZXHfC7M6uyhR3cBg&usqp=CAU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Printed Hoodie",
                Price = 109.95M,
                ShortDescription = "Printed Solid Hoodie",
                LongDescription = "A printed hoodie, with a picture or logo of your choice, for the colder days to add to your wardrobe.  Assorted colours and sizes.",
                CategoryId = 4,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRsgJYPLL3JBYAwj4LGInz32sDx_AE2vWyN2w&usqp=CAU , https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSKV1EYUd0NqW6odYKQXxwFkrUJpfRuW0eIzw&usqp=CAU",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSKV1EYUd0NqW6odYKQXxwFkrUJpfRuW0eIzw&usqp=CAU"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Printed Mouse Pad",
                Price = 69.95M,
                ShortDescription = "Printed Mouse Pad",
                LongDescription = "A black mousepad printed with a picture or logo of your choice.  Size: 400mmx300mm",
                CategoryId = 3,
                ImageUrl = "https://www.makro.co.za/sys-master/images/hde/h4b/9642469490718/73d7bd0e-1357-4675-a7ba-14a9e1b20843-qpn13_large",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://www.makro.co.za/sys-master/images/hde/h4b/9642469490718/73d7bd0e-1357-4675-a7ba-14a9e1b20843-qpn13_large"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Printed Cap",
                Price = 39.95M,
                ShortDescription = "Printed Cap",
                LongDescription =
                    "Block out the sun with this stylish printed cap. A black baseball cap printed with a logo or picture of your choice. One size fits all.",
                CategoryId = 5,
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.fibre2fashion.com%2Faccessories%2Fmen-s-printed-caps-buyers-19160236&psig=AOvVaw1dMDqjjS20SvkFCy9FiFYf&ust=1602745876733000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMitve3Ds-wCFQAAAAAdAAAAABAO , https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Fghostwhitetoner%2Fphotos%2Fbad-hair-days-are-for-self-printed-caps-made-with-the-ghost-white-toner-httpswww%2F1003048973191333%2F&psig=AOvVaw1dMDqjjS20SvkFCy9FiFYf&ust=1602745876733000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMitve3Ds-wCFQAAAAAdAAAAABAU",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.fibre2fashion.com%2Faccessories%2Fmen-s-printed-caps-buyers-19160236&psig=AOvVaw1dMDqjjS20SvkFCy9FiFYf&ust=1602745876733000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMitve3Ds-wCFQAAAAAdAAAAABAO"
            });
        }
    }
}
