using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_administrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ESTUDIANTES datos = (ESTUDIANTES)Session["usuario"];
        if (datos.Id_rol != 1)
        {
            Response.Write("<script>alert('Usted no puede estar aqui');window.location = 'catalogo.aspx';</script>");
        }
    }
}