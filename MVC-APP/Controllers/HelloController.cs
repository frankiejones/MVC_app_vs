using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_APP.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(); // speaks to the file with the same name
            // by default it looks for index
            // View = the name of the method if it matches the name of the Views/FileNameHere
        }




        // we are rendering below https://localhost:{PORT}/Hello
        //public string Index() // our home for the controller, index is a key word
        //    // public strinn Index is our GET, so its going to get /Hello/ its called Hello because we have names our document HelloControlller.
        //{
        //    return "this is my go to page for my controller";
        //}

        // we are rendering below https://localhost:{PORT}/Hello/Wassup
        //public string Wassup()
        //    // this will GET our Hello/Wassup, so a sub page of our Hello controller
        //{
        //    return "Wassuuuuup";
        //}
        //// we are rendering below https://localhost:{PORT}/Hello/Demo
        //public string Demo(string name, int ID)
        //// this will GET our Hello/Wassup, so a sub page of our Hello controller
        //{
        //    //return "Demo";
        //    //name = "Jacob";
        //    //ID = 1;
        //    return HtmlEncoder.Default.Encode($"Hello {name}. Your ID is :{ID}");
        //    //https: //localhost:5001/Hello/Demo?name=Charmaine&ID=2 syntax for displaying.
        //}
    }
}
