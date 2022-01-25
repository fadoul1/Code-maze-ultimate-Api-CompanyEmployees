using Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace companyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _repository.Company.GetAllCompanies(false);
            _repository.Employee.GetType();

            return new string[] { "value1", "value2" };
        }
    }
}
