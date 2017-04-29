using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    static class CalculateExtensionMethod
    {
        public static double AverageAge(this IEnumerable<Animal> collection)
        {
            double averageAge = collection.Average(x => x.Age);
            return averageAge;
        }
    }
}
