using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Sport;
using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }
        public SportController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // CRUD

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateSport([FromBody] SportCreateDto dto)
        {
            Sport newSport = _mapper.Map<Sport>(dto);
            await _context.Sports.AddAsync(newSport);
            await _context.SaveChangesAsync();

            return Ok("New sport added");
        }

        //Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<SportGetDto>>> GetSports()
        {
            var sports = await _context.Sports.ToListAsync();
            var dtoSports = _mapper.Map<IEnumerable<SportGetDto>>(sports);

            return Ok(dtoSports);
        }

        //TODO - Read (Get Sport by Id)
    }
}
