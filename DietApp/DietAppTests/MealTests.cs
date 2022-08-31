using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietAppTests
{
    public class MealTests
    {
        private int decimalPlaceAccuracy = 2;

        [Fact]
        public void Constructs_a_new_meal()
        {
            // Arrange
            float servings = 1.5f;
            Food banana = new Food("Banana", 105, 1.3f, 27, .4f);
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            // Act
            Meal sut = new Meal(servings, banana, dayOfWeek);

            // Assert
            Assert.Equal(servings, sut.Servings, decimalPlaceAccuracy);
            Assert.Equal(banana, sut.Food);
            Assert.Equal(dayOfWeek, sut.DayOfWeek);
        }
    }
}
