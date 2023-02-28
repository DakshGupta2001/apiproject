using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;


using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;





namespace FirstApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase{
        // private readonly IConfiguration db;
        // public LoginController(IConfiguration _db){
        //     db = _db;
        // }

        private readonly ACE42023Context db;
        // private readonly  ISession session; 
        // ,IHttpContextAccessor httpContextAccessor
        public LoginController(ACE42023Context _db){
            db = _db;
            // session = httpContextAccessor.HttpContext.Session;
        }
        
        [HttpPost]
        [Route("register")]
        public ActionResult register(DakshUser a){
            db.DakshUsers.Add(a);
            db.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        public ActionResult login(DakshUser ? u){
              if(u.Username == null || u.Userpassword == null){
                return BadRequest(new {Message = "Username and Password are Required!"});
            } 
            var result = (from i in db.DakshUsers
                            where  i.Username == u.Username && i.Userpassword == u.Userpassword
                            select i).SingleOrDefault();
            
            if(result != null){
                return Ok(result);
            }
            else{
                return Unauthorized(new {Message = "Invalid Credentials!"});
            }
        }
    }

}