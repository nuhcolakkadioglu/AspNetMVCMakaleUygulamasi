using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Core.Entities
{
    public partial class User : Base
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Job { get; set; }
        public byte[] Image { get; set; }
    }
}
