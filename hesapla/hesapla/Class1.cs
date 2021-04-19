using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace hesapla
{
    public class Hesapla
    {
        public int hesapla(int x)
        {
            var dllToplam = Assembly.LoadFile(@"C:\Users\Yasir\Desktop\ileri programlama\toplama.dll");
            var tipToplam = dllToplam.GetType("toplama.Toplama");
            var istekToplam = Activator.CreateInstance(tipToplam);
            var metodToplam = tipToplam.GetMethod("topla");
            int toplam = (int)metodToplam.Invoke(istekToplam, new object[] { 2, x });

            var dllFark = Assembly.LoadFile(@"C:\Users\Yasir\Desktop\ileri programlama\cikarma.dll");
            var tipFark = dllFark.GetType("cikarma.Cikarma");
            var istekFark = Activator.CreateInstance(tipFark);
            var metodFark = tipFark.GetMethod("cikar");
            int fark = (int)metodFark.Invoke(istekFark, new object[] { x, 3 });

            var dllCarp = Assembly.LoadFile(@"C:\Users\Yasir\Desktop\ileri programlama\carpma.dll");
            var tipCarp = dllCarp.GetType("carpma.Carpma");
            var istekCarp = Activator.CreateInstance(tipCarp);
            var metodCarp = tipCarp.GetMethod("carp");
            int carpim = (int)metodCarp.Invoke(istekCarp, new object[] { toplam, fark });

            //aslında bizim örnekte gerek yok ama kullanmış olmak için ekledim bölmeyi
            var dllBol = Assembly.LoadFile(@"C:\Users\Yasir\Desktop\ileri programlama\bolme.dll");
            var tipBol = dllBol.GetType("bolme.Bolme");
            var istekBol = Activator.CreateInstance(tipBol);
            var metodBol = tipBol.GetMethod("bol");
            int sonuc = (int)metodBol.Invoke(istekBol, new object[] { carpim, 1 });

            return sonuc;
        }
    }
}
