using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    [Table("diretor")]
    public class Diretor {
        public int Id { get; set; }
        public String NomeDiretor { get; set; }
        public Boolean Ativo { get; set; }
        public List<Jogo> Jogos { get; set; }
    }
}
