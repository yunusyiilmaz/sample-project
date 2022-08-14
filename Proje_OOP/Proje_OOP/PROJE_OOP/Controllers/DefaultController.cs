using Microsoft.AspNetCore.Mvc;
using PROJE_OOP.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJE_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void Message()
        {
            ViewBag.m1 = "MERHABA DÜNYA";
            ViewBag.m2 = "NE VAR NE YOK";
            ViewBag.m3 = "ÇALIŞMAK ÇALIŞMAK ÇALIŞMAK";
            ViewBag.t = topla();
            ViewBag.s = f(7);
        }

        int topla()
        {
            int s1 = 55;
            int s2 = 6;
            int sonuc = s1 + s2;
            return sonuc;
        }
        int islem(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        int f( int t)
        {
            int sonuc = 1;
            for(int i=1; i<=t; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        void Kullanici(string p)
        {
            ViewBag.k = p;
        }
        void MesajLİstesi(string m)
        {
            ViewBag.v = m;
        }
        public IActionResult Index()
        {
            Kullanici("Merhaba");
            Message();
            return View();
            
        }
        public IActionResult Products()
        {
            MesajLİstesi("Deneme yazısıdır");
            Message();
            ViewBag.d =islem(55, 6);
            return View();           
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.Id = 61;
            sehirler.Ad = "Trabzon";
            sehirler.Nufus = 750000;
            ViewBag.s = sehirler.Id;
            ViewBag.s1 = sehirler.Ad;
            ViewBag.s2 = sehirler.Nufus;

            sehirler.Id = 55;
            sehirler.Ad = "Samsun";
            sehirler.Nufus = 1000000;
            ViewBag.s3 = sehirler.Id;
            ViewBag.s4 = sehirler.Ad;
            ViewBag.s5 = sehirler.Nufus;
            return View();
        }
       
    }
}
