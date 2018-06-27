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
    public class GetAll_Should
    {
        [Test]
        public void ReturnCorrectEvents()
        {
            //Arrange
            var db = new Mock<IEfDbSetWrapper<Event>>();

            var elements = new List<Event>()
            {
                new Event()
                {
                    Id = 1,
                    Name = "Test",
                    OddsForDraw = 1,
                    OddsForFirstTeam = 1,
                    OddsForSecondTeam = 1,
                    StartDate = DateTime.UtcNow
                }
            };

            EventService eventService = new EventService(db.Object);

            db.Setup(x => x.All).Returns(elements.AsQueryable());

            //Act
           var result = eventService.GetAll();

            //Assert
            Assert.AreEqual(1, result.Count);
        }
    }
}
