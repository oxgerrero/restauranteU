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
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("estado")){
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = true;
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("rol"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = true;
            P_restaurante.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("restaurante"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = true;
            P_menu.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("menu"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = false;
            P_menu.Visible = true;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("tipoMenu"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_restaurante.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = true;
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
        new Usuarios().insertarUsuarioAdmin(nuevo);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        ESTADO estado = new ESTADO();
        estado.Nombre = TextBox1.Text;
        new Usuarios().insertarEstadoAdmin(estado);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        ROL nuevo = new ROL();
        nuevo.Nombre = TextBox2.Text;
        new Usuarios().insertarRolAdmin(nuevo);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");

    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        //asistencia
        USUARIO buscado = new Usuarios().datos_usuario_cc(Decimal.Parse(TextBox3.Text));
        if (buscado != null)
        {

        }
        else
        {
            Response.Write("<script>alert('Usuario no existe');window.location = 'administrador.aspx';</script>");
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        MENU nuevo = new MENU();
        nuevo.Dia = Calendar1.SelectedDate;
        nuevo.Menu = TextBox4.Text;
        nuevo.Tipo_menu=int.Parse(DDL_tipoComida0.SelectedValue);
        new Usuarios().insertarMenuAdmin(nuevo);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //tipo menu
    }
}