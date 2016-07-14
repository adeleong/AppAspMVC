using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerPreview.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "This is an <br>HTML</br> string";
        }
        public string HelloWorld()
        {
            return "Hello World string";
        }
        public string HelloName(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode( "Hello "+name+". "+ID+ " Times");
        }
    }
}