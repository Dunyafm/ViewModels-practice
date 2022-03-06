using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewsModels.Models;

namespace ViewModels.ViewModels
{
    public class HomeViewModel
    {
        public List<Student> Students { get; set; }
        public Product Product { get; set; }
        public List<int> Counts { get; set; }

    }
}
