using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Athlete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthleteController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public AthleteController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //CRUD

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateAthlete([FromBody] AthleteCreateDto dto)
        {
            var newAthlete = _mapper.Map<Athlete>(dto);
            await _context.Athletes.AddAsync(newAthlete);
            await _context.SaveChangesAsync();

            return Ok("New athlete added succesfully");
        }

        //Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<Athlete>>> GetAthlete()
        {
            var athletes = await _context.Athletes.Include(a => a.Sport).ToListAsync();
            var dtoAthletes = _mapper.Map<IEnumerable<AthleteGetDto>>(athletes);

            return Ok(dtoAthletes);
        }
    }
}
