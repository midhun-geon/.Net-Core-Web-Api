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
        public List<UserModel> getData()
        {
            var dat = UserDataList;
            return dat;
        }
        public string findId(string id)
        {
            string name  = (from cust in UserDataList
                       where cust.id == id
                       select cust.FirstName).ToString();
            return name;
        }
    }
}
