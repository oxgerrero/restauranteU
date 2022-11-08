using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!TB_contraseña1.Text.Equals(TB_contraseña2.Text))
        {
            Response.Write("<script>alert('Las contraseñas deben ser iguales');</script>");
            return;
        }
        ESTUDIANTES usuario = new ESTUDIANTES();
        usuario.Nombre = TB_nombre.Text;
        usuario.Usuario = TB_usuario.Text;
        usuario.Contraseña = TB_contraseña1.Text;
        //comprovacion de existencia
        ESTUDIANTES usuario2 = new ESTUDIANTES();
        usuario2.Usuario = TB_usuario.Text;
        usuario2 = new Usuarios().comprobar_usuario(usuario2);
        if ((usuario2 == null))
        {
            new Usuarios().insertarUsuario(usuario);
            limpiarcampos();
            Response.Write("<script>alert('usuario registrado exitosamente');window.location = 'login.aspx';</script>");
        }
    }
    public void limpiarcampos()
    {
        TB_nombre.Text = "";
        TB_usuario.Text = "";
        TB_contraseña1.Text = "";
        TB_contraseña2.Text = "";
    }
}