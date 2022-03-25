using MertCorukoglu_MEBCASE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertCorukoglu_MEBCASE.Context
{
    public class KategoriInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            List<Kategori> cats = new List<Kategori>() { new Kategori { KategoriAdi = "Kategori 1" }, new Kategori { KategoriAdi = "Kategori 2"} };

            foreach (var cat in cats)
            {
                context.Kategoriler.Add(cat);
            }
            context.SaveChanges();
            
        }
    }
}
