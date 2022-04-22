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

    public async Task<IEnumerable<Building>> GetBuildingsAll()
    {
        List<Building> buildings = new List<Building>();
        using (var httpClient = new HttpClient())
        {
            //HTTP GET request to the API
            using (var response = await httpClient.GetAsync("https://deployweek8api.azurewebsites.net/api/column/exists/3"))
            {
                //data returned by the API is fetched from the code
                string Get = await response.Content.ReadAsStringAsync();
                //Deserialize the list to a List type object
                buildings = JsonConvert.DeserializeObject<List<Building>>(Get);
            }
        }
        return buildings;
    }
}
