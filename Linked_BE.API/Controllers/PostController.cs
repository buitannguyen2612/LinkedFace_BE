using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Linked_BE.Application.DTOs;
using Linked_BE.Application.Services;
using Linked_BE.Application.Services.Posts;
using Linked_BE.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Linked_BE.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        // This variable is just running in one time only, so its only run in constructor, and after that ti can not be use anymore
        private readonly GetAllPostUseCase _getAllPostUseCase;

        // This variable is just running in one time only, so its only run in constructor, and after that ti can not be use anymore
        private readonly CreateNewPostUseCase _createNewPostUseCase;

        public PostController(GetAllPostUseCase getAllPostUserCase, CreateNewPostUseCase createNewPostUseCase)
        {
            _getAllPostUseCase = getAllPostUserCase;
            _createNewPostUseCase = createNewPostUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _getAllPostUseCase.ExecuteAsync();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] PostCreateDTO postRequest)
        {
            await _createNewPostUseCase.CreatePostAsync(postRequest);
            return CreatedAtAction(nameof(CreatePost), postRequest);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePost()
        {
            var posts = await _getAllPostUseCase.ExecuteAsync();
            return Ok(posts);
        }
    }
}