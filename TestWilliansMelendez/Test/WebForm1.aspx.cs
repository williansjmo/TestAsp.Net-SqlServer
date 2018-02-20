using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Test.srWebService;

namespace Test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        srWebService.Service1Client client = new srWebService.Service1Client(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    ddlCorresponsales.DataSource = client.CORRESPONSALES().ToList().OrderBy(c => c.COR_CORRESPONSAL_ID);
                    ddlCorresponsales.DataBind();
                    ddlCorresponsales.SelectedValue = "0";
                    lblCorresponsal.Text = "";
                    lblOficina.Text = "";
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void ddlCorresponsales_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCorresponsal.Text = "";
            lblOficina.Text = "";

            OFICINAS of = client.OFICINAS(Convert.ToInt32(ddlCorresponsales.SelectedItem.Value)).FirstOrDefault();
            Resultado(of.OFI_NOMBRE);

            lblCorresponsal.Text = $"Corresponsal: {ddlCorresponsales.SelectedItem.Text}";
            lblOficina.Text = $"Oficina: {of.OFI_NOMBRE}";

        }
        void Resultado(string valor)
        {
            //string cadena = "agence principale";
            var result = from a in valor.ToUpper().ToCharArray().Where(Char.IsLetter)
                         group a by a into g
                         select new
                         {
                             Letra = g.Key,
                             Repeticiones = g.Count()
                         };

            string table = @"<table style=width: 100%; >
            <tr>
                <td> Caracteres</td >
   
                   <td>Veces</td>
            </tr>";
            foreach (var item in result)
            {
                table += "<tr><td>" + item.Letra + "</td><td>" + item.Repeticiones + "</td></tr>";
            }
            table += "</table>";
            Literal1.Text = table;
        }
    }
}