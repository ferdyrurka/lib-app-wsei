﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace lib_app_wsei.Data.Migrations
{
    public partial class AddHasNewsletterSubscribedToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasNewsletterSubscribed",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasNewsletterSubscribed",
                table: "Customers");
        }
    }
}