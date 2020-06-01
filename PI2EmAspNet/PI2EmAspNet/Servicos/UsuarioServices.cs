using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class UsuarioServices {
        private readonly AplicationContext _context;

        

        public async Task<ICollection<Usuario>> FindAllAsync() {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> FindByIdAsync(int id) {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Usuario u = await FindByIdAsync(id);
            if (u == null) {
                return false;
            }
            return true;
        }
    }
}
