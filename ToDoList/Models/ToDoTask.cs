using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int PriorityId { get; set; }
        public string PriorityName { get; set; }
        public string Tags { get; set; }
        public string Comment { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public bool IsDone { get; set; }
    }
}
