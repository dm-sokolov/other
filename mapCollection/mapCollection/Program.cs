using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadNhibernateCfg();

            ////CRUID
            var repository = new HeroRepository();
            var wizard = new Hero
            {
                Name = "Jon dow",
                HP = 100,
                MP = 100,
                Profession = "Teacher"
            };
            
            ////CREATE
            repository.Add(wizard);

            ////READ
            var someone = repository.GetHeroByHP(100);
            
            ////UPDATE
            someone.Profession = "Killer";
            repository.Update(someone);

            ////DELETE
            repository.Delete(someone);


        }

        public static void LoadNhibernateCfg()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Hero).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);

        }
    }
}   
