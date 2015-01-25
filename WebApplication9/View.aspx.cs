using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication9.Database;

namespace WebApplication9
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"].ToString());

            ItemDBEntities db = new ItemDBEntities();
            Item it = db.Items.Where(i => i.Id == Id).Single();
            lblAdi.Text = it.ItemName;
            lblSayisi.Text = it.ItemCount.ToString();

        }
    }
}