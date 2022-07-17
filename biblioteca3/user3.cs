using biblioteca1;
using biblioteca2;
using System.Data;

namespace biblioteca3
{
    public class user3
    {
        user objd = new user();

        public Logim userz(string rol, string usuario, string clave)
        {
            return objd.Login(rol, usuario,clave);
        }
    }
}
