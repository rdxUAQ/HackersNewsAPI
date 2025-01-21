using HackersNewsAPI.Models;

namespace HackersNewsAPI.Interfaces
{
    public interface IStoriesService
    {

        Task<List<StoryModel?>> GetStoriesByBestN(int n);

    }
}
