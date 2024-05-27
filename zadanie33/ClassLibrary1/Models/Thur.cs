using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    [Table(Name="Тур")]
    public class Thur
    {
        [Column(Name ="Код_тура", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name ="Название")]
        public string Name { get; set; }
        [Column(Name ="Цена")]
        public double Price { get; set; }
        [Column(Name ="Информация")]
        public string Description { get; set; }
    }
}
