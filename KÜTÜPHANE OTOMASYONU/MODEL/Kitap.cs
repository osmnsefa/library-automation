using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KÜTÜPHANE_OTOMASYONU.MODEL
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapisim { get; set; }
        public string kitapyazar { get; set; }
        public string kitapdili{ get; set; }
        public string yayınevi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfasayısı { get; set; }
        public int basımyılı { get; set; }


        public Kitap()
        {

        }
        public Kitap(int kitapid,string kitapisim,string kitapyazar,string kitapdili,string yayınevi,string tur,int adet,int sayfasayısı,int basımyılı)
        {
            this.kitapid = kitapid;
            this.kitapisim = kitapisim;
            this.kitapyazar = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayınevi = yayınevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayısı = sayfasayısı;
            this.basımyılı = basımyılı;
        }
        public int getkitapid()
        {
            return this.kitapid;
        }
        public string getkitapismi()
        {
            return this.kitapisim;
        }
        public string getkitapyazar()
        {
            return this.kitapyazar;
        }
        public string getkitapdili()
        {
            return kitapdili;
        }
        public string getyayınevi()
        {
            return this.yayınevi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfasayısı()
        {
            return this.sayfasayısı;
        }
        public int getbasımyılı()
        {
            return this.basımyılı;
        }

    }
}
