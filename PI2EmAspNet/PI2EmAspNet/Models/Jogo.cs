using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    [Table("jogo")]
    public class Jogo {
        public int Id { get; set; }
        public Classificacao Classificacao { get; set; }
        public Desenvolvedora Desenvolvedora { get; set; }
        public Diretor Diretor { get; set; }
        public ModoJogo ModoJogo { get;  set; }
        public ICollection<JogoGenero> JogoGeneros { get; set; }
        public ICollection<JogoPlataforma> JogoPlataformas { get; set; }
    }
}
