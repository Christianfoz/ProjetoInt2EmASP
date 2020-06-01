using Microsoft.EntityFrameworkCore;
using PI2EmAspNet.Data;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Servicos {
    public class ReviewServices {
        private readonly AplicationContext _context;

        public async Task<ICollection<Review>> FindAllAsync() {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> FindByIdAsync(int id) {
            return await _context.Reviews.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Boolean> ExistsAsync(int id) {
            Review r = await FindByIdAsync(id);
            if (r == null) {
                return false;
            }
            return true;
        }
    }
}
