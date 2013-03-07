using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using poc.webapi.Domain.Tasks;
using poc.webapi.Infrastructure;
using poc.webapi.Models;

namespace poc.webapi.Controllers
{
    public class TaskController : ApiController
    {
        private readonly ICommandChannel _commandChannel;
        private readonly IQueryHandler<TaskQuery, IEnumerable<Task>> _taskQueryHandler;

        public TaskController()
        {}

        public TaskController(ICommandChannel commandChannel, IQueryHandler<TaskQuery,IEnumerable<Task>> taskQueryHandler)
        {
            _commandChannel = commandChannel;
            _taskQueryHandler = taskQueryHandler;
        }

        // GET api/values
        public IEnumerable<Task> GetAllTasks()
        {
            //var result = _taskQueryHandler.Handle(new TaskQuery());
            //return result;
            return new Task[]
                {
                    new Task()
                        {
                            Id = 1,
                            Title = "Go to work"
                        }, 
                    new Task()
                        {
                            Id = 2,
                            Title = "Write Code"
                        }, 
                };
        }

        // GET api/values/5
        public Task GetTaskById(int id)
        {
            return new Task()
                {
                    Id = id,
                    Title = "Some task with id " + id
                };
            //var result = _taskQueryHandler.Handle(new TaskQuery()
            //    {
            //        TaskId = id
            //    });
            //if (!result.Any())
            //    return new Task();

            //return result.First();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            _commandChannel.Send(new CreateTaskCommand());
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            _commandChannel.Send(new UpdateTaskCommand());
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _commandChannel.Send(new DeleteTaskCommand());
        }
    }
}