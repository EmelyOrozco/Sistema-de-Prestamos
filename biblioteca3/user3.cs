using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using biblioteca2;
using biblioteca1;
using System.Data;

namespace biblioteca3
{
    public class user3
    {
        user objd = new user();

        public DataTable userz(user2 obje)
        {
            return objd.users(obje);
        }
    }
}
