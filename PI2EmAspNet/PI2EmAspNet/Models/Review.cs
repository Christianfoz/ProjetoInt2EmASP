using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI2EmAspNet.Models {
    public class Review {
        public int Id { get; set; }
        public Usuario Usuario { get; internal set; }
    }
}
