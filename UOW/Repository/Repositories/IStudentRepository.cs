using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Repository.Model.SchoolContext;

namespace Repository.Repositories
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(int studentId);
        void InsertStudent(Student student);
        void DeleteStudent(int studentID);
        void UpdateStudent(Student student);
        void Save();
        IQueryable<Student> FindBy(Expression<Func<Student, bool>> predicate);
    }
}