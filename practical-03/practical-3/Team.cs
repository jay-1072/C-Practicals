using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Team : Sponsor
    {
        private string teamName;

        public string PrintInfo()
        {
            return owner + " Sponser";
        }
    }
}
