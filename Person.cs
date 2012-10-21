using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleObjectSaving
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PictureURL { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }
    }
}
