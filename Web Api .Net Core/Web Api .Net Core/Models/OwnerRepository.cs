using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_.Net_Core.Models
{
    public class UserRepository : IUser
    {
        DataRepo _repo = new DataRepo();
        public void Add(UserModel entity)
        {
            entity.id = Guid.NewGuid().ToString();
            _repo.Insert(entity);
        }
        public List<UserModel> GetAll()
        {
            var record = _repo.getData();
            return record;
        }
        public string Find(string id)
        {
            string record = _repo.findId(id);
            return record;
        }
    }
}
