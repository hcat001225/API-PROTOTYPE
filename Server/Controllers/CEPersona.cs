using Server.Implementation;
using Server.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Server.Models;
using Microsoft.Extensions.Logging.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Server.Controllers
{
    public class CEPersona : BaseImplementation, IBaseInterface<EPersona>
    {

        public List<EPersona> GetAll()
        {
            string query = @"SELECT * FROM RPersona;";
            SqlCommand sqlCommand = CreateBasicCommand(query);
            List<EPersona>? lstPersonas = null;
            DataTable? data = null;
            try
            {
                data = ExecuteDataTableCommand(sqlCommand);
                lstPersonas = new List<EPersona>();

                foreach (DataRow item in data.Rows)
                {
                    EPersona ePersona = new EPersona();
                    ePersona.Id = (int)item["Id"];
                    ePersona.Nombre = (string)item["Nombre"];
                    ePersona.Ci = (string)item["CI"];
                    ePersona.NumeroCelular = (int)item["NumeroCelular"];
                    ePersona.Edad = Convert.ToDateTime(item["Edad"].ToString());
                    ePersona.Sexo = (string)item["Sexo"];
                    ePersona.Estado = (string)item["Estado"];
                    ePersona.FechaCreacion = Convert.ToDateTime(item["FechaCreacion"].ToString());
                    ePersona.FechaActualizacion = (item["FechaActualizacion"].ToString()) == string.Empty ? DateTime.Now : Convert.ToDateTime(item["FechaActualizacion"].ToString());
                    ePersona.IdCiudad = (int)item["IdCiudad"];
                    lstPersonas.Add(ePersona);
                    //lstPersonas.Add(new EPersona((int)item["Id"],(string)item["Nombre"], (string)item["CI"], (int)item["NumeroCelular"],Convert.ToDateTime(item["Edad"].ToString()),(string)item["Sexo"]
                    //                ,(string)item["Estado"], Convert.ToDateTime(item["FechaCreacion"].ToString()), Convert.ToDateTime(item["FechaActualizacion"].ToString()) == null? DateTime.Now : Convert.ToDateTime(item["FechaActualizacion"].ToString()), (int)item["IdCiudad"]));
                }
                return lstPersonas;
            }catch(Exception ex)
            {
                return lstPersonas;
            }
            

        }
    }
}
