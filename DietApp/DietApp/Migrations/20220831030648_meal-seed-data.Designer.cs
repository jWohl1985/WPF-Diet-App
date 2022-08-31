﻿// <auto-generated />
using DietApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DietApp.Migrations
{
    [DbContext(typeof(DietContext))]
    [Migration("20220831030648_meal-seed-data")]
    partial class mealseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("DietApp.Models.BodyMeasurements", b =>
                {
                    b.Property<int>("BodyMeasurementsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Hips")
                        .HasColumnType("REAL");

                    b.Property<float>("Neck")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Waist")
                        .HasColumnType("REAL");

                    b.HasKey("BodyMeasurementsId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            BodyMeasurementsId = 1,
                            Hips = 36.2f,
                            Neck = 13.5f,
                            UserId = 1,
                            Waist = 34.75f
                        });
                });

            modelBuilder.Entity("DietApp.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Calories")
                        .HasColumnType("REAL");

                    b.Property<float>("Carbs")
                        .HasColumnType("REAL");

                    b.Property<float>("Fat")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Protein")
                        .HasColumnType("REAL");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Calories = 110f,
                            Carbs = 4f,
                            Fat = 1f,
                            Name = "Protein Shake",
                            Protein = 24.5f
                        });
                });

            modelBuilder.Entity("DietApp.Models.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Servings")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MealId");

                    b.HasIndex("FoodId");

                    b.HasIndex("UserId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            MealId = 1,
                            DayOfWeek = 1,
                            FoodId = 1,
                            Servings = 1f,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("DietApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Goal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HeightFeetComponent")
                        .HasColumnType("INTEGER");

                    b.Property<float>("HeightInchComponent")
                        .HasColumnType("REAL");

                    b.Property<int>("HoursExercisePerWeek")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.Property<float>("WeightInLbs")
                        .HasColumnType("REAL");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Age = 25,
                            Goal = 0,
                            HeightFeetComponent = 5,
                            HeightInchComponent = 10.5f,
                            HoursExercisePerWeek = 3,
                            Name = "John",
                            Sex = 0,
                            WeightInLbs = 160f
                        });
                });

            modelBuilder.Entity("DietApp.Models.Meal", b =>
                {
                    b.HasOne("DietApp.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Models.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DietApp.Models.User", b =>
                {
                    b.HasOne("DietApp.Models.BodyMeasurements", "Measurements")
                        .WithOne("User")
                        .HasForeignKey("DietApp.Models.User", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Measurements");
                });

            modelBuilder.Entity("DietApp.Models.BodyMeasurements", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("DietApp.Models.User", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}