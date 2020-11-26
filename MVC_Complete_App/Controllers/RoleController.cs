using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVC_Complete_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Complete_App.Controllers
{
    /// <summary>
    /// This cvontroller will; be used to create roles and Display roles
    /// </summary>
    public class RoleController : Controller
    {

        ApplicationDbContext context;
        /// <summary> 
        /// Resolve the ApplicationDbContext that contains
        /// properties for Roles and Users
        /// </summary>
        public RoleController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        // GET: Role
        /// <summary>
        ///  Get All Roles
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var roles = context.Roles.ToList();
            return View(roles);
        }

        /// <summary>
        /// TO return view for creating New Role
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var role = new IdentityRole();
            return View(role);
        }

        [HttpPost]
        public ActionResult Create(IdentityRole role)
        {
            context.Roles.Add(role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}