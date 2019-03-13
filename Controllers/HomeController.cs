using Microsoft.AspNetCore.Mvc;


namespace TimeDisplay
{

    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Home()
        {
            return View("Index");
        }

        // [HttpGet("projects")]
        // public ViewResult Projects()
        // {
        //     return View("Projects");
        // }

        // [HttpGet("contact")]
        // public ViewResult Contact()
        // {
        //     return View("Contact");
        // }





        // // localHost: 5000/
        // [Route("")]
        // [HttpGet]   //request
        // public ViewResult HiThere()
        // {
        //     // Views/Home/HiThere.cshtml
        //     return View();
        // }

        // [HttpGet("runme")]
        // public JsonResult Example()
        // {
        //     var AnonObject = new {
    	//     FirstName = "Raz",
	    //     LastName = "Aquato",
    	//     Age = 10};

        //     return Json(AnonObject);
        // }

        // [HttpGet]
        // [Route("home")]
        // public IActionResult Home()
        // {
        //     // Here we assign the value "Hello World!" to the property .Example
        //     // Property names are arbitrary and can be whatever you like
        //     ViewBag.Example = "Hello World!";
        //     return View();
        // }

        // [HttpGet("hello/{name}")]
        // public ViewResult Hello(string name)
        // {
        //     System.Console.WriteLine($"\n\n\nHello {name}!");
        //     return View();
        // }

        // //This /redirect url will redirect back to /hello path
        // [HttpGet("redirect")]
        // public RedirectToActionResult Redirect()
        // {
        //     System.Console.WriteLine("\n\n\n\nRedirecting to /hello...");
        //     return RedirectToAction("Hello", new{name="paul"});
        // }


        




    }
}