using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class ProfessionsController : BaseApiController
    {
        private readonly DataContext _context;

        public ProfessionsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Character> GetCharacters()
        {
            return _context.Character.ToList();
        }
    }
}