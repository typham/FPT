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
    public interface IRoleService
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);
        Role GetSingle(Expression<Func<Role, bool>> expression);
        Role Add(Role entity);
        void Update(Role entity);
        void Delete(int id);

        void Save();
    }
    public class RoleService : IRoleService
    {
        private IRoleRepository _roleRepository;
        private IUnitOfWork _uow;

        public RoleService(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            this._roleRepository = roleRepository;
            this._uow = unitOfWork;
        }
        public Role Add(Role entity)
        {
            return _roleRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public void Update(Role entity)
        {
            _roleRepository.Update(entity);
        }

        public void Save()
        {
            _roleRepository.Save();
        }

        public Role GetSingle(Expression<Func<Role, bool>> expression)
        {
            return _roleRepository.GetSingle(expression);
        }
    }
}
