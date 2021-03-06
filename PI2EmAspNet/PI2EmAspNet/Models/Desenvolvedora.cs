﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    [Table("desenvolvedora")]
    public class Desenvolvedora {
        public int Id { get; set; }
        public String NomeDesenvolvedora { get; set; }
        public Boolean Ativo { get; set; }
        public List<Jogo> Jogos { get; set; }
    }
}
