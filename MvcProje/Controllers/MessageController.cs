﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class MessageController : Controller
    {
        MessageManager cm = new MessageManager(new EfMessageDal());
        // GET: Message
        public ActionResult Inbox()
        {
            var messagelist = cm.GetListInbox();
            return View(messagelist);
        }
        public ActionResult Sendbox()
        {
            var messagelist = cm.GetListSendInbox();
            return View(messagelist);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            return View();
        }
    }
}