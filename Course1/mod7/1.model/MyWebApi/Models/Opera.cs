using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Models
{
    public class Opera
    {
        public int OperaID { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Composer { get; set; }
    }
}
