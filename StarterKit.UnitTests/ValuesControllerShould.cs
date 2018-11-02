using System;
using StarterKit.Web.ApiControllers;
using Xunit;
using System.Linq;

namespace StarterKit.UnitTests
{
    public class ValuesControllerShould
    {
        [Fact]
        public void GetAllValues()
        {
            // Arrange
            var valueController = new ValuesController();

            // Act
            var result = valueController.Get();

            //Assert
            Assert.Equal(2, result.Count());
        }
    }
}
