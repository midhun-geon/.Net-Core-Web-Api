using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_.Net_Core.Models
{
    public class DataRepo
    {
        public List<UserModel> UserDataList = new List<UserModel>();
        public void Insert(UserModel entity)
        {
            UserDataList.Add(entity);
        }
    }
}
