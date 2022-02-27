using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class frmReniec : System.Web.UI.Page
    {
        srReniecWb.wsReniecSoapClient servicio = new srReniecWb.wsReniecSoapClient();

        private void Listar()
        {
            gvDatos.DataSource = servicio.Listar().Tables[0];
            gvDatos.DataBind();
        } 
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string description = txtDni.Text.Trim();
            gvDatos.DataSource = servicio.Buscar(description);
            gvDatos.DataBind();
        }
    }
}