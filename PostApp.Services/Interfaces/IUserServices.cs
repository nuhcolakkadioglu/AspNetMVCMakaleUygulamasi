using PostApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Services.Interfaces
{
    public interface IUserServices
    {

        void Update(User user);
        void GetUserByUserNameAndPassword(string username,string password);
    }
}
