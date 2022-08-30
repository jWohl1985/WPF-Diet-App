using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Models;

namespace DietAppTests
{
    public class BodyMeasurementsTests
    {
        private int decimalPlaceAccuracy = 2;

        [Fact]
        public void Constructs_new_measurements()
        {
            // Arrange
            float neck = 13.5f;
            float waist = 34.75f;
            float hips = 36.2f;

            // Act
            BodyMeasurements sut = new BodyMeasurements(neck, waist, hips);

            // Assert
            Assert.Equal(neck, sut.Neck, decimalPlaceAccuracy);
            Assert.Equal(waist, sut.Waist, decimalPlaceAccuracy);
            Assert.Equal(hips, sut.Hips, decimalPlaceAccuracy);
        }
    }
}
