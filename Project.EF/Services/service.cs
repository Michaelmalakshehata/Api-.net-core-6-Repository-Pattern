using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.ViewModels;
using Project.EF.Services_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.Services
{
    public class service:Iserviceinterface
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly EntityContext _Context;
        public  service(EntityContext context, IGenericRepository<Student> repository)
        {
            _Context = context;
            _repository = repository;
        }

        public async Task<Student> add(StudentViewModel data)
        {
            Student obj = new Student();
            obj.Name = data.Name;
            obj.ClassName = data.ClassName;


            var find = await _repository.Find(b => b.Name == obj.Name);
            if (find.Count == 0)
            {
                Student d = await _repository.add(obj);
                return d;

            }
            return null;
        }
        public async Task<List<Student>> Getall()
        {
            var d = await _repository.Getall();
            return d;
        }
        public async Task<Student> GetByid(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task<int> Delete(int id)
        {
            int d = await _repository.delete(id);
            return id;
        }
        public async Task<Student> Update(StudentViewModelUpdate data)
        {
            Student std = new Student();
            std.Id = data.id;
            std.Name = data.Name;
            std.ClassName = data.ClassName;
            var find = await _repository.Find(b => b.Name == std.Name);
            if (find.Count == 0)
            {
                Student d = await _repository.update(std);
                return d;

            }
            return null;

        }
        public async Task<List<Student>> Find(string name)
        {
            var d = await _repository.Find(b => b.ClassName == name);
            return d;
        }
        public async Task<Student>get(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }

            if (await _Context.Students.FindAsync(id) == null)
            {
                throw new ArgumentNullException();

            }
            return await _Context.Students.FindAsync(id);

        }
    }
}
