using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        readonly IUser _IUser;

       public HomeController(IUser IUser)
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
            catch(Exception ex)
            {
                return BadRequest(new { success = false, Message = ex.Message });
            }
        }

/*
        [HttpGet]
        [Route("View")]
        public IActionResult View()
        {
            try
            {

               *//* var displayData = _db.CrudEmpDetails.ToList();
                if (!displayData.Equals(null))
                {
                    return Ok(new { success = true, message = "Successfull", data = displayData });
                }
                else
                {
                    return Ok(new { success = false, message = "Failed" });
                }*//*
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, Message = ex.Message  });
            }
           
        }*/
    }
}
