using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication9.Database;

namespace WebApplication9
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ItemDBEntities db = new ItemDBEntities();
            List<Item> items = db.Items.ToList();
            rptItems.DataSource = items;
            rptItems.DataBind();           
        }
    }
}