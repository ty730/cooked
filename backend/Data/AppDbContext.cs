using System;
using backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Pantry> Pantries { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<IngredientList> IngredientLists { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}