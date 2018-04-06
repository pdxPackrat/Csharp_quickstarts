using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker 
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public abstract IEnumerator GetEnumerator();


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

                if (string.IsNullOrEmpty(value)) // module is showing example of how to throw an exception as needed
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value; // value is an automatic parameter passed in as part of the set and this code prevents null assignment

            }
        }

        public event NameChangedDelegate NameChanged;  // from NameChangedDelegate.cs

        protected string _name; // changing to protected to allow derived classes to access
        
    }
}
