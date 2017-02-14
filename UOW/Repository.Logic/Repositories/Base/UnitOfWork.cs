using System;
using System.Data.Entity;
using Repository.Model.SchoolContext;
using Repository.Repositories;

namespace Repository.Logic.Repositories.Base
{
    public class UnitOfWork : IDisposable
    {
        private SchoolContext context = new SchoolContext();
        private Repository<SchoolContext, Department> departmentRepository;
        private Repository<SchoolContext, Course> courseRepository;

        public Repository<SchoolContext, Department> DepartmentRepository
        {
            get
            {

                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new Repository<SchoolContext, Department>(context);
                }
                return departmentRepository;
            }
        }

        public Repository<SchoolContext,Course> CourseRepository
        {
            get
            {

                if (this.courseRepository == null)
                {
                    this.courseRepository = new Repository<SchoolContext, Course>(context);
                }
                return courseRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}