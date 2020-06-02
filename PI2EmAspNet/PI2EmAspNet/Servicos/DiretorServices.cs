using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class DiretorServices {
        private readonly AplicationContext _context;

        public async Task CreateAsync(Diretor diretor) {
            await _context.Diretores.AddAsync(diretor);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Diretor>> FindAllAsync() {
            return await _context.Diretores.ToListAsync();
        }

        public async Task<Diretor> FindByIdAsync(int id) {
            return await _context.Diretores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Diretor d = await FindByIdAsync(id);
            if (d == null) {
                return false;
            }
            return true;
        }
    }
}
