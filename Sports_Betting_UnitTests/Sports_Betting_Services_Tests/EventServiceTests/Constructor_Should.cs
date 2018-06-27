using Moq;
using NUnit.Framework;
using Sports_Betting_Data;
using Sports_Betting_Data.Interfaces;
using Sports_betting_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Betting_UnitTests.Sports_Betting_Services_Tests.EventServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void Return_An_Instance_When_Parameter_Is_NotNull()
        {
            //Arrange
            var dbcontext = new Mock<IEfDbSetWrapper<Event>>();

            //Act
            var eventService = new EventService(dbcontext.Object);

            //Assert
            Assert.IsNotNull(eventService);
        }

        [Test]
        public void Throw_Exception_Wnen_Parameter_IsNull()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => new EventService(null));
        }
    }
}
