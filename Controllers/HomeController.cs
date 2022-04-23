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
            using (var bui = new HttpClient()) 
            { 
                List<dynamic> buildings = new List<dynamic>();
                var response = await bui.GetAsync("https://localhost:7098/api/Buildings/List/5");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic buildingList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var building in buildingList){
                    
                     buildings.Add(building);
                    
                    ViewBag.building = buildings;
                    
                }
            }
            using (var bat = new HttpClient()) 
            { 
                List<dynamic> batteries = new List<dynamic>();
                var response = await bat.GetAsync("https://localhost:7098/api/batteries/List/5");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic batteriesList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var battery in batteriesList){
                    
                     batteries.Add(battery);
                    
                    ViewBag.batteries = batteries;
                }    
                // ViewBag.customer = stuff;
                
                
            }
            using (var col = new HttpClient()) 
            { 
                List<dynamic> columns = new List<dynamic>();
                var response = await col.GetAsync("https://localhost:7098/api/columns/List/2");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic columnsList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var column in columnsList){
                    
                     columns.Add(column);
                    
                    ViewBag.columns = columns;
                }    
                // ViewBag.customer = stuff;
                
                
            }
            using (var ele = new HttpClient()) 
            { 
                List<dynamic> elevators = new List<dynamic>();
                var response = await ele.GetAsync("https://localhost:7098/api/elevators/List/12");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic elevatorsList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var elevator in elevatorsList){
                    
                     elevators.Add(elevator);
                    
                    ViewBag.elevators = elevators;
                }    
                // ViewBag.customer = stuff;
                
                
            }

            return View();
        
        }
         public async Task<ActionResult<IEnumerable<Customer>>> interventionForm()
        {
            using (var bui = new HttpClient()) 
            { 
                List<dynamic> buildings = new List<dynamic>();
                var response = await bui.GetAsync("https://localhost:7098/api/Buildings/List/5");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic buildingList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var building in buildingList){
                    
                     buildings.Add(building);
                    
                    ViewBag.building = buildings;
                    
                }
            }
            using (var bat = new HttpClient()) 
            { 
                List<dynamic> batteries = new List<dynamic>();
                var response = await bat.GetAsync("https://localhost:7098/api/batteries/List/5");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic batteriesList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var battery in batteriesList){
                    
                     batteries.Add(battery);
                    
                    ViewBag.batteries = batteries;
                }    
                // ViewBag.customer = stuff;
                
                
            }
            using (var col = new HttpClient()) 
            { 
                List<dynamic> columns = new List<dynamic>();
                var response = await col.GetAsync("https://localhost:7098/api/columns/List/2");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic columnsList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var column in columnsList){
                    
                     columns.Add(column);
                    
                    ViewBag.columns = columns;
                }    
                // ViewBag.customer = stuff;
                
                
            }
            using (var ele = new HttpClient()) 
            { 
                List<dynamic> elevators = new List<dynamic>();
                var response = await ele.GetAsync("https://localhost:7098/api/elevators/List/12");
                string jsonstring = await response.Content.ReadAsStringAsync();
                dynamic elevatorsList = JsonConvert.DeserializeObject<dynamic>(jsonstring);
                foreach(var elevator in elevatorsList){
                    
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

    // static async Task<Building> GetUserListAsync(string path)
    // {
    //     Building building = null;
    //     HttpResponseMessage response = await client.GetAsync(path);
    //     if (response.IsSuccessStatusCode)
    //     {
    //         building = await response.Content.ReadAsAsync<Building>();
    //     }
    //     return building;
    // }

    // public async Task<IEnumerable<User>> GetExistingUsers()
    // {
    //     // Email will be changed to client input
    //     var url = "https://deployweek8api.azurewebsites.net/api/user/exists/thomas.carrier@codeboxx.biz";

    //     using var client = new HttpClient();
    //     var content = await client.GetStringAsync(url);

    //     Console.WriteLine(content);

    //     return content;

    // }

    // public async Task<IEnumerable<Building>> GetBuildings()
    // {
    //     // Change to customer_id
    //     var url = "https://deployweek8api.azurewebsites.net/api/column/exists/3";

    //     if (string.IsNullOrEmpty(url))
    //     {
    //         return null;
    //     }

    //     using var client = new HttpClient();
    //     var content = await client.GetStringAsync(url);

    //     Console.WriteLine(content);

    //     return content;

    // }

    // public async Task<IEnumerable<Building>> GetBuildingsAll()
    // {
    //     List<Building> buildings = new List<Building>();
    //     using (var httpClient = new HttpClient())
    //     {
    //         //HTTP GET request to the API
    //         using (var response = await httpClient.GetAsync("https://deployweek8api.azurewebsites.net/api/column/exists/3"))
    //         {
    //             //data returned by the API is fetched from the code
    //             string Get = await response.Content.ReadAsStringAsync();
    //             //Deserialize the list to a List type object
    //             buildings = JsonConvert.DeserializeObject<List<Building>>(Get);
    //         }
    //     }
    //     return buildings;
    // }
}
