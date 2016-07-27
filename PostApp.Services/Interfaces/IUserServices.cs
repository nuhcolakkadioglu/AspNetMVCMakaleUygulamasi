using PostApp.Core.Entities;
using PostApp.DTO.EEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Services.Interfaces
{
    public interface IUserServices
    {

        void Update(EUserDTO user);
        EUserDTO GetUserByUserNameAndPassword(string username,string password);
         byte[] GetUserImage(int id);

    }
}
