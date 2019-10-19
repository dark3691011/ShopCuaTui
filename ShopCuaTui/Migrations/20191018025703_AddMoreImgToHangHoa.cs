using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopCuaTui.Migrations
{
    public partial class AddMoreImgToHangHoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hinh",
                table: "HangHoas",
                newName: "SingleProductImg4");

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "ThuongHieus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductImg",
                table: "HangHoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SingleProductImg1",
                table: "HangHoas",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SingleProductImg2",
                table: "HangHoas",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SingleProductImg3",
                table: "HangHoas",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "ThuongHieus");

            migrationBuilder.DropColumn(
                name: "ProductImg",
                table: "HangHoas");

            migrationBuilder.DropColumn(
                name: "SingleProductImg1",
                table: "HangHoas");

            migrationBuilder.DropColumn(
                name: "SingleProductImg2",
                table: "HangHoas");

            migrationBuilder.DropColumn(
                name: "SingleProductImg3",
                table: "HangHoas");

            migrationBuilder.RenameColumn(
                name: "SingleProductImg4",
                table: "HangHoas",
                newName: "Hinh");
        }
    }
}
