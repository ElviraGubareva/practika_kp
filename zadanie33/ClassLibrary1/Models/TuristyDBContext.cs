using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace ClassLibrary1.Models
{
    internal class TuristyDBContext : DataContext
    {
        public TuristyDBContext(string conn) : base(conn)
        { 
        }
        public Table<Tourist> Tourists { get; set; }
    }
}
