using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    public class TipoUsuario {
        public int Id { get; set; }
        public String NomeTipo { get; set; }
        public Boolean Ativo { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public TipoUsuario() {

        }

        public TipoUsuario(string nomeTipo, bool ativo) {
            NomeTipo = nomeTipo;
            Ativo = ativo;
        }

        public TipoUsuario(string nomeTipo) {
            NomeTipo = nomeTipo;
        }

        public TipoUsuario(int id, string nomeTipo, bool ativo) {
            Id = id;
            NomeTipo = nomeTipo;
            Ativo = ativo;
        }
    }
}
