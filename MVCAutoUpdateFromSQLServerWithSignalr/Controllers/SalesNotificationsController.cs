using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAutoUpdateFromSQLServerWithSignalr.DataAccess;

namespace MVCAutoUpdateFromSQLServerWithSignalr.Controllers
{
    public class SalesNotificationsController : Controller
    {
        SalesNotificationsRepository salesNotificationRepository = new SalesNotificationsRepository();
        // GET: SalesNotifications
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllUnreadSalesNotifications()
        {
            return PartialView("_SalesNotificationsList", salesNotificationRepository.GetAllUnreadSalesNotifications());
        }

        public ActionResult MarkSalesNotificationAsRead(int Id)
        {
            salesNotificationRepository.MarkSalesNotificationAsRead(Id);
            return View("Index");
        }
    }
}