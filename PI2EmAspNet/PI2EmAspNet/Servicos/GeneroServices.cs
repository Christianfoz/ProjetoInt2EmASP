using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class GeneroServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<Genero>> FindAllAsync() {
            return await _context.Generos.ToListAsync();
        }

        public async Task<Genero> FindByIdAsync(int id) {
            return await _context.Generos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Genero g = await FindByIdAsync(id);
            if (g == null) {
                return false;
            }
            return true;
        }
    }
}

