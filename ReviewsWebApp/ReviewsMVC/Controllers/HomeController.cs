using ReviewsMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReviewsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<userStory> listStories = new List<userStory>();

            using (var context = new DB_A3F963_reviewsEntities())
            {
                listStories = context.userStory
                    .Where(m => m.IsShared == true)
                    .OrderByDescending(m => m.Id)
                    .Take(10)
                    .ToList();
            }

            return View(listStories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactClass model)
        {
            if (ModelState.IsValid)
            {
                List<userStory> listStories = new List<userStory>();

                using (var context = new DB_A3F963_reviewsEntities())
                {
                    contact contactEntity = new contact();

                    contactEntity.Email = model.Email;
                    contactEntity.ContactName = model.ContactName;
                    contactEntity.Issue = model.Issue;
                    contactEntity.IsAnswered = false;
                    contactEntity.DateCreated = DateTime.Now;

                    context.contact.Add(contactEntity);
                    context.SaveChanges();

                    listStories = context.userStory
                            .Where(m => m.IsShared == true)
                            .OrderByDescending(m => m.Id)
                            .Take(10)
                            .ToList();
                }

                return View("Index", listStories);
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult ShareStory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShareStory(ShareStoryModel model)
        {
            if (ModelState.IsValid) {

                if (Path.GetExtension(model.Images.FileName).ToUpper() != ".JPG"
                    && Path.GetExtension(model.Images.FileName).ToUpper() != ".PNG"
                    && Path.GetExtension(model.Images.FileName) != ".JPEG")
                {
                    ViewBag.ImageFormat = "Use one of this image formats: jpg, png or jpeg";
                    return View();
                }

                if (model.Images.ContentLength > 5220000)
                {
                    ViewBag.ImageFormat = "Maximum image size is 5 MB";
                    return View();
                }

                Random r = new Random();
                int randomNumber = r.Next(1, 100000);
                randomNumber = r.Next(1, 100000) + randomNumber;

                var imagePath = "/Images/" + model.Images.ContentLength.ToString() + randomNumber.ToString() + model.Images.FileName;
                var fileName = Path.Combine(Server.MapPath("~/Images/"), model.Images.ContentLength.ToString() + randomNumber.ToString() + model.Images.FileName);
                List<userStory> listStories = new List<userStory>();

                using (var context = new DB_A3F963_reviewsEntities())
                {
                    userStoryDEV userStoryDEV = new userStoryDEV();

                    userStoryDEV.FullName = model.FullName;
                    userStoryDEV.ImageExt = Path.GetExtension(model.Images.FileName);
                    userStoryDEV.ImageName = model.Images.FileName;
                    userStoryDEV.ImagePath = imagePath;
                    userStoryDEV.KickstarterCamp = model.KickStarterCampaign;
                    userStoryDEV.OrderDate = model.OrderDate;
                    userStoryDEV.OrderNumber = model.OrderNumber;
                    userStoryDEV.PledgedAmount = model.PledgedAmount;
                    userStoryDEV.YourStory = model.YourStory;
                    userStoryDEV.DateCreated = DateTime.Now;
                    userStoryDEV.IsChecked = false;
                    userStoryDEV.IsShared = false;
                    userStoryDEV.BackerNumber = model.BackedNumber;

                    model.Images.SaveAs(fileName);

                    context.userStoryDEV.Add(userStoryDEV);
                    context.SaveChanges();

                    listStories = context.userStory
                        .Where(m => m.IsShared == true)
                        .OrderByDescending(m => m.Id)
                        .Take(10)
                        .ToList();
                }

                return View("Index", listStories);
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult FindStory()
        {
            return View();
        }
    }
}