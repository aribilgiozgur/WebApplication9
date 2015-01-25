using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication9.Database;

namespace WebApplication9
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ItemDBEntities db = new ItemDBEntities();
            
            Item i = new Item();
            i.ItemName = txtEsyaAdi.Text;
            i.ItemCount = int.Parse(txtEsyaSayisi.Text);
            db.Items.Add(i);
            db.SaveChanges();

            Response.Redirect("Index.aspx");
        }
    }
}