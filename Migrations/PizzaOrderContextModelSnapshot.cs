﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PizzaOrdering.Migrations
{
    [DbContext(typeof(PizzaOrderContext))]
    partial class PizzaOrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("DailyPizzaLimit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Limit")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("LimitId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PizzaId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PizzaId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoldCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId1");

                    b.ToTable("DailyPizzaLimits");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PizzaId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PizzasId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PizzasId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PizzaId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Classic tomato and mozzarella cheese",
                            Name = "Margherita",
                            PizzaId = new Guid("91de7e62-93f6-44ee-974f-60a05dfe292b"),
                            Price = 8.99f
                        },
                        new
                        {
                            Id = 2,
                            Description = "Pepperoni and cheese on tomato sauce",
                            Name = "Pepperoni",
                            PizzaId = new Guid("6fe8215a-b80d-41dd-99f1-5f28710fdafe"),
                            Price = 9.99f
                        },
                        new
                        {
                            Id = 3,
                            Description = "Mixed vegetables and cheese on tomato sauce",
                            Name = "Vegetarian",
                            PizzaId = new Guid("21610e0d-ac12-4e6a-8798-4c4aed4a68b8"),
                            Price = 9.99f
                        });
                });

            modelBuilder.Entity("DailyPizzaLimit", b =>
                {
                    b.HasOne("Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId1");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.HasOne("Pizza", "Pizzas")
                        .WithMany("Orders")
                        .HasForeignKey("PizzasId");

                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("Pizza", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
