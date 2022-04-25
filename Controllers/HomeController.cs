using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrancisVersion.Models;
using Newtonsoft.Json;
using System.Dynamic;


namespace FrancisVersion.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Smarty()
    {
        return View();
    }
    public IActionResult product()
    {
        return View();
    }



    public IActionResult reviews()
    {
        return View();
    }


    public async Task<ActionResult<IEnumerable<Customer>>> myProducts()
    {
        var currentUserEmail = User.Identity?.Name;

        // using (var bui = new HttpClient())
        // {
        //     List<dynamic?> buildings = new List<dynamic?>();
        //     var response = await bui.GetAsync($"https://deployweek8api.azurewebsites.net/api/building/buildinglist/{currentUserEmail}/");
        //     string jsonstring = await response.Content.ReadAsStringAsync();
        //     dynamic? buildingsList = JsonConvert.DeserializeObject<dynamic?>(jsonstring);
        //     foreach (var building in buildingsList)
        //     {

        //         buildings.Add(building);

        //     }
        //     ViewBag.buildings = buildings;
        //     // ViewBag.customer = stuff;


        // }
        using (var bat = new HttpClient())
        {


            var client = new HttpClient();


            List<dynamic?> batteries = new List<dynamic?>();
            var response = await bat.GetAsync($"https://deployweek8api.azurewebsites.net/api/battery/batterylist/{currentUserEmail}/");
            Console.WriteLine($"current email of the user {currentUserEmail}");
            string jsonstring = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"jsonstring variable = {jsonstring}");
            dynamic? batteriesList = JsonConvert.DeserializeObject<dynamic?>(jsonstring);
            foreach (var battery in batteriesList)
            {

                batteries.Add(battery);



            }
            ViewBag.batteries = batteries;
            // ViewBag.customer = stuff;


        }
        using (var col = new HttpClient())
        {
            List<dynamic?> columns = new List<dynamic?>();
            var response = await col.GetAsync($"https://deployweek8api.azurewebsites.net/api/column/columnlist/{currentUserEmail}/");
            string jsonstring = await response.Content.ReadAsStringAsync();
            dynamic? columnsList = JsonConvert.DeserializeObject<dynamic?>(jsonstring);
            foreach (var column in columnsList)
            {

                columns.Add(column);


            }
            ViewBag.columns = columns;
            // ViewBag.customer = stuff;


        }
        using (var ele = new HttpClient())
        {
            List<dynamic?> elevators = new List<dynamic?>();
            var response = await ele.GetAsync($"https://deployweek8api.azurewebsites.net/api/elevator/elevatorlist/{currentUserEmail}/");
            string jsonstring = await response.Content.ReadAsStringAsync();
            dynamic? elevatorsList = JsonConvert.DeserializeObject<dynamic?>(jsonstring);
            foreach (var elevator in elevatorsList)
            {

                elevators.Add(elevator);


            }
            ViewBag.elevators = elevators;
            // ViewBag.customer = stuff;


        }

        return View();

    }
    public async Task<ActionResult<IEnumerable<Customer>>> interventionForm()
    {
        var currentUserEmail = User.Identity?.Name;
        
        // using (var bui = new HttpClient())

        // {
        //     List<dynamic?> buildings = new List<dynamic?>();
        //     var response = await bui.GetAsync($"https://deployweek8api.azurewebsites.net/api/building/buildinglist/{currentUserEmail}/");
        //     string jsonstring = await response.Content.ReadAsStringAsync();
        //     dynamic? buildingList = JsonConvert.DeserializeObject<dynamic?>(jsonstring);
        //     foreach (var building in buildingList)
        //     {

        //         buildings.Add(building);

        //         ViewBag.buildings = buildings;

        //     }
        // }
        ViewBag.building = new List<dynamic?>();
        using (var bat = new HttpClient())
        {
            List<dynamic?> batteries = new List<dynamic?>();
            var response = await bat.GetAsync($"https://deployweek8api.azurewebsites.net/api/battery/batterylist/{currentUserEmail}/");
            string jsonstring = await response.Content.ReadAsStringAsync();
            List<dynamic?> batteriesList = JsonConvert.DeserializeObject<List<dynamic?>>(jsonstring);
            foreach (var battery in batteriesList)
            {

                batteries.Add(battery);

                ViewBag.batteries = batteries;
            }
            // ViewBag.customer = stuff;


        }
        using (var col = new HttpClient())
        {
            List<dynamic?> columns = new List<dynamic?>();
            var response = await col.GetAsync($"https://deployweek8api.azurewebsites.net/api/column/columnlist/{currentUserEmail}/");
            string jsonstring = await response.Content.ReadAsStringAsync();
            dynamic? columnsList = JsonConvert.DeserializeObject<dynamic?>(jsonstring);
            foreach (var column in columnsList)
            {

                columns.Add(column);

                ViewBag.columns = columns;
            }
            // ViewBag.customer = stuff;


        }
        using (var ele = new HttpClient())
        {
            List<dynamic> elevators = new List<dynamic>();
            var response = await ele.GetAsync($"https://deployweek8api.azurewebsites.net/api/elevator/elevatorlist/{currentUserEmail}/");
            string jsonstring = await response.Content.ReadAsStringAsync();
            dynamic elevatorsList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
            foreach (var elevator in elevatorsList)
            {

                elevators.Add(elevator);

                ViewBag.elevators = elevators;
            }
            // ViewBag.customer = stuff;


        }

        return View();

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}