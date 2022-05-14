using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miau.Areas.Admin.Model
{
    public class PostModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string AnimalName { get; set; }
        public string Mail { get; set; }
        public string Note { get; set; }
    }
}
