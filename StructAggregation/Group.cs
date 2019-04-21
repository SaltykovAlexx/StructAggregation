using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAggregation
{
    struct Group
    {
        Trainee train;
        public string groupName;
        public Group(string g, Trainee tFN)
        {
            groupName = g;
            this.train = tFN;
        }
    }
}
