using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Video.Abstract;

namespace Video.Service
{
    public class YoutubeService : IVideoService, IServiceDependency
    {
        private IProviderConfigurator _providerConfigurator;

        public YoutubeService(IProviderConfigurator providerConfigurator)
        {
            _providerConfigurator = providerConfigurator;
        }

        public async Task<List<Video.Model.Video>> GetVideos(string search)
        {
            var url = _providerConfigurator.GetApiUrl() + "?part=snippet&chart=mostPopular&key=AIzaSyA7riltTfgmnBGQvqApESGStVvEODTChh8";
            //_providerConfigurator.NoVideos

            var client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var ytStringResponse = await response.Content.ReadAsStringAsync();
                var ytResponse = JsonConvert.DeserializeObject<YtResponse>(ytStringResponse);

                var ytVideos = ytResponse.items.Select(n => new Video.Model.Video
                {
                    Id = n.id,
                    Title = n.snippet.title,
                    Description = n.snippet.description
                });

                return ytVideos.ToList();
            }

            return null;
        }
    }
}
