using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ClassAverage
    {
        public ClassAverage()
        {

        }

        public double GetClassAverage(List<string> classGrades)
        {
            var listOfClassGrades = classGrades.Select(grade => grade.Split(',').Select(double.Parse).Where(drop => drop > grade.Split(',').Select(newGrade => double.Parse(newGrade)).Min()).Average()).Average();
            return listOfClassGrades;
        }
    }
}
