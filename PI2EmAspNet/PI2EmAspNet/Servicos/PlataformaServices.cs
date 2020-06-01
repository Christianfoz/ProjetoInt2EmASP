using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class PlataformaServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<Plataforma>> FindAllAsync() {
            return await _context.Plataformas.ToListAsync();
        }

        public async Task<Plataforma> FindByIdAsync(int id) {
            return await _context.Plataformas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Plataforma p = await FindByIdAsync(id);
            if (p == null) {
                return false;
            }
            return true;
        }
    }
}

