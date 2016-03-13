using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IMitarbeiter
    {
        string firstname { get; }
        string lastname { get; }
        int svn { get; }
        double salary { get; }
        double popularity { get; }

        void changefirstname();
        void changelastname();
        void promote(double salary);
        void popularity_rate(double value);
    }
}