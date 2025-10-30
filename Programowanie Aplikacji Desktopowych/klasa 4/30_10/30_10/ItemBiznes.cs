using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_10
{
    class ItemBiznes
    {
        bazaContext Context;
        public ItemBiznes()
        {
            Context = new bazaContext();
        }

        public List<Item> pobierzDane()
        {
            return Context.Items.ToList();
        }
    }
}
