using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers {
	public class HomeController : Controller {
		// GET: Home
		public ActionResult Index( ) {
			ViewBag.Fuck = "Fuck";
			ViewBag.Bitch = "Bitch";
			return View( );
		}

		[HttpGet]
		public ActionResult RsvpForm( ) {
			PartyInvites.Models.GuestResponse gr = new Models.GuestResponse {
				Name = "Jianyi Liang" ,
				Email = "liangjianyi.com@outlook.com" ,
				Phone = "+1 (951)-223-1469"
			};
			ViewBag.Guest = gr;
			return View( );
		}

		[HttpPost]
		public ActionResult RsvpForm( PartyInvites.Models.GuestResponse gr ) {
			return View( "Thanks" , gr );
		}
	}
}