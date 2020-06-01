using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class DesenvolvedoraServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<Desenvolvedora>> FindAllAsync() {
            return await _context.Desenvolvedoras.ToListAsync();
        }

        public async Task<Desenvolvedora> FindByIdAsync(int id) {
            return await _context.Desenvolvedoras.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Desenvolvedora d = await FindByIdAsync(id);
            if (d == null) {
                return false;
            }
            return true;
        }
    }
}
