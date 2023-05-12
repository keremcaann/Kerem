using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Proje1.Model
{
    public class Sales 
    {
        public Sales()
        {
            olusturuldu = DateTime.Now.ToString();
        }
        public virtual int satis { get; set; }
        public virtual string olusturuldu { get; set; }
        public virtual decimal fiyat { get; set; }
        public virtual int adet { get; set; }

        public virtual string seans { get; set; }

        public virtual string musteri { get; set; }

        public virtual string koltuk { get; set; }

        public override string ToString()
        {
            Movie movie = new Movie();
            return $"{movie.movieName} Adlı Filmin {seans} Seansına {adet} Adet Bilet Kesilmiştir. Toplam Tutar {fiyat} ₺ || Satın" +
                $"Alınma Tarihi = {olusturuldu}";
        }
    }

    public class SalesMapping : ClassMapping<Sales>
    {
        public SalesMapping()
        {
            Table("Sales");
            Id(x => x.satis, m => m.Generator(Generators.Native));
            Property(x => x.olusturuldu, x => x.NotNullable(true));
            Property(x => x.fiyat, x => x.NotNullable(true));
            Property(x => x.adet, x => x.NotNullable(true));
            Property(x => x.seans, x => x.NotNullable(true));
            Property(x => x.musteri, x => x.NotNullable(false));
            Property(x => x.koltuk, x => x.NotNullable(false));
        }
    }
}
