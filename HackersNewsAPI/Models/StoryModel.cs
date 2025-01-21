namespace HackersNewsAPI.Models
{
    public class StoryModel
    {

        public string? by { get; set; }
        public int descendants { get; set; }
        public int id { get; set; }
        public List<int>? kids { get; set; }
        public int score { get; set; }
        public int time { get; set; }
        public string? title { get; set; }
        public string? type { get; set; }
        public string? url { get; set; }

        /*
        "by" : "dhouston",
        "descendants" : 71,
        "id" : 8863,
        "kids" : [9224, 8917, 8884, 8887, 8952, 8869, 8873, 8958, 8940, 8908, 9005, 9671, 9067, 9055, 8865, 8881, 8872, 8955, 10403, 8903, 8928, 9125, 8998, 8901, 8902, 8907, 8894, 8870, 8878, 8980, 8934, 8943, 8876],
        "score" : 104,
        "time" : 1175714200,
        "title" : "My YC app: Dropbox - Throw away your USB drive",
        "type" : "story",
        "url" : "http://www.getdropbox.com/u/2/screencast.html"
        */

    }
}
