using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    public class JogoGenero {
        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
