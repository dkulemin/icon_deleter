using System;
using System.IO;

namespace icon_deleter
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("C:\\Users\\d.v.kulemin.UTMN\\Desktop\\Портал Vmeste.url");
            File.Delete("C:\\Users\\Public\\Desktop\\Техподдержка ТюмГУ.lnk");
            File.Delete("C:\\Users\\d.v.kulemin.UTMN\\Desktop\\Консультант Плюс.lnk");
        }
    }
}
