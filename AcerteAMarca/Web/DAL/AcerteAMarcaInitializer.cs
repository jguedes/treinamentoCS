using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.DAL
{
    public class AcerteAMarcaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AcerteAMarcaContext>
    {
        protected override void Seed(AcerteAMarcaContext context)
        {
            #region Carregar dados para testes ou população inicial do banco

            #region Initialize ProgramaDeTV
            #endregion

            #endregion

            //context.SaveChanges();

        }
    }
}