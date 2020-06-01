using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    public class JogoPlataforma {
        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }
        public int PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }
    }
}
