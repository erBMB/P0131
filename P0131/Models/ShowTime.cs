using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P0131
{
    public class ShowTime
    {
       
        public ShowTime()
        {

        }
        public DateTime GetCurrentTime()
        {
            DateTime dt = DateTime.Now.ToLocalTime();
            return dt;
        }

        
    }
}
