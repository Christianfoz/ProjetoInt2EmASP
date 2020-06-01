using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class TipoUsuarioServices {
        private readonly AplicationContext _context;

        public TipoUsuarioServices(AplicationContext context) {
            _context = context;
        }

        public async Task CreateAsync(TipoUsuario tu) {
            tu.Ativo = true;
            await _context.TipoUsuarios.AddAsync(tu);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TipoUsuario>> FindAllAsync() {
            return await _context.TipoUsuarios.ToListAsync();
        }

        public async Task<TipoUsuario> FindByIdAsync(int id) {
            return await _context.TipoUsuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            TipoUsuario tu = await FindByIdAsync(id);
            if (tu == null) {
                return false;
            }
            return true;
        }
    }
}
