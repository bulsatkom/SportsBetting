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
    public class UpdateEvent_Should
    {
        [Test]
        public void UpdateCorrectEventModel()
        {
            //Arrange
            var db = new Mock<IEfDbSetWrapper<Event>>();
            var startDate = DateTime.UtcNow;
            string name = "Португалия-Испания";
            var elements = new Event()
            {
                Id = 1,
                Name = "Test",
                OddsForDraw = 1,
                OddsForFirstTeam = 1,
                OddsForSecondTeam = 1,
                StartDate = startDate
            };
          

            EventService eventService = new EventService(db.Object);

            db.Setup(x => x.All).Returns(new List<Event>() { elements }.AsQueryable());

            //Act
           var el = eventService.UpdateEvent(1, name, 4, 3, 2, startDate.AddDays(1));

            //Assert
            Assert.AreEqual(4, el.OddsForFirstTeam);
            Assert.AreEqual(3, el.OddsForDraw);
            Assert.AreEqual(2, el.OddsForSecondTeam);
            Assert.AreEqual(name, el.Name);
            Assert.AreEqual(startDate.AddDays(1), el.StartDate);
        }
    }
}
