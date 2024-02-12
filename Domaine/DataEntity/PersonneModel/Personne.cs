using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.DataEntity.PersonneModel
{
    public class Personne
    {
        public Guid Id { get; set; } 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

    }
}
