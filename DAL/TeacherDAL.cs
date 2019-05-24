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
    public class TeacherDAL
    {
        public StudentDTO[] getStudentByID(long teacherId)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                BaseDAL<Teacher> bs = new BaseDAL<Teacher>(ctx);
                var entities = bs.getAll().Include(e => e.students)
                    .Include(e => e.school).Where(e => e.Id == teacherId)
                    .SingleOrDefault().students;
                List<StudentDTO> list = new List<StudentDTO>();
                foreach (Student s in entities)
                {
                    StudentDTO sto = new StudentDTO();
                    sto.Adress = s.Adress;
                    sto.Age = s.Age;
                    sto.BirthDateTime = s.BirthDateTime;
                    sto.departments = s.departments;
                    sto.EmailAdress = s.EmailAdress;
                    sto.EnrollmentYear = s.EnrollmentYear;
                    sto.firstLoginTime = s.firstLoginTime;
                    sto.Gender = s.Gender;
                    sto.Id = s.Id;
                    sto.IDnumber = s.IDnumber;
                    sto.is_delete = s.is_delete;
                    sto.lastLoginIp = s.lastLoginIp;
                    sto.lastloginTime = s.lastloginTime;
                    sto.major = s.major;
                    sto.Name = s.Name;
                    sto.Password = s.Password;
                    sto.passwordSalty = s.passwordSalty;
                    sto.PhoneNum = s.PhoneNum;
                    sto.schoolId = s.schoolId;
                    sto.schoolName = s.School.Name;
                    sto.stuId = s.stuId;
                    sto.teacherIds = s.Teachers.Select(t => t.Id).ToArray();
                    list.Add(sto);
                }
                return list.ToArray();
            }
        }
        public bool AddNewStudent(StudentDTO sto, long teacherId)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                var entity = ctx.Teachers.Where(e => e.Id == teacherId).SingleOrDefault();
               var entitystu= ctx.Students.Select(e => e.stuId == sto.stuId);
                if (entitystu != null)
                {
                    return false;
                }
                Student stu = new Student();
                stu.Adress = sto.Adress;
                stu.Age = sto.Age;
                stu.BirthDateTime = sto.BirthDateTime;
                stu.departments = sto.departments;
                stu.EmailAdress = sto.EmailAdress;
                stu.EnrollmentYear = sto.EnrollmentYear;
                stu.firstLoginTime = sto.firstLoginTime;
                stu.Gender = sto.Gender;
                stu.IDnumber = sto.IDnumber;
                stu.lastLoginIp = sto.lastLoginIp;
                stu.major = sto.major;
                stu.Name = sto.Name;
                stu.Password = sto.Password;
                stu.PhoneNum = sto.PhoneNum;
                stu.schoolId = sto.schoolId;
                stu.stuId = sto.stuId;
                if (entity != null)
                {
                    stu.Teachers.Add(entity);
                }
                ctx.Students.Add(stu);
                ctx.Entry<Student>(stu).State = EntityState.Added;
                return true;
                //ctx.Students
            }
        }

    }
}
