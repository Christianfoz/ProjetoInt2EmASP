using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    [Table("plataforma")]
    public class Plataforma {
        public int Id { get; set; }
        public String NomePlataforma { get; set; }
        public Boolean Ativo { get; set; }
        public List<Jogo> Jogos { get; set; }
        public ICollection<JogoPlataforma> JogoPlataformas { get; set; }

    }
}
