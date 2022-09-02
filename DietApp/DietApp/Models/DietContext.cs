using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DietApp.Models
{
    public class DietContext : DbContext
    {
        public DietContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Diet2.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyMeasurements>()
                .HasOne(measurements => measurements.User)
                .WithOne(user => user.Measurements)
                .HasForeignKey<User>(measurements => measurements.UserId);

            modelBuilder.Entity<BodyMeasurements>().ToTable("Users");
            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "John",
                    Age = 25,
                    WeightInLbs = 160,
                    HeightFeetComponent = 5,
                    HeightInchComponent = 10.5f,
                    HoursExercisePerWeek = 3,
                    Sex = Sex.Male,
                    Goal = Goal.LoseWeight,
                },
                new User
                {
                    UserId = 2,
                    Name = "Jane",
                    Age = 42,
                    WeightInLbs = 180,
                    HeightFeetComponent = 5,
                    HeightInchComponent = 6,
                    HoursExercisePerWeek = 0,
                    Sex = Sex.Female,
                    Goal = Goal.LoseWeight,
                });

            modelBuilder.Entity<BodyMeasurements>().HasData(
                new BodyMeasurements
                {
                    UserId = 1,
                    BodyMeasurementsId = 1,
                    Neck = 13.5f,
                    Waist = 34.75f,
                    Hips = 36.2f,
                },
                new BodyMeasurements
                {
                    UserId = 2,
                    BodyMeasurementsId = 2,
                    Neck = 15,
                    Waist = 42,
                    Hips = 41,
                });

            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    FoodId = 1,
                    Name = "Protein Shake",
                    Calories = 110,
                    Protein = 24.5f,
                    Carbs = 4,
                    Fat = 1,
                });

            modelBuilder.Entity<Meal>().HasData(
                new Meal
                {
                    MealId = 1,
                    UserId = 1,
                    FoodId = 1,
                    Servings = 1,
                    DayOfWeek = DayOfWeek.Monday,
                });
        }

    }
}
