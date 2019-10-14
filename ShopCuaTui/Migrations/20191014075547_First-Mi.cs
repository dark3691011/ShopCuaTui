using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopCuaTui.Migrations
{
    public partial class FirstMi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKh = table.Column<string>(maxLength: 50, nullable: false),
                    HoLot = table.Column<string>(maxLength: 150, nullable: true),
                    Ten = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    SDT = table.Column<string>(maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 150, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKh);
                });

            migrationBuilder.CreateTable(
                name: "Loais",
                columns: table => new
                {
                    MaLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoai = table.Column<string>(maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    Hinh = table.Column<string>(maxLength: 150, nullable: true),
                    MaLoaiCha = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loais", x => x.MaLoai);
                    table.ForeignKey(
                        name: "FK_Loais_Loais_MaLoaiCha",
                        column: x => x.MaLoaiCha,
                        principalTable: "Loais",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    MaTh = table.Column<string>(maxLength: 50, nullable: false),
                    TenThuongHieu = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 150, nullable: true),
                    DienThoai = table.Column<string>(maxLength: 50, nullable: true),
                    Logo = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.MaTh);
                });

            migrationBuilder.CreateTable(
                name: "HangHoas",
                columns: table => new
                {
                    MaHh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenHh = table.Column<string>(maxLength: 150, nullable: false),
                    Hinh = table.Column<string>(maxLength: 150, nullable: true),
                    MoTa = table.Column<string>(nullable: true),
                    DonGia = table.Column<double>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiamGia = table.Column<int>(nullable: false),
                    MaLoai = table.Column<int>(nullable: false),
                    MaTh = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoas", x => x.MaHh);
                    table.ForeignKey(
                        name: "FK_HangHoas_Loais_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "Loais",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HangHoas_ThuongHieus_MaTh",
                        column: x => x.MaTh,
                        principalTable: "ThuongHieus",
                        principalColumn: "MaTh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HangHoas_MaLoai",
                table: "HangHoas",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_HangHoas_MaTh",
                table: "HangHoas",
                column: "MaTh");

            migrationBuilder.CreateIndex(
                name: "IX_Loais_MaLoaiCha",
                table: "Loais",
                column: "MaLoaiCha");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HangHoas");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Loais");

            migrationBuilder.DropTable(
                name: "ThuongHieus");
        }
    }
}
