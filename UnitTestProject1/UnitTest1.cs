using CollegeBookRental.Models;
using CollegeBookRental.Models.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Create_New_Genres()
        {
            //Arrange
            Mock<IGenre> mock = new Mock<IGenre>();
            mock.Setup(m => m.Genres).Returns(new Genre[]
            { new Genre { Id = 1, Name = "Action"},
                new Genre {Id =2,Name = "Comedy"}

            });

        }
    }
}
