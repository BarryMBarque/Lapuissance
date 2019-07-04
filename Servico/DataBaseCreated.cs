using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Persistencia.RepositoryFolders;
using System.Data;

namespace Servico
{
     public class DataBaseCreated
    {
        public static void CreatDataBase()
        {
            using (var contexto = new EFContext())
            {

              // contexto.Database.EnsureDeleted();
                 contexto.Database.EnsureCreated();
            }
        }
    }
}
