using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IMitarbeiter
    {
        string firstname { get; set; }
        string lastname { get; set; }
        int svn { get; }
        double salary { get; set; }
        double popularity { get; set; }


        string changefirstname();
        string changelastname();
        double promote(double salary);
        double popularity_rate(double value);
    }
}