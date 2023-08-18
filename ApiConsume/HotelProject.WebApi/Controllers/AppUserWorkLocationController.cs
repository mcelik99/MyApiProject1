using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserWorkLocationController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpGet] 
        public ActionResult Index() 
        { 
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y=> new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                SurName = y.SurName,
                WorkLocationId = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                ImageUrl = y.ImageUrl
                
            }).ToList(); 
           // var values= _appUserService.TUsersListWithWorkLocations();
            return Ok(values); 
        }

    }
}
