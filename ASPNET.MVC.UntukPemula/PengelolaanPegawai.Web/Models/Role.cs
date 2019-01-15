using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengelolaanPegawai.Web.Models
{
    public class Roles
    {
        [Key]
        public string Id { set; get; }
        public string Name { set; get; }
    }
}
