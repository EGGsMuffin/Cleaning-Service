using Cleaning_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitTestCleaning
    {
        [Fact]
        public void MajorCleaningToStringTest()
        {
            //Arrange
            MajorCleaning majorCleaning;

            //Act
            majorCleaning = new MajorCleaning("Fire Damage", Enums.CleaningSeverity.MEDIUM);
            string? majorCleaningString = majorCleaning.ToString();

            //Assert
            Assert.IsType<MajorCleaning>(majorCleaning);
            Assert.Equal(majorCleaningString, $"Description: Fire Damage Priority: MEDIUM");

        }

        [Fact]
        public void MinorCleaningCheckTypeTest()
        {
            //Arrange
            MinorCleaning minorCleaning;

            //Act
            minorCleaning = new MinorCleaning("Mopping");
            string? minorCleaningString = minorCleaning.ToString();

            //Assert
            Assert.IsType<MinorCleaning>(minorCleaning);
            Assert.Equal(minorCleaningString, $"Description: Mopping");

        }
    }
}