using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class TeacherBLL
    {
        public bool AddNewStudent(long Teacherid, StudentDTO stu)
        {
            TeacherDAL teacherdal = new TeacherDAL();
          return  teacherdal.AddNewStudent(stu, Teacherid);
        }
        public StudentDTO[] GetStudentDTOs(long teacherId)
        {
            TeacherDAL teacherdal = new TeacherDAL();
            return teacherdal.getStudentByID(teacherId);
        }
    }
}
