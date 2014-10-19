using Microsoft.VisualStudio.TestTools.UnitTesting;

using SS.Lib.Service;

namespace SS.Tests
{
    [TestClass]
    public class TestUrl
    {
        [TestMethod]
        public void Test_that_we_get_correct_name_from_url()
        {
            //Arrange
            var input = "0704332163";
            var expectedName = "Ellie Ewerlow Casan";
            //Act
            IScreenService service= new ScreepService();
            var actual = service.GetName(input);
            //Assert

            Assert.AreEqual(expectedName,actual.FullName);
        }
    }
}
