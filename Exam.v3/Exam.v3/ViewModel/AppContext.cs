using Exam.v3.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.v3.ViewModel
{
    class AppContext:DbContext
    {
        public AppContext():base("DefaultConnection")
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
