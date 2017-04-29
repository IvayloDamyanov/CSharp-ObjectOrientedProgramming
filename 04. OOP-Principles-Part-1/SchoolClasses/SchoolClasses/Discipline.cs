using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Discipline
    {
        string _name;
        int _numberOfLectures;
        int _numbersOfExercises;
        string _optionalComments;

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string optionalComments = null)
        {
            this._name = name;
            this._numberOfLectures = numberOfLectures;
            this._numbersOfExercises = numberOfExercises;
            this._optionalComments = optionalComments;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return _numberOfLectures;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return _numbersOfExercises;
            }
        }
        public string OptionalComments
        {
            get
            {
                return _optionalComments;
            }
        }
    }
}
