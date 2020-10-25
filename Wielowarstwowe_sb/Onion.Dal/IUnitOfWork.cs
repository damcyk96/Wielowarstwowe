using Onion.Dal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Dal
{
    public interface IUnitOfWork
    {
        IRepository<Video> VideoRepository { get; }
        void Save();
    }
}
