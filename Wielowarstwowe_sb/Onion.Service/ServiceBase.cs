using Onion.Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Service
{
    public class ServiceBase
    {
        protected IUnitOfWork _unitOfWork;

        public ServiceBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
