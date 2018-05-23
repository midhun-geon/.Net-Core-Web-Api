using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_.Net_Core.Models
{
    public class OwnerRepository : IUser
    {
        private readonly DataRepo _repo;
        public void Add(UserModel entity)
        {
            _repo.Insert(entity);
        }
    }
}
