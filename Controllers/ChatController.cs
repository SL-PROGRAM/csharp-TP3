using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.database;
using WebApplication1.Models.TP.Models;

namespace WebApplication1.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            List<Chat> listChat = FakeDB.Instance.GetMeuteDeChats();

            return View(listChat);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            List<Chat> listChat = FakeDB.Instance.GetMeuteDeChats();
            Chat chat = listChat.Where(c => c.Id == id).FirstOrDefault();
            return View(chat);
        }
  
        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            List<Chat> listChat = FakeDB.Instance.GetMeuteDeChats();
            Chat chat = listChat.Where(c => c.Id == id).FirstOrDefault();
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                List<Chat> listChat = FakeDB.Instance.GetMeuteDeChats();
                Chat chat = listChat.Where(c => c.Id == id).FirstOrDefault();
                listChat.Remove(chat);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
