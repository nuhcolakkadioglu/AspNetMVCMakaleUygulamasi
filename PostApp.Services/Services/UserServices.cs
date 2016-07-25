using PostApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostApp.Core.Entities;
using PostApp.Data.GenericRepository;
using PostApp.Data.UnitofWork;
using PostApp.DTO.EEntity;

namespace PostApp.Services.Services
{
    public class UserServices : IUserServices
    {
        //Install-Package AutoMapper

        private readonly IGenericRepository<User> _userRepository;
        private readonly IUnitofWork _uow;
        private readonly EUserDTO _userDTO;

        public UserServices(UnitofWork uow)
        {
            _uow = uow;
            _userRepository = _uow.GetRepository<User>();
            _userDTO = new EUserDTO();
        }

        public EUserDTO GetUserByUserNameAndPassword(string username, string password)
        {
            var control = _userRepository.GetAll().Where(m => m.UserName == username && m.Password == password).SingleOrDefault();
            AutoMapper.Mapper.DynamicMap(control,_userDTO);

            return _userDTO;
        }

        public void Update(EUserDTO user)
        {
            var entity = _userRepository.Find(user.Id);
            AutoMapper.Mapper.DynamicMap(user, entity);
            _userRepository.Update(entity);
        }
    }
}
