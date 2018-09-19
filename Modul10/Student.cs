using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10
{
    public class Student : IStudent
    {
        public string Name { get ; set ; }
        public string FullName { get ; set ; }
        public int[] Grades { get ; set ; }

        public double GetAvgGrade()
        {
            int countGrades = Grades.Length;
            double sum = 0;
            foreach (var item in Grades)
            {
                sum += item;
            }

            return sum / countGrades;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
