using Microsoft.EntityFrameworkCore;
using Sample.Data;
using Sample.Repository;
using Sample.Repository.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Services
{
    public class StudentService : IDisposable
    {
        public void Dispose()
        {
            this.Dispose();
        }

        public async Task<List<SepsdChangedStudent>> GetChangedStudents()
        {
            List<SepsdChangedStudent> studentChangeds = null;
            try
            {
                using (var Student = new ModelContext())
                {
                    studentChangeds = await Student.SepsdChangedStudent.ToListAsync();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return studentChangeds;
        }

        public async Task<List<SepsdStudent>> LoadStudent(SepsdChangedStudent sepsdChangedStudent)
        {
            List<SepsdStudent> students = null;
            try
            {
                using (var Student = new ModelContext())
                {
                    students = await Student.SepsdStudent.ToListAsync();
                    students = students.FindAll(x => x.Srn == 447571773);
                    //sepsdChangedStudent.StudentRecordNo
                }
            }
            catch(Exception ex)
            {

            }
            return students;
        }
    }
}
