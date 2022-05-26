using Cleaning_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class UnitTestStaff
    {
        [Fact]
        public void MajorCleaningToStringTest()
        {
            //Arrange
            StaffMember staffMember;

            //Act
            staffMember = new StaffMember("John", "Mikla", "Milka@GMail.com", "01257 385382", "JMikla", "Password");

            //Assert
            Assert.Equal(Enums.StaffType.TEAM_MEMBER, staffMember.Type);

        }
    }
}