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
    public interface IPermissionService
    {
        IEnumerable<Permission> GetAll();
        Permission GetById(int id);
        Permission GetSingle(Expression<Func<Permission, bool>> expression);
        Permission Add(Permission entity);
        void Update(Permission entity);
        void Delete(int id);

        void Save();
    }
    public class PermissionService : IPermissionService
    {
        private IPermissionRepository _permissionRepository;
        private IUnitOfWork _uow;

        public PermissionService(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
        {
            this._permissionRepository = permissionRepository;
            this._uow = unitOfWork;
        }

        public Permission Add(Permission entity)
        {
            return _permissionRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }

        public IEnumerable<Permission> GetAll()
        {
            return _permissionRepository.GetAll();
        }

        public Permission GetById(int id)
        {
            return _permissionRepository.GetById(id);
        }

        public void Update(Permission entity)
        {
            _permissionRepository.Update(entity);
        }

        public void Save()
        {
            _permissionRepository.Save();
        }

        public Permission GetSingle(Expression<Func<Permission, bool>> expression)
        {
            return _permissionRepository.GetSingle(expression);
        }
    }
}
