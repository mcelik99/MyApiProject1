using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("http://localhost:5000/api/Contact");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);

                    if (values != null)
                    {
                        return View(values);
                    }
                    else
                    {
                        // Gelen veri null ise veya boş ise uygun bir işlem yap
                       
                        return View("NoDataFound");
                    }
                }
                else
                {
                    // API'den geçerli bir yanıt alınamadıysa uygun bir işlem yap.
                    
                    return View("ApiError"); 
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa uygun bir işlem yap.
                
                return View("Error", ex); 
            }
        }
        public PartialViewResult SideBarAdminContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }
    }
}
