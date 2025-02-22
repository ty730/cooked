﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250213022738_AllTheFood")]
    partial class AllTheFood
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("backend.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Calories")
                        .HasColumnType("REAL");

                    b.Property<double>("Cost")
                        .HasColumnType("REAL");

                    b.Property<double>("DefaultAmount")
                        .HasColumnType("REAL");

                    b.Property<string>("DefaultUnit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Fiber")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Protein")
                        .HasColumnType("REAL");

                    b.Property<double>("Sodium")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalSugar")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("backend.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int>("FoodId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IngredientListId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MealId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PantryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IngredientListId");

                    b.HasIndex("MealId");

                    b.HasIndex("PantryId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("backend.Models.IngredientList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Calories")
                        .HasColumnType("REAL");

                    b.Property<double>("Cost")
                        .HasColumnType("REAL");

                    b.Property<double>("Fat")
                        .HasColumnType("REAL");

                    b.Property<double>("Fiber")
                        .HasColumnType("REAL");

                    b.Property<double>("Protein")
                        .HasColumnType("REAL");

                    b.Property<double>("Sodium")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalSugar")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("IngredientLists");
                });

            modelBuilder.Entity("backend.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PantryId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PercentOfRecipe")
                        .HasColumnType("REAL");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("eaten")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("planned")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("prepared")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PantryId");

                    b.HasIndex("UserId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("backend.Models.Pantry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pantries");
                });

            modelBuilder.Entity("backend.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientListId")
                        .HasColumnType("INTEGER");

                    b.PrimitiveCollection<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ServingsYield")
                        .HasColumnType("REAL");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("cookTime")
                        .HasColumnType("REAL");

                    b.Property<double>("prepTime")
                        .HasColumnType("REAL");

                    b.Property<double>("totalTime")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PantryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ShoppingListIdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingListIdId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("backend.Models.Ingredient", b =>
                {
                    b.HasOne("backend.Models.IngredientList", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("IngredientListId");

                    b.HasOne("backend.Models.Meal", null)
                        .WithMany("SnackIngredients")
                        .HasForeignKey("MealId");

                    b.HasOne("backend.Models.Pantry", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("PantryId");
                });

            modelBuilder.Entity("backend.Models.Meal", b =>
                {
                    b.HasOne("backend.Models.Pantry", null)
                        .WithMany("Meals")
                        .HasForeignKey("PantryId");

                    b.HasOne("backend.Models.User", null)
                        .WithMany("Meals")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("backend.Models.Recipe", b =>
                {
                    b.HasOne("backend.Models.User", null)
                        .WithMany("Recipes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.HasOne("backend.Models.IngredientList", "ShoppingListId")
                        .WithMany()
                        .HasForeignKey("ShoppingListIdId");

                    b.Navigation("ShoppingListId");
                });

            modelBuilder.Entity("backend.Models.IngredientList", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("backend.Models.Meal", b =>
                {
                    b.Navigation("SnackIngredients");
                });

            modelBuilder.Entity("backend.Models.Pantry", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Meals");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Navigation("Meals");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
