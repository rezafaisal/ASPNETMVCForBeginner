using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Implementasi.WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label_Hello.Text = String.Empty;
            }
        }

        protected void Button_Kirim_Click(object sender, EventArgs e)
        {
            Label_Hello.Text = "Hello " + TextBox_Nama.Text + " di " + TextBox_Alamat.Text;
        }
    }
}