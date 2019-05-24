using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class TeacherDTO
    {
        public string UserName { get; set; }
        public string PhoneNum { get; set; }
        public string EmailAdress { get; set; }
        //public virtual ICollection<Student> students { get; set; } = new List<Student>();
        public long[] StudentIds { get; set; }
        public long SchoolId { get; set; }
        public  string schoolName { get; set; }
        //public virtual School school { get; set; }
        public string password { get; set; }
        public string passwordSalty { get; set; } = new Random().Next(1000, 9999).ToString();
        public int Age { get; set; }
        public bool Gender { get; set; } = true;
        public DateTime firstLoginTime { get; set; } = DateTime.Now;
        public DateTime lastloginTime { get; set; } = DateTime.Now;
        public DateTime? BirthDateTime { get; set; }
        public string lastLoginIp { get; set; }
        public string IDnumber { get; set; }
        public string departments { get; set; }
        public string major { get; set; }
        public string Adress { get; set; }
    }
}
