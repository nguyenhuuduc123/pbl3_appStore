using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pbl3_appstore.Migrations
{
    /// <inheritdoc />
    public partial class datav4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productGuarantees",
                columns: table => new
                {
                    product_guarantee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_recieve = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_pay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    money_pay = table.Column<double>(type: "float", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productGuarantees", x => x.product_guarantee_id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    staff_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<double>(type: "float", nullable: false),
                    product_guarantee_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.staff_id);
                });

            migrationBuilder.CreateTable(
                name: "statusGuarantees",
                columns: table => new
                {
                    status_guarantee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_guarantee_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statusGuarantees", x => x.status_guarantee_id);
                    table.ForeignKey(
                        name: "FK_statusGuarantees_productGuarantees_product_guarantee_id",
                        column: x => x.product_guarantee_id,
                        principalTable: "productGuarantees",
                        principalColumn: "product_guarantee_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    person_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<bool>(type: "bit", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.person_id);
                    table.ForeignKey(
                        name: "FK_persons_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    invoice_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.invoice_id);
                    table.ForeignKey(
                        name: "FK_invoices_staffs_staff_id",
                        column: x => x.staff_id,
                        principalTable: "staffs",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                    table.ForeignKey(
                        name: "FK_customers_invoices_invoice_id",
                        column: x => x.invoice_id,
                        principalTable: "invoices",
                        principalColumn: "invoice_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false),
                    item_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    item_count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_import = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_pay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_guarantee_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_items_invoices_item_id",
                        column: x => x.item_id,
                        principalTable: "invoices",
                        principalColumn: "invoice_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_items_productGuarantees_product_guarantee_id",
                        column: x => x.product_guarantee_id,
                        principalTable: "productGuarantees",
                        principalColumn: "product_guarantee_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    item_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.supplier_id);
                    table.ForeignKey(
                        name: "FK_suppliers_items_item_id",
                        column: x => x.item_id,
                        principalTable: "items",
                        principalColumn: "item_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_invoice_id",
                table: "customers",
                column: "invoice_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_invoices_staff_id",
                table: "invoices",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "IX_items_product_guarantee_id",
                table: "items",
                column: "product_guarantee_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_persons_role_id",
                table: "persons",
                column: "role_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_statusGuarantees_product_guarantee_id",
                table: "statusGuarantees",
                column: "product_guarantee_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_item_id",
                table: "suppliers",
                column: "item_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "statusGuarantees");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "productGuarantees");

            migrationBuilder.DropTable(
                name: "staffs");
        }
    }
}
