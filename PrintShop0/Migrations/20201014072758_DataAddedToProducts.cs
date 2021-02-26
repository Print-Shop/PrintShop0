using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintShop0.Migrations
{
    public partial class DataAddedToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 5, 5, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.fibre2fashion.com%2Faccessories%2Fmen-s-printed-caps-buyers-19160236&psig=AOvVaw1dMDqjjS20SvkFCy9FiFYf&ust=1602745876733000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMitve3Ds-wCFQAAAAAdAAAAABAO", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.fibre2fashion.com%2Faccessories%2Fmen-s-printed-caps-buyers-19160236&psig=AOvVaw1dMDqjjS20SvkFCy9FiFYf&ust=1602745876733000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMitve3Ds-wCFQAAAAAdAAAAABAO , https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Fghostwhitetoner%2Fphotos%2Fbad-hair-days-are-for-self-printed-caps-made-with-the-ghost-white-toner-httpswww%2F1003048973191333%2F&psig=AOvVaw1dMDqjjS20SvkFCy9FiFYf&ust=1602745876733000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCMitve3Ds-wCFQAAAAAdAAAAABAU", true, true, "Block out the sun with this stylish printed cap. A black baseball cap printed with a logo or picture of your choice. One size fits all.", "Printed Cap", 39.95m, "Printed Cap" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
