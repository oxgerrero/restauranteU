using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_insertarAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string opcion = (string)(Session["opInsertar"]);
        if (opcion.Equals("usuario")){
            P_usuario.Visible = true;
            P_rol.Visible = false;
            P_restaurante.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
        }
        if (opcion.Equals("estado")){
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = true;
        }
        if (opcion.Equals("rol"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = true;
            P_restaurante.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
        }
        if (opcion.Equals("restaurante"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = true;
            P_menu.Visible = false;
            P_estado.Visible = false;
        }
        if (opcion.Equals("menu"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = false;
            P_menu.Visible = true;
            P_estado.Visible = false;
        }
    }

    protected void B_insertar_Click(object sender, EventArgs e)
    {
        USUARIO nuevo = new USUARIO();
        nuevo.Nombre = TB_nombre.Text;
        nuevo.Usuario = TB_usuario.Text;
        nuevo.Contraseña = TB_contraseña.Text;
        nuevo.Correo_electronico = TB_correo.Text;
        nuevo.Telefono = long.Parse(TB_telefono.Text);
        nuevo.Identificacion = long.Parse(TB_identificacion.Text);
        nuevo.Id_estado = int.Parse(DDL_estado.SelectedValue);
        nuevo.Id_rol = int.Parse(DDL_rol.SelectedValue);
    }
}