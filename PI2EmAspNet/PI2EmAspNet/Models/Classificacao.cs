using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    [Table("classificacao")]
    public class Classificacao {
        public int Id { get; set; }
        public String NomeClassificacao { get; set; }
        public List<Jogo> Jogos { get; set; }
        public Boolean Ativo { get; set; }


    }
}
