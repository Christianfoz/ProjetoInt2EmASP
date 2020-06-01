using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    [Table("genero")]
    public class Genero {
        public int Id { get; set; }
        public String NomeGenero { get; set; }
        public Boolean Ativo { get; set; }
        public ICollection<JogoGenero> JogoGeneros { get; set; }
    }
}
