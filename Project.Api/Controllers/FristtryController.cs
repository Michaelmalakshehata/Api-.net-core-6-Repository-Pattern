using Microsoft.AspNetCore.Mvc;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Core.ResponseViewModel;
using Project.Core.ViewModels;
using Project.EF.Services;
using Project.EF.Services_Interface;

namespace Project.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class FristtryController : ControllerBase
    {
        private readonly Iserviceinterface _service;
        public FristtryController(Iserviceinterface service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ResponseModel<Student>> add(StudentViewModel data)
        {
            try
            {
                var result = await _service.add(data);
                if (result == null)
                {
                    return new ResponseModel<Student>(null, false, "name exist");
                }
                return new ResponseModel<Student>(result, true, "add successfully");

            }
            catch
            {
                return new ResponseModel<Student>(null, false, "add failled wrong data");
            }
        }
        [HttpGet]
        public async Task<ResponseModel<List<Student>>> Getall()
        {
            try
            {
                var result = await _service.Getall();
                return new ResponseModel<List<Student>>(result, true, "get successfully");
            }
            catch
            {
                return new ResponseModel<List<Student>>(null, false, "get failled");
            }
        }
        [HttpGet("id")]
        public async Task<ResponseModel<Student>> GetByid(int id)
        {
            try
            {
                var result = await _service.GetByid(id);
                return new ResponseModel<Student>(result, true, "get successfully");
            }
            catch
            {
                return new ResponseModel<Student>(null, false, "get failled");
            }
        }
        [HttpDelete("id")]
        public async Task<ResponseModel<int>> Delete(int id)
        {
            try
            {
                var result = await _service.Delete(id);
                return new ResponseModel<int>(result, true, "delete successfully");
            }
            catch
            {
                return new ResponseModel<int>(0, false, "delete failled not found  id");
            }
        }
        [HttpPut("id")]
        public async Task<ResponseModel<Student>> Update(StudentViewModelUpdate data)
        {
            try
            {
                var result = await _service.Update(data);

                if (result == null)
                {
                    return new ResponseModel<Student>(null, false, "name exist");
                }
                return new ResponseModel<Student>(result, true, "updated successfully");
            }
            catch
            {
                return new ResponseModel<Student>(null, false, "updated failled wrong data");
            }
        }
        [HttpGet]
        public async Task<ResponseModel<List<Student>>> Find(string name)
        {
            try
            {
                var result = await _service.Find(name);
                if (result.Count == 0)
                {
                    return new ResponseModel<List<Student>>(null, false, "get failed no data");
                }
                return new ResponseModel<List<Student>>(result, true, "get successfully");
            }
            catch
            {
                return new ResponseModel<List<Student>>(null, false, "get failled wrong data");
            }
        }






        [HttpGet("id")]
        public async Task<ResponseModel<Student>> get(int id)
        {
            try
            {
                var result = await _service.get(id);
               
                return new ResponseModel<Student>(result, true, "get successfully");

            }
            catch
            {
                return new ResponseModel<Student>(null, false, "get failed");
            }
        }
    }
}
