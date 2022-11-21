using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao.model
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public Animal Animal { get; set; }

    }
}
