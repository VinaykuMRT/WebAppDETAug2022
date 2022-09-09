using Microsoft.AspNetCore.Mvc;
using WebAppDETAug2022MCV.FriendServices;
using WebAppDETAug2022MCV.Models;

namespace WebAppDETAug2022MCV.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<Friend> friends = FriendServices.FriendServices.GetAll();
            return View(friends);
        }

        public IActionResult Details(int id)
        {
            Friend f = FriendServices.FriendServices.Get(id);
            return View(f);
        }
        public IActionResult List()
        {
            List<Friend> friends = FriendServices.FriendServices.GetAll();
            return View(friends);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend f)
        {
            FriendServices.FriendServices.Add(f);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            Friend f = FriendServices.FriendServices.Get(Id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Friend f)
        {
            FriendServices.FriendServices.Delete(f.FriendID);
            return RedirectToAction("List");
        }
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Friend f)
        {
            FriendServices.FriendServices.Update(f);
            return RedirectToAction("List");
        }
    }
}


