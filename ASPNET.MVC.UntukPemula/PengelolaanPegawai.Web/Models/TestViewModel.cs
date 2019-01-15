using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengelolaanPegawai.Web.Models
{
    public class TestViewModel
    {
        public string UserName { set; get; }
        
        public string RoleId { set; get; }
        public IEnumerable<System.Web.Mvc.SelectListItem> Roles { get; set; }
    }
}
