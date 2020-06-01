using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class ModoJogoServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<ModoJogo>> FindAllAsync() {
            return await _context.ModoJogos.ToListAsync();
        }

        public async Task<ModoJogo> FindByIdAsync(int id) {
            return await _context.ModoJogos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            ModoJogo mj = await FindByIdAsync(id);
            if (mj == null) {
                return false;
            }
            return true;
        }
    }
}

