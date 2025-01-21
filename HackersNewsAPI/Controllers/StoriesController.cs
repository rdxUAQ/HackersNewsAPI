using HackersNewsAPI.Interfaces;
using HackersNewsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HackersNewsAPI.Controllers
{

   
    [ApiController]
    [Route("api/v1/stories")]
    public class StoriesController : Controller
    {
        private readonly IStoriesService? _storiesService;

        public StoriesController(IStoriesService storiesService)
        {
            _storiesService = storiesService;
        }

        [HttpGet]
        [Route("best/{n}")]
        public async Task<IActionResult> GetStoriesByBestN(int n)
        {

            if (n == 0) return BadRequest();

            var result = await _storiesService.GetStoriesByBestN(n);

            if (result.Count < 0)
            {
                return NotFound();
            }

            List<StoryDTO> response = new List<StoryDTO>();

            foreach (var story in result)
            {
                StoryDTO storyDto = new StoryDTO();
                storyDto.Title = story?.title;
                storyDto.uri = story?.url;
                storyDto.PostedBy = story?.by;
                storyDto.Score = story?.score ?? 0;
                storyDto.CommentCount = story?.kids?.Count ?? 0;
                storyDto.Time = DateTime.Now;
                response.Add(storyDto);
            }
            return Ok(response);
        }
    }
}
