using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    [Table("ExampleTbl")]
    public class ExampleModel
    {
        public string Id { get; set; }
        public string String { get; set; }
        public int Number { get; set; }
        public bool Boolean { get; set; }
        public DateTime Date { get; set; }
    }
}
