using DTOModel;
using DTOModel.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class StudentDAL
    {
        public List<StudentDTO> getStudentBySchoolId(long schoolId)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                BaseDAL<Student> bs = new BaseDAL<Student>(ctx);
                var persons = bs.getAll().Include(s => s.Teachers).Where(s => s.schoolId == schoolId);
                List<StudentDTO> students = new List<StudentDTO>();
                foreach (var person in persons)
                {
                    StudentDTO studentdto = getDTO(person);
                    students.Add(studentdto);
                    //studentdto.teacherId = person.Teachers.;
                    //studentdto.schoolId = person.schoolId;
                }
                return students;
                
            }
        }
        public StudentDTO getDTO(Student students)
        {
           // foreach (var person in persons)
           // {
                StudentDTO studentdto = new StudentDTO();
                studentdto.Id = students.Id;
                studentdto.Adress = students.Adress;
                studentdto.Age = students.Age;
                studentdto.BirthDateTime = students.BirthDateTime;
                studentdto.departments = students.departments;
                studentdto.EmailAdress = students.EmailAdress;
                studentdto.EnrollmentYear = students.EnrollmentYear;
                studentdto.firstLoginTime = students.firstLoginTime;
                studentdto.Gender = students.Gender;
                studentdto.IDnumber = students.IDnumber;
                studentdto.lastLoginIp = students.lastLoginIp;
                studentdto.lastloginTime = students.lastloginTime;
                studentdto.major = students.major;
                studentdto.Password = students.Password;
                studentdto.passwordSalty = students.passwordSalty;
                studentdto.PhoneNum = students.PhoneNum;
                studentdto.schoolId = students.schoolId;
                studentdto.stuId = students.stuId;
            studentdto.schoolName = students.School.Name;
            studentdto.teacherIds = students.Teachers.Select(t => t.Id).ToArray();
            //studentdto.teacherId = person.Teachers.;
            //studentdto.schoolId = person.schoolId;
            return studentdto;
            //}
        }
    }
}
