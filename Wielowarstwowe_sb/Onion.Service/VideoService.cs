using Onion.Abstract;
using Onion.Abstract.Dto;
using Onion.Dal;
using Onion.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Service
{
    public class VideoService : ServiceBase, IVideoService
    {
        public VideoService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public void Add(string videoId, string title)
        {
            _unitOfWork.VideoRepository.Create(new Video
            {
                Title = title,
                VideoId = videoId
            });
            _unitOfWork.Save();
        }
        public IEnumerable<VideoResultDto> GetVideos(string phrase)
        {
            return _unitOfWork.VideoRepository.GetAll().Where(n => n.Title.Contains(phrase, StringComparison.CurrentCultureIgnoreCase)).Select(n => new VideoResultDto
            {
                Title = n.Title,
                VideoId = n.VideoId
            }).ToList();
        }
    }
}
