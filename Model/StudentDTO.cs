using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class StudentDTO:BaseDTO
    {
        public string PhoneNum { get; set; }
        public string stuId { get; set; }

        public long schoolId { get; set; }
        public string schoolName { get; set; }
       // public virtual School School { get; set; }
        //public long? teacherId { get; set; }
        //public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public long[] teacherIds { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
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
        public DateTime EnrollmentYear { get; set; }
    }
}
