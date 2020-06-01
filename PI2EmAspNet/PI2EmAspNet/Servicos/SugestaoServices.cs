using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class SugestaoServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<Sugestao>> FindAllAsync() {
            return await _context.Sugestoes.ToListAsync();
        }

        public async Task<Sugestao> FindByIdAsync(int id) {
            return await _context.Sugestoes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Sugestao s = await FindByIdAsync(id);
            if (s == null) {
                return false;
            }
            return true;
        }
    }
}
