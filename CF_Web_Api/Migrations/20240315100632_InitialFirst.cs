using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CF_Web_Api.Migrations
{
    public partial class InitialFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    UserName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Pass = table.Column<string>(type: "text", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    TenCa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThoiGian = table.Column<TimeSpan>(type: "time", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CampusCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CampusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CampusSymbol = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    TenNoiDungDanhGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoaiDanhGia = table.Column<bool>(type: "bit", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roomCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    BlockCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BlockName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BlockNo = table.Column<int>(type: "int", nullable: true),
                    CampusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Blocks__CampusId__3D5E1FD2",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    FloorCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FloorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FloorOrder = table.Column<int>(type: "int", nullable: true),
                    FloorNotes = table.Column<int>(type: "int", nullable: true),
                    BlockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Floors__BlockId__4316F928",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    RoomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoomName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdCate = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FloorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Room__FloorsId__4E88ABD4",
                        column: x => x.FloorsId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Room__IdCate__4D94879B",
                        column: x => x.IdCate,
                        principalTable: "roomCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "formDanhGia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdRoom = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCa = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formDanhGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK__formDanhG__IdRoo__628FA481",
                        column: x => x.IdRoom,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__formDanhGi__IdCa__6383C8BA",
                        column: x => x.IdCa,
                        principalTable: "Ca",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "reportAuthorize",
                columns: table => new
                {
                    IdForm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDanhGia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportAuthorize", x => new { x.IdForm, x.IdDanhGia });
                    table.ForeignKey(
                        name: "FK__reportAut__IdDan__693CA210",
                        column: x => x.IdDanhGia,
                        principalTable: "DanhGia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__reportAut__IdFor__68487DD7",
                        column: x => x.IdForm,
                        principalTable: "formDanhGia",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportDanhGia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    GhiChu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    formDanhGiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportDanhGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ReportDan__Accou__6FE99F9F",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ReportDan__formD__6EF57B66",
                        column: x => x.formDanhGiaId,
                        principalTable: "formDanhGia",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_CampusId",
                table: "Blocks",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BlockId",
                table: "Floors",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_formDanhGia_IdCa",
                table: "formDanhGia",
                column: "IdCa");

            migrationBuilder.CreateIndex(
                name: "IX_formDanhGia_IdRoom",
                table: "formDanhGia",
                column: "IdRoom");

            migrationBuilder.CreateIndex(
                name: "IX_reportAuthorize_IdDanhGia",
                table: "reportAuthorize",
                column: "IdDanhGia");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDanhGia_AccountId",
                table: "ReportDanhGia",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDanhGia_formDanhGiaId",
                table: "ReportDanhGia",
                column: "formDanhGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_FloorsId",
                table: "Room",
                column: "FloorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_IdCate",
                table: "Room",
                column: "IdCate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reportAuthorize");

            migrationBuilder.DropTable(
                name: "ReportDanhGia");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "formDanhGia");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Ca");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "roomCategory");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Campus");
        }
    }
}
