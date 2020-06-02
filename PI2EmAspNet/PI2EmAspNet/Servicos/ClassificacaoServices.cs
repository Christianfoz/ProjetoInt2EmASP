using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace PI2EmAspNet.Servicos {
    public class ClassificacaoServices {
        private readonly AplicationContext _context;

        public ClassificacaoServices(AplicationContext context) {
            _context = context;
        }

        public async Task CreateAsync(Classificacao classificacao) {
            await _context.Classificacoes.AddAsync(classificacao);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Classificacao>> FindAllAsync() {
            return await _context.Classificacoes.ToListAsync();
        }

        public async Task<Classificacao> FindByIdAsync(int id) {
            return await _context.Classificacoes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Classificacao c = await FindByIdAsync(id);
            if(c == null) {
                return false;
            }
            return true;
        }
    }
}
