using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BROOKLYN.SHARED.Entities;
using BROOKLYN.API.Data;



namespace BROOKLYN.API.Controllers
{


    [ApiController]
    [Route("/api/employees")]



    public class EmployeesController : ControllerBase
    {


        private readonly DataContext _context;


        public EmployeesController(DataContext context)
        {
            _context = context;
        }



        //Get con lista
        //Select * From owners

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Employees.ToListAsync());


        }



        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {


                return NotFound();
            }

            return Ok(employee);


        }


        [HttpPut]
        public async Task<ActionResult> Put(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }



        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.Employees
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }



        [HttpPost]
        public async Task<ActionResult> Post(Employee employee)
        {

            _context.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);

        }
    }
}

