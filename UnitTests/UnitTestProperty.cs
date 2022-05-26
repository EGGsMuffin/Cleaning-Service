using Cleaning_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitTestProperty
    {
        [Fact]
        public void CommercialToStringTest()
        {
            //Arrange
            Commercial propertyToTest;

            //Act
            propertyToTest = new Commercial("Brick Lane", "John Mikla", Enums.CommericalType.RETAIL, 1000, new Customer("Harry", "Bayu", "Harry@Gmail.com", "19348 384399"));
            var testString = propertyToTest.ToString();

            //Assert
            Assert.Equal("Address: Brick Lane Name: John Mikla Type: RETAIL Size: 1000", testString);

        }

        [Fact]
        public void DomesticCheckTypeTest()
        {
            //Arrange
            Domestic propertyToTest;

            //Act
            propertyToTest = new Domestic("Brick Lane", Enums.DomesticType.SEMI_DETACHED, 4, new Customer("John", "Mikla", "Mikla@Gmail.com", "19348 384349"));
            var testString = propertyToTest.ToString();

            //Assert
            Assert.Equal("Address: Brick Type: SEMI_DETACHED Number Of Rooms: 4", testString);

        }
    }
}