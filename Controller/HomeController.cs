using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowillence.Yaapiyal
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        private YaapiyalDBContext _dbContext;

        public HomeController(IConfiguration Configuration, YaapiyalDBContext DBContext)
        {
            _configuration = Configuration;
            _dbContext = DBContext;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _configuration["Message"];
            return View(_dbContext.ref_record_status.ToList());
        }
    }
}
