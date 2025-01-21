using HackersNewsAPI.Interfaces;
using HackersNewsAPI.Models;
using System.Text.Json;

namespace HackersNewsAPI.Services
{
    public class StoriesService : IStoriesService
    {
        private readonly HttpClient _httpClient;
        public StoriesService(HttpClient httpClient) {

            _httpClient = httpClient;

        }
        public async Task<List<StoryModel?>> GetStoriesByBestN(int n)
        {
            var url = "https://hacker-news.firebaseio.com/v0/beststories.json";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode) return new List<StoryModel?>();


            var storiesId = await JsonSerializer.DeserializeAsync<List<int>>(await response.Content.ReadAsStreamAsync());

            var stories = new List<StoryModel?>();

           

            foreach (int storyId in storiesId.Take(n))
            {
                var storyUrl = "https://hacker-news.firebaseio.com/v0/item/"+storyId+".json";

                var storyResponse = await _httpClient.GetAsync(storyUrl);

                if(!storyResponse.IsSuccessStatusCode) return new List<StoryModel?>();

                var story = await JsonSerializer.DeserializeAsync<StoryModel>(await storyResponse.Content.ReadAsStreamAsync());



                stories.Add(story);
            }

            //get stories by API
            return stories;
        }
    }
}
