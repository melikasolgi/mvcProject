using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using myResume.Models;

namespace myResume.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Projects = new List<Project>
            {
             new Project(1 ," تاکسی " ,"درخواست تاکسی برای مسافت درون شهری","Project-1.jpg","taxiTitle"),
              new Project(2 ," غذا " ,"درخواست برای غذا","Project-2.jpg","Zoodfood"),
                  new Project(3 ," سیستم  " ,"سیستم مدیریت یکپارچه مدارس","Project-3.jpg","Monop"),
            };
            return View("_projects",Projects);
        }
    }
}
