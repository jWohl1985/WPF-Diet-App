using DietApp.Models;

namespace DietAppTests
{
    public class FoodTests
    {
        private int decimalPlaceAccuracy = 2;

        [Fact]
        public void Constructs_a_new_food()
        {
            // Arrange
            string name = "Protein Shake";
            float calories = 110;
            float protein = 24.5f;
            float carbs = 4;
            float fat = 1;

            // Act
            Food sut = new Food(name, calories, protein, carbs, fat);

            // Assert
            Assert.Equal(name, sut.Name);
            Assert.Equal(calories, sut.Calories, decimalPlaceAccuracy);
            Assert.Equal(protein, sut.Protein, decimalPlaceAccuracy);
            Assert.Equal(carbs, sut.Carbs, decimalPlaceAccuracy);
            Assert.Equal(fat, sut.Fat, decimalPlaceAccuracy);
        }
    }
}