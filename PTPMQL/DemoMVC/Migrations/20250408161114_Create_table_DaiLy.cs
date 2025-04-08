using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_DaiLy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DaiLys_HeThongPhanPhois_HeThongPhanPhoiMaHTPP",
                table: "DaiLys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeThongPhanPhois",
                table: "HeThongPhanPhois");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DaiLys",
                table: "DaiLys");

            migrationBuilder.DropIndex(
                name: "IX_DaiLys_HeThongPhanPhoiMaHTPP",
                table: "DaiLys");

            migrationBuilder.DropColumn(
                name: "HeThongPhanPhoiMaHTPP",
                table: "DaiLys");

            migrationBuilder.RenameTable(
                name: "HeThongPhanPhois",
                newName: "HeThongPhanPhoi");

            migrationBuilder.RenameTable(
                name: "DaiLys",
                newName: "DaiLy");

            migrationBuilder.AlterColumn<string>(
                name: "TenHTPP",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "TenDaiLy",
                table: "DaiLy",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "NguoiDaiDien",
                table: "DaiLy",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "MaHTPP",
                table: "DaiLy",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "DienThoai",
                table: "DaiLy",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "DaiLy",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeThongPhanPhoi",
                table: "HeThongPhanPhoi",
                column: "MaHTPP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaiLy",
                table: "DaiLy",
                column: "MaDaiLy");

            migrationBuilder.CreateIndex(
                name: "IX_DaiLy_MaHTPP",
                table: "DaiLy",
                column: "MaHTPP");

            migrationBuilder.AddForeignKey(
                name: "FK_DaiLy_HeThongPhanPhoi_MaHTPP",
                table: "DaiLy",
                column: "MaHTPP",
                principalTable: "HeThongPhanPhoi",
                principalColumn: "MaHTPP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DaiLy_HeThongPhanPhoi_MaHTPP",
                table: "DaiLy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeThongPhanPhoi",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DaiLy",
                table: "DaiLy");

            migrationBuilder.DropIndex(
                name: "IX_DaiLy_MaHTPP",
                table: "DaiLy");

            migrationBuilder.RenameTable(
                name: "HeThongPhanPhoi",
                newName: "HeThongPhanPhois");

            migrationBuilder.RenameTable(
                name: "DaiLy",
                newName: "DaiLys");

            migrationBuilder.AlterColumn<string>(
                name: "TenHTPP",
                table: "HeThongPhanPhois",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenDaiLy",
                table: "DaiLys",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NguoiDaiDien",
                table: "DaiLys",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaHTPP",
                table: "DaiLys",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DienThoai",
                table: "DaiLys",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "DaiLys",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeThongPhanPhoiMaHTPP",
                table: "DaiLys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeThongPhanPhois",
                table: "HeThongPhanPhois",
                column: "MaHTPP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaiLys",
                table: "DaiLys",
                column: "MaDaiLy");

            migrationBuilder.CreateIndex(
                name: "IX_DaiLys_HeThongPhanPhoiMaHTPP",
                table: "DaiLys",
                column: "HeThongPhanPhoiMaHTPP");

            migrationBuilder.AddForeignKey(
                name: "FK_DaiLys_HeThongPhanPhois_HeThongPhanPhoiMaHTPP",
                table: "DaiLys",
                column: "HeThongPhanPhoiMaHTPP",
                principalTable: "HeThongPhanPhois",
                principalColumn: "MaHTPP",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
