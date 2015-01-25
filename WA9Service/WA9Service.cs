using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication9.Database;
namespace WA9Service
{
    class WA9Service : IWA9Service
    {
        ItemDBEntities db = new ItemDBEntities();

        public List<Item> getAllItems()
        {
            try
            {
                List<Item> items = db.Items.ToList();
                return items;
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
                return null;
            }
        }


        public string insertItem(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return "Başarıyla eklendi";
        }

        public void testFunction() { }
    }
}
