using System;
using System.Collections.Generic;

namespace WebApp.UI.Data.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public List<Student> Students { get; set; }

    }
}