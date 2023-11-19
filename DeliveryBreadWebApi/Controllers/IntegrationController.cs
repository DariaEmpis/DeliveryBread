using DeliveryBreadWebApi.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryBreadWebApi.Controllers
{
    [ApiController]
    [Route("produce")]
    public class IntegrationController : Controller
    {
        [HttpPost]
        public Task PostExpedition(ExpeditionDto expedition) 
        { 
            return Task.CompletedTask; 
        }
    }
}
