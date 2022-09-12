using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.Services_Interface
{
    public interface Iserviceinterface
    {
        Task<Student> add(StudentViewModel data);
        Task<List<Student>> Getall();
        Task<Student> GetByid(int id);
        Task<int> Delete(int id);
        Task<Student> Update(StudentViewModelUpdate data);
        Task<List<Student>> Find(string name);
        Task<Student> get(int id);
    }
}
