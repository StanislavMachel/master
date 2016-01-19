using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TestingDemo.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();
            // displat some results
            return View();
        }
    }


    public class User
    {
        public string LoginName { get; set; }
    }

    public interface IUserRepository
    {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }

    public class DefaultUserRepository : IUserRepository
    {

        public void Add(User newUser)
        {
            // TODO:
        }

        public User FetchByLoginName(string loginName)
        {
            return new User() { LoginName = loginName };
        }

        public void SubmitChanges()
        {
            // TODO:
        }
    }


}

