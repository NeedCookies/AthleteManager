using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Competition;
using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }

        public CompetitionController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        //CRUD

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompetition([FromBody] CompetitionCreateDto dtoComp)
        {
            var newComp = _mapper.Map<Competition>(dtoComp);
            await _context.Competitions.AddAsync(newComp);
            await _context.SaveChangesAsync();

            return Ok("Competition created succesfully");
        }

        //Get
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CompetitionGetDto>>> GetCompetititons()
        {
            var comps = await _context.Competitions.Include(c => c.Sport).ToListAsync();
            var dtoComps = _mapper.Map<IEnumerable<CompetitionGetDto>>(comps);

            return Ok(dtoComps);
        }
    }
}
