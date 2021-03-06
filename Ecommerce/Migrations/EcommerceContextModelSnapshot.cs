﻿// <auto-generated />
using System;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ecommerce.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Total");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ecommerce.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Price");

                    b.Property<string>("ProductImage");

                    b.Property<string>("Sku");

                    b.HasKey("ProductId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Gortex Backpack",
                            Price = 57,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Tent",
                            Price = 129,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Boots",
                            Price = 199,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Sleeping Bag",
                            Price = 99,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Gortex Backpack",
                            Price = 57,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Tent",
                            Price = 129,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 7,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Boots",
                            Price = 199,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 8,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Sleeping Bag",
                            Price = 99,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 9,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Gortex Backpack",
                            Price = 57,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 10,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Tent",
                            Price = 129,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 11,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Boots",
                            Price = 199,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 12,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Sleeping Bag",
                            Price = 99,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 13,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Gortex Backpack",
                            Price = 57,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 14,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Tent",
                            Price = 129,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        },
                        new
                        {
                            ProductId = 15,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.",
                            Name = "Boots",
                            Price = 199,
                            ProductImage = "https://picsum.photos/200",
                            Sku = "187420-1217"
                        });
                });

            modelBuilder.Entity("Ecommerce.Models.OrderProduct", b =>
                {
                    b.HasOne("Ecommerce.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ecommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ecommerce.Models.Product", b =>
                {
                    b.HasOne("Ecommerce.Models.Order")
                        .WithMany("Cart")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
