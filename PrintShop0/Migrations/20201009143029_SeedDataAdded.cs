using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintShop0.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Shirts", "All printed shirts" },
                    { 2, "Mugs", "Printed mugs" },
                    { 3, "Mouse Pads", "Printed mouse pads" },
                    { 4, "Hoodies", "All printed hoodies" },
                    { 5, "Caps", "All printed caps" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://wp-en.oberlo.com/wp-content/uploads/2020/01/morning-1772286_1280.jpg", "https://wp-en.oberlo.com/wp-content/uploads/2020/01/morning-1772286_1280.jpg , https://www.palmgear.com/wp-content/uploads/2019/11/How-Much-Does-It-Cost-To-Print-A-T-shirt.jpg , https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTaMjzqUIT3ihCKXTL47d9rpCwPKGFJNw8wxA&usqp=CAU", true, false, "T-Shirt printed with a picture or logo of your choice.  Assorted colours and sizes.", "Printed Shirt", 79.95m, "Printed T-Shirt" },
                    { 2, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR4d8_u5B5HZL_WpzrFJ6ZXHfC7M6uyhR3cBg&usqp=CAU", "https://lh3.googleusercontent.com/proxy/FIfkzJvAauxcOfBaFQ5f7GE9GFnNY0zgnhWoVKldCCxZGHtUu27Km5x1rxTMWwWuYn_bM0dvqAtLwiQEES7Z9TFi_aJqIRtnLs2kNUkXGOYiZuxndN1JwFngGw , https://img3.exportersindia.com/product_images/bc-full/2018/11/1788827/white-custom-mug-printing-1543206414-4470638.jpeg , https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR4d8_u5B5HZL_WpzrFJ6ZXHfC7M6uyhR3cBg&usqp=CAU", true, false, "A white coffee mug with a picture or logo printed on it.", "Printed Mug", 45.95m, "Printed Mug" },
                    { 4, 3, "https://www.makro.co.za/sys-master/images/hde/h4b/9642469490718/73d7bd0e-1357-4675-a7ba-14a9e1b20843-qpn13_large", "https://www.makro.co.za/sys-master/images/hde/h4b/9642469490718/73d7bd0e-1357-4675-a7ba-14a9e1b20843-qpn13_large", true, true, "A black mousepad printed with a picture or logo of your choice.  Size: 400mmx300mm", "Printed Mouse Pad", 69.95m, "Printed Mouse Pad" },
                    { 3, 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSKV1EYUd0NqW6odYKQXxwFkrUJpfRuW0eIzw&usqp=CAU", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRsgJYPLL3JBYAwj4LGInz32sDx_AE2vWyN2w&usqp=CAU , https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSKV1EYUd0NqW6odYKQXxwFkrUJpfRuW0eIzw&usqp=CAU", true, true, "A printed hoodie, with a picture or logo of your choice, for the colder days to add to your wardrobe.  Assorted colours and sizes.", "Printed Hoodie", 109.95m, "Printed Solid Hoodie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
