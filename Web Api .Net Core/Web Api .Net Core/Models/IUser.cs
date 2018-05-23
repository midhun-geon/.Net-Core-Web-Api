using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_.Net_Core.Models
{
    public interface IUser
    {
        void Add(UserModel entity);
    }
}
