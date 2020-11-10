﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab3454.Services.DemoService;

namespace Lab3454.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoService _demoService;

        public DemoController(IDemoService demoService)
        {
            _demoService = demoService;
        }

        [HttpGet]
        public IActionResult GetByTitle (string title)
        {
            var result = _demoService.GetDataBaseModelMappedByTitle(title);
            return Ok(result);
        }

    }
}
