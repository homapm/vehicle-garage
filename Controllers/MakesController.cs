using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        // private readonly IMapper mapper;
        public MakesController(VegaDbContext context)
        {
            // this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            try
            {
                return await context.Makes.ToListAsync();
                // var makes = await context.Makes.ToListAsync();

                // return mapper.Map<List<Make>, List<MakeResource>>(makes);
            }
            catch (System.Exception)
            {
                throw;
            }

        }

    }
}