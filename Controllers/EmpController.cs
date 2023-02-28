using System;
using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace FirstApi.Controllers{
    [ApiController]
    //api versioning - install the package versioning
    // [ApiVersion("1.0")]
    // [Route("api/{v:ApiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase{
        private readonly ACE42023Context db;
        public EmpController(ACE42023Context _db){
            db = _db;
        }

        [HttpGet]
        // [Route("getempbyId")]
        public async Task<ActionResult<List<SuneetEmployee>>> GetDetails(){
            return Ok(await db.SuneetEmployees.ToListAsync());
        }
        //checking multiple gets
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<SuneetEmployee>>> GetDetails(int id){
            // Empharshit e = await db.Empharshit.Where(x=>x.Eid==id).SingleOrDefault();
            SuneetEmployee e = await db.SuneetEmployees.FindAsync(id);
            if(e!=null){
                return Ok(e);
            }
            else{
                return NotFound(); //helper methods BadRequest() also
            }
        }
        //post code
        [HttpPost]
        public async Task<ActionResult> AddEmployee([FromBody] SuneetEmployee e){
            // Console.WriteLine(e.EmployeeId);
            // Console.WriteLine(e.EmployeeId);
            // Console.WriteLine(e.EmployeeId);
            // Console.WriteLine(e.EmployeeId);
            // Console.WriteLine(e.EmployeeId);
            // Console.WriteLine(e.EmployeeId);

            if(ModelState.IsValid){
                db.SuneetEmployees.Add(e);
                await db.SaveChangesAsync();
                return Ok(e);
            }
             else{
                return BadRequest(new {Message = "Please Provide details in valid form!"});
            }
        }
        //put code
        [HttpPut("{id}")]
        public async Task<ActionResult> EditEmployee(int id, SuneetEmployee e){
            Console.WriteLine(e.EmployeeId);
            db.SuneetEmployees.Update(e);
            await db.SaveChangesAsync();
            return Ok(e);
        }
        //delete code
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int? id){
            if(id==null)
                return BadRequest();
            
            SuneetEmployee e =await db.SuneetEmployees.FindAsync(id);
            if(e!=null){
                db.SuneetEmployees.Remove(e);
                await db.SaveChangesAsync();
            }
            else{
                return NotFound();
            }
            return Ok(e); //returning 'e' bcz of api working
        }
        [HttpPost]
        [Route("api/[controller]/Search")]
        public async Task<ActionResult> Search([FromBody] string keyword){
        var result = db.SuneetEmployees.Where(x => x.FirstName.Contains(keyword)).Select(x=>x).ToList();
        return Ok(result);
        }

    }
}