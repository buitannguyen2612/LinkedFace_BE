using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Linked_BE.Application.DTOs;
using Linked_BE.Application.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Linked_BE.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly GetAllPostUserCase _getAllPostUserCase;

        public PostController(GetAllPostUserCase getAllPostUserCase)
        {
            _getAllPostUserCase = getAllPostUserCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _getAllPostUserCase.ExecuteAsync();
            return Ok(posts);
        }
    }
}