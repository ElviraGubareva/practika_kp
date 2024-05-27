using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    internal class ThurDBContext : DataContext
    {
        public ThurDBContext(string conn) : base(conn)
        {
        }
        public Table<Thur> Tourists { get; set; }
    }
}
