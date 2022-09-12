using Project.Core.Models;
using Project.Core.ResponseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface IGenericRepository<T>where T : BaseClass
    {
      Task<List<T>> Getall();
        Task<T> GetById(int id);
        Task<T> add<T>(T data);
        Task<T> update<T>(T data);
        Task<int>  delete(int id);
        Task<List<T>> Find(Expression<Func<T, bool>> match);
    }
}
