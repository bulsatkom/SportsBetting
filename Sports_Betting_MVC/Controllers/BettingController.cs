using Sports_Betting_MVC.Models;
using Sports_Betting_MVC.Models.Betting;
using Sports_betting_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_Betting_MVC.Controllers
{
    public class BettingController : Controller
    {
        private readonly IEventService eventService;

        public BettingController(IEventService eventService)
        {
            this.eventService = eventService;
        }
        
        //public ActionResult events(bool editMode = false)
        //{
        //    return this.View("events", editMode);
        //}

        public ActionResult PreviewModePartial()
        {
            var model = new List<MatchViewModel>();

            this.eventService.GetAll().ToList().ForEach(x =>
            {
                model.Add(new MatchViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    StartDate = x.StartDate,
                    OddsForDraw = x.OddsForDraw,
                    OddsForFirstTeam = x.OddsForFirstTeam,
                    OddsForSecondTeam = x.OddsForSecondTeam
                });
            });

            return this.View(model);
        }

        [HttpGet]
        public ActionResult EditModePartial()
        {
            var model = new List<EditViewModel>();

            this.eventService.GetAll().ToList().ForEach(x =>
            {
                model.Add(new EditViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    OddsForDraw = x.OddsForDraw,
                    OddsForFirstTeam = x.OddsForFirstTeam,
                    OddsForSecondTeam = x.OddsForSecondTeam,
                    StartDate = x.StartDate
                });
            });

            return this.View(model);
        }

        public ActionResult AddNew()
        {           
            this.eventService.AddsNew();

            return this.RedirectToAction("EditModePartial");
        }

        [HttpPost]
        public ActionResult SaveEvent(EditViewModel model)
        {
            if(ModelState.IsValid)
            {
                this.eventService.UpdateEvent(model.Id, model.Name, model.OddsForFirstTeam, model.OddsForDraw, model.OddsForSecondTeam,
                model.StartDate);

                return this.RedirectToAction("EditModePartial");
            }

            return this.RedirectToAction("EditModePartial");
        }

        public ActionResult DeleteEvent(int id)
        {
            this.eventService.DeleteEvent(id);

            return this.RedirectToAction("EditModePartial");
        }

        public ActionResult Logging(int Eventid, string selectedOdd, double coeff)
        {
            if(Session["message"] != null)
            {
                List<string> Messages = Session["message"] as List<string>;
                Messages.Add(Eventid + " " + selectedOdd + " " + coeff);
                Session["message"] = Messages;
            }
            else
            {
                Session.Add("message", new List<string>() { Eventid + " " + selectedOdd + " " + coeff });               
            }

            return this.RedirectToAction("PreviewModePartial");
        }
    }
}