using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        string oConn = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["oConn"].ConnectionString;
        public List<NCapas.CORRESPONSALES> CORRESPONSALES()
        {
            
            string sql = @"select c.COR_CORRESPONSAL_ID, c.COR_NOMBRE + ' - ' + Convert(NVarchar(max), Count(o.OFI_CORRESPONSAL_ID)) as COR_NOMBRE 
                    from CORRESPONSALES as c join OFICINAS as o on o.OFI_CORRESPONSAL_ID = c.COR_CORRESPONSAL_ID 
                    group by c.COR_CORRESPONSAL_ID,c.COR_NOMBRE";

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(oConn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            List<NCapas.CORRESPONSALES> list = new List<NCapas.CORRESPONSALES>();

            list.Add(new NCapas.CORRESPONSALES { COR_CORRESPONSAL_ID = 0, COR_NOMBRE = "Seleccionar" });

            foreach (DataRow dr in dt.Rows)
            {
                NCapas.CORRESPONSALES corresp = new NCapas.CORRESPONSALES
                {
                    COR_CORRESPONSAL_ID = Convert.ToInt32(dr["COR_CORRESPONSAL_ID"].ToString()),
                    COR_NOMBRE = dr["COR_NOMBRE"].ToString()
                };
                list.Add(corresp);
            }
            return list;
        }

        public List<NCapas.OFICINAS> OFICINAS(int OFI_CORRESPONSAL_ID)
        {
            string sql = "select top(1)  o.OFI_CORRESPONSAL_ID,Max(Len(o.OFI_NOMBRE)),o.OFI_NOMBRE from OFICINAS as o where o.OFI_CORRESPONSAL_ID = " + OFI_CORRESPONSAL_ID + " group by o.OFI_NOMBRE,o.OFI_CORRESPONSAL_ID";

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(oConn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            List<NCapas.OFICINAS> list = new List<NCapas.OFICINAS>();

            foreach (DataRow dr in dt.Rows)
            {
                NCapas.OFICINAS corresp = new NCapas.OFICINAS
                {
                    OFI_CORRESPONSAL_ID = Convert.ToInt32(dr["OFI_CORRESPONSAL_ID"].ToString()),
                    OFI_NOMBRE = dr["OFI_NOMBRE"].ToString()
                };
                list.Add(corresp);
            }
            return list;
        }
    }
}
