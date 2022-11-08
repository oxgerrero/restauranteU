using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_MaestraSinLogin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ESTUDIANTES datos = (ESTUDIANTES)Session["usuario"];
        if (datos != null)
        {
            ESTUDIANTES user = new Usuarios().login(datos.Usuario, datos.Contraseña);
            if (user != null)
            {
                Response.Redirect("inicioLogin.aspx");
            }
        }
    }
}
