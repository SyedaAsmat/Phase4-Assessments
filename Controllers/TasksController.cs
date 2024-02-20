using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebApiTasks.Models;

namespace WebApiTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private static List<Tasks> taskList = new List<Tasks>()
        {
            new() { Id = 1, Title="HTML", Description="Create a Form with client-side authentication", CompleteBy=new DateTime(day:15,month:6,year:2024,hour:12,minute:00,second:00)},
            new() { Id = 2, Title="Python", Description="Create a Chatbot using ML/AI", CompleteBy=new DateTime(day:1,month:9,year:2024,hour:12,minute:00,second:00)},
            new() { Id = 3, Title="Java", Description="Create any game application", CompleteBy=new DateTime(day:20,month:5,year:2024,hour:12,minute:00,second:00)},
            new() { Id = 4, Title="DS", Description="Complete till Dynamic Programming", CompleteBy=new DateTime(day:30,month:4,year:2024,hour:12,minute:00,second:00)},
            new() { Id = 5, Title="MySQL", Description="Create and perform all operations on any database table", CompleteBy=new DateTime(day:9,month:3,year:2024,hour:12,minute:00,second:00)}
        };
        [HttpGet(Name = "GetTask")]
        public IEnumerable<Tasks> Get()
        {
            return taskList;
        }
        [HttpGet("{id}")]
        public ActionResult<Tasks> Get(int id)
        {
            Tasks tasks = taskList.SingleOrDefault(x => x.Id == id);
            if (tasks == null)
                return NotFound();
            else
                return Ok(tasks);
        }
        [HttpDelete("{id}")]
        public ActionResult<Tasks>? Delete(int id)
        {
            Tasks task = taskList.SingleOrDefault(x => x.Id == id);
            if (task == null)
                return NotFound();
            else
            {
                taskList.Remove(task);
                return NoContent();
            }
        }
        [HttpPost]
        public ActionResult<Tasks> Post(Tasks newTask)
        {
            taskList.Add(newTask);
            return CreatedAtAction(nameof(Get), newTask);
        }

        [HttpPut("{id}")]
        public ActionResult<Tasks> Put(int id, Tasks upTask)
        {
            Tasks modTask = taskList.SingleOrDefault(x => x.Id == id);
            if (modTask == null)
            {
                return NotFound();
            }
            else
            {
                modTask.Title = upTask.Title;
                modTask.Description = upTask.Description;
                modTask.CompleteBy = upTask.CompleteBy;
                return NoContent();
            }
        }
    }
}