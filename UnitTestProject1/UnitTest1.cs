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
        [TestMethod]
        public void Can_Create_New_Books()
        {
            //Arrange
            Mock<IBook> mock = new Mock<IBook>();
            mock.Setup(m => m.Books).Returns(new Book[]
            { new Book { Id = 1, Title = "Awesome Book"},
                new Book {Id =2,Title = "Grapes of Swag"}

            });

        }
        [TestMethod]
        public void Can_Create_New_MembershipTypes()
        {
            //Arrange
            Mock<IMembershipType> mock = new Mock<IMembershipType>();
            mock.Setup(m => m.Genres).Returns(new MembershipType[]
            { new MembershipType() { Id = 1, Name = "Action"},
                new MembershipType() {Id =2,Name = "Comedy"}

            });

        }
    }
}
