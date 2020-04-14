using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShowMyIp.Services;

namespace ShowMyIp.Controllers
{
    public class IpController : Controller
    {
        private readonly IGetIpAddressService _ipAddressService;

        public IpController(IGetIpAddressService ipAddressService)
        {
            _ipAddressService = ipAddressService;
        }
        public IActionResult Index()
        {
            var viewModel = new  IpViewModel{IpAdress = _ipAddressService.GetRequestIp() };
            return View(viewModel);
        }
         
    }
}