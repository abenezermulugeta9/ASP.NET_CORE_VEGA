﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.API.Controllers.Resources;
using Vega.API.Core.Models;
using Vega.API.Persistance;

namespace Vega.API.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await _context.Makes.Include(m => m.Models).ToListAsync();
            return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
