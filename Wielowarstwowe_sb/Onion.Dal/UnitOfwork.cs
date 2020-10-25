using Onion.Dal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Dal
{
    public class UnitOfwork : IUnitOfWork, IDisposable
    {
        private IRepository<Video> _videoRepository;
        private VideoContext _videoContext;
        public UnitOfwork(VideoContext videoContext)
        {
            _videoContext = videoContext;
        }
        public IRepository<Video> VideoRepository =>
            _videoRepository ?? (_videoRepository = new Repository<Video>(_videoContext));

        public void Dispose()
        {
            _videoContext.Dispose();
        }

        public void Save()
        {
            _videoContext.SaveChanges();
        }
    }
}
