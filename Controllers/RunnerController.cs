using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trails.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();
            var runner = new Runner();
            runner.Id = 1;
            runner.Age = 14;
            runner.First = "Connor";
            runner.Last = "Dortbudak";

            runners.Add(runner);

            runner = new Runner();
            runner.Id = 2;
            runner.Age = 47;
            runner.First = "Alper";
            runner.Last = "Dortbudak";

            runners.Add(runner);
            

            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
