using FPT.Data.Infrastructure;
using FPT.Data.Repositories;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User GetSingle(Expression<Func<User, bool>> expression);
        User Add(User entity);
        void Update(User entity);
        void Delete(int id);

        void Save();
    }
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IUnitOfWork _uow;

        public UserService(IUserRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._userRepository = productRepository;
            this._uow = unitOfWork;
        }

        public User Add(User entity)
        {
            return _userRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

        public void Save()
        {
            _userRepository.Save();
        }

        public User GetSingle(Expression<Func<User, bool>> expression)
        {
            return _userRepository.GetSingle(expression);
        }
    }
}
