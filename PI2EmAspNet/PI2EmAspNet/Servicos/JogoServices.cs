using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class JogoServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<Jogo>> FindAllAsync() {
            return await _context.Jogos.ToListAsync();
        }

        public async Task<Jogo> FindByIdAsync(int id) {
            return await _context.Jogos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Jogo j = await FindByIdAsync(id);
            if (j == null) {
                return false;
            }
            return true;
        }
    }
}

