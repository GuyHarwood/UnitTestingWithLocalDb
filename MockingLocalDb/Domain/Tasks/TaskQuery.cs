using poc.webapi.Infrastructure;

namespace poc.webapi.Domain.Tasks
{
    public class TaskQuery : QueryBase
    {
        /// <summary>
        /// If greater than zero the result will be a single task, or null if the task does not exist.
        /// If zero, all tasks will be returned
        /// </summary>
        public int TaskId { get; set; }

        protected override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}