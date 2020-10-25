using Onion.Abstract.Dto;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Onion.Abstract
{
    public interface IVideoService
    {
        IEnumerable<VideoResultDto> GetVideos(string phrase);
        void Add(string videoId, string title);
    }
}
