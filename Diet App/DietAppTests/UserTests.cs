using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietAppTests
{
    public class UserTests
    {
        private int decimalPlaceAccuracy = 2;

        [Fact]
        public void Constructs_a_new_user()
        {
            // Arrange
            string name = "John";
            int age = 25;
            float weight = 160.0f;
            int heightFeetComponent = 5;
            float heightInchComponent = 10.5f;
            int exercise = 3;
            Sex sex = Sex.Male;
            Goal goal = Goal.LoseWeight;
            BodyMeasurements measurements = new BodyMeasurements(13.5f, 34.75f, 36.2f);

            // Act
            User sut = new User(name, age, weight, heightFeetComponent, heightInchComponent, exercise, sex, goal, measurements);

            // Assert
            Assert.Equal(name, sut.Name);
            Assert.Equal(age, sut.Age);
            Assert.Equal(weight, sut.WeightInLbs, decimalPlaceAccuracy);
            Assert.Equal(heightFeetComponent, sut.HeightFeetComponent);
            Assert.Equal(heightInchComponent, sut.HeightInchComponent, decimalPlaceAccuracy);
            Assert.Equal(70.5f, sut.HeightInInches, decimalPlaceAccuracy);
            Assert.Equal(Sex.Male, sut.Sex);
            Assert.Equal(Goal.LoseWeight, sut.Goal);
            Assert.Equal(measurements, sut.Measurements);
            Assert.Equal(measurements.Neck, sut.Measurements.Neck);
            Assert.Equal(measurements.Waist, sut.Measurements.Waist);
            Assert.Equal(measurements.Hips, sut.Measurements.Hips);
        }
    }
}
