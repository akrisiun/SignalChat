using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetsChatApplication.Controllers
{
    public class ChatController : LetsChatController
    {
        public override ActionResult Index()
        {
            this.RouteData.Values["Controller"] = "LetsChat";
            this.RouteData.Values["Action"] = "Index";
            return View(); // "LetsChat", "LetsChat");
        }
    }

    public class LetsChatController : Controller
    {
        public virtual ActionResult Index()
        {
            this.RouteData.Values["Action"] = "Index";
            return View("Index");
        }

        // GET: LetsChat
        public ActionResult LetsChat()
        {
            this.RouteData.Values["Action"] = "Index";
            // return View("LetsChat", "Index");
            return View("Index");
        }

        public void SaveSession(string name, string sessionId)
        {
            // Call the addNewMessageToPage method to update clients.
            using (var context = new ChatDemoAppEntities()) {
                var chatTbl = new ChatApp
                {
                    ChatSession = sessionId,
                    UserName = name
                };
                context.ChatApps.Add(chatTbl);
                context.SaveChanges();
            }
        }

        public bool CheckSession(string sessionValue)
        {
            using (var context = new ChatDemoAppEntities()) {
                var checkSession = context.ChatApps.FirstOrDefault(x => x.ChatSession == sessionValue.Trim()) != null;
                return checkSession;
            }
        }
    }
}