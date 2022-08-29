using DietApp.Models;

namespace DietAppTests
{
    public class FoodTests
    {
        int decimalPlaceAccuracy = 2;

        [Fact]
        public void Constructs_a_new_food()
        {
            // Arrange
            string expectedName = "Protein Shake";
            float expectedCalories = 110;
            float expectedProtein = 24.5f;
            float expectedCarbs = 4;
            float expectedFat = 1;

            // Act
            Food sut = new Food(expectedName, expectedCalories, expectedProtein, expectedCarbs, expectedFat);

            // Assert
            Assert.Equal(expectedName, sut.Name);
            Assert.Equal(expectedCalories, sut.Calories, decimalPlaceAccuracy);
            Assert.Equal(expectedProtein, sut.Protein, decimalPlaceAccuracy);
            Assert.Equal(expectedCarbs, sut.Carbs, decimalPlaceAccuracy);
            Assert.Equal(expectedFat, sut.Fat, decimalPlaceAccuracy);
        }
    }
}