using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_ingresar_Click(object sender, EventArgs e)
    {
        USUARIO user = new Usuarios().login(TB_username.Text, TB_password.Text);
        if (user != null)
        {
            if (user.Id_estado == 1)
            {
                Session["usuario"] = user;
                Response.Redirect("inicioLogin.aspx");
            }
            else
            {
                ClientScriptManager cm = this.ClientScript;
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('usuario inactivo');</script>");
                TB_password.Text = "";
                TB_username.Text = "";
                Session["usuario"] = null;
            }
        }
        else
        {
            ClientScriptManager cm = this.ClientScript;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario o contraseña invalidos');</script>");
            TB_username.Text = "";
            TB_password.Text = "";
            return;
        }
    }

}