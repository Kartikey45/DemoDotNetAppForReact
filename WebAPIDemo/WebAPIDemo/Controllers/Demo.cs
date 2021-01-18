using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Demo : ControllerBase
    {
        readonly IUser _IUser;

        public Demo(IUser IUser)
        {
            _IUser = IUser;
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(EmpDetails emp)
        {

            try
            {

                EmpDetails data = _IUser.Add(emp);
                if (!data.Equals(null))
                {
                    return Ok(new { success = true, Message = "Added successfully", Data = emp });
                }
                else
                {
                    return Ok(new { success = false, Message = "failed to add", Data = emp });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("View")]
        public IActionResult View()
        {
            try
            {
               var displayData = _IUser.View();
                if (!displayData.Equals(null))
                {
                    return Ok(new { success = true, message = "Successfull", data = displayData });
                }
                else
                {
                    return Ok(new { success = false, message = "Failed" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, Message = ex.Message });
            }

        }
    }
}
