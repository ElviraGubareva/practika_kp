using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Table(Name = "Турист")]
    public class Tourist
    {
        [Column(Name = "Код_туриста", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Имя")]
        public string Name { get; set; }
        [Column(Name = "Фамилия")]
        public double Surname { get; set; }
        [Column(Name = "Отчество")]
        public string SecondName { get; set; }
    }
}
