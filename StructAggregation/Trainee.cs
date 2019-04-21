using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAggregation
{
    struct Trainee
    {
        string traineeName;
        string traineeSurname;
        public string TraineeName(string n, string s)
            {
                traineeName = n;
                traineeSurname = s;
                return traineeName + " " + traineeSurname;
            }
        public string email;
        public string gitHub;
    }
}
