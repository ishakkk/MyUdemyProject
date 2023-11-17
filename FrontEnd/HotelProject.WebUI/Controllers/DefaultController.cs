using HotelProject.WebUI.Models.Dtos.ServiceDto;
using HotelProject.WebUI.Models.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubscribeDto createSubscribeDto)
        {

           
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responsemessage = await client.PostAsync("https://localhost:7134/api/Subscribe", stringContent);
                if (responsemessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index","Default");
                }

                return View();

           

        }
    }
}
