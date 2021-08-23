using CodiNova.Repos;
using CodiNova.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAllDetailsService _iAllDetailsService;
        private readonly IPaggination _iPaggination;

        public HomeController(IAllDetailsService iAllDetailsService, IPaggination iPaggination)
        {
            _iAllDetailsService = iAllDetailsService;
            _iPaggination = iPaggination;

        }
        [HttpGet("Details")]
        public async Task<ActionResult> GetEmpPagging(int page = 1,int pagesize = 10)
        {
            try
            {
                return Ok(await _iPaggination.GetEmpPagging(page,pagesize));
            }
            catch(Exception e)
            {
                throw e;
            }

        }
        //[HttpGet("Deprtment")]
        //public async Task<ActionResult> GetDeprtment()
        //{
        //    try
        //    {
        //        return Ok(await _iDepartMentRepo.GetDeprtment());
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //}
        //[HttpGet("project")]
        //public async Task<ActionResult> GetProject()
        //{
        //    try
        //    {
        //        return Ok(await _iProjectRepo.GetProject());
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //}
    }
}
