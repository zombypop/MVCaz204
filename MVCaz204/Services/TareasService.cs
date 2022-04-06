using Dapper;
using Microsoft.Extensions.Configuration;
using MVCaz204.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MVCaz204.Services
{
    public class TareasService
    {
        private readonly string cs;
        public TareasService(IConfiguration config)
        {
            cs = config.GetConnectionString("base");
        }
        public IEnumerable<Tareas> GetTareas()
        {
            using (IDbConnection con = new SqlConnection(cs))
            {
                var qry = "select * from Tarea";
                var tareas = con.Query<Tareas>(qry);
                return tareas;
            }

        }
    }
}
