using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMedsoft.Interfaces;
using Dapper;

namespace TMedsoft.Data.Entities
{
    [Table("ref_Genres")]
    public class Genre : IHasID<Int64>, IHasName
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }
    }
}