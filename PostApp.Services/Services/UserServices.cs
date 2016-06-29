using PostApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostApp.Core.Entities;
using PostApp.Data.GenericRepository;
using PostApp.Data.UnitofWork;
using AutoMapper;
using PostApp.DTO.EEntity;

namespace PostApp.Services.Services
{
    public class UserServices : IUserServices
    {
        //Install-Package AutoMapper

        private readonly IGenericRepository<User> _userRepository;
        private readonly IUnitofWork _uow;
        
        public UserServices(UnitofWork uow)
        {
            _uow = uow;
            _userRepository = _uow.GetRepository<User>();
        }

        public void GetUserByUserNameAndPassword(string username, string password)
        {
            var control = _userRepository.GetAll().Where(m => m.UserName == username && m.Password == password).SingleOrDefault();

        }

        public void Update(EUserDTO user)
        {
            var entity = _userRepository.Find(user.Id);
            Mapper.Map(user, entity);
            _userRepository.Update(entity);
        }
    }
}
