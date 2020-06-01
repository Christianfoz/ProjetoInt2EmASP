using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    public class Usuario {
        public int Id { get;  set; }
        public String Apelido { get; set; }
        public String Email { get; set; }
        public TipoUsuario TipoUsuario {
            get => this.TipoUsuario;
            set => this.TipoUsuario = new TipoUsuario(1, "Usuario", true);
            }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Sugestao> Sugestoes { get;  set; }
    }
    }

