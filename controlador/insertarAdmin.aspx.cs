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
            P_Asistencia.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
            Panel1.Visible = false;
            P_insertarPagos.Visible = false;
        }
        if (opcion.Equals("estado")){
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_Asistencia.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = true;
            Panel1.Visible = false;
            P_tipoMenu.Visible = false;
            P_insertarPagos.Visible = false;
        }
        if (opcion.Equals("rol"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = true;
            P_Asistencia.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
            Panel1.Visible = false;
            P_tipoMenu.Visible = false;
            P_insertarPagos.Visible = false;
        }
        if (opcion.Equals("restaurante"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            Panel1.Visible = true;
            P_Asistencia.Visible = false;
            P_menu.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
            P_insertarPagos.Visible = false;
        }
        if (opcion.Equals("menu"))
        {
            P_usuario.Visible = false;
            Panel1.Visible = false;
            P_rol.Visible = false;
            P_Asistencia.Visible = false;
            P_menu.Visible = true;
            P_estado.Visible = false;
            P_insertarPagos.Visible = false;
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("tipoMenu"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            P_Asistencia.Visible = false;
            Panel1.Visible = false;
            P_menu.Visible = false;
            P_insertarPagos.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = true;
        }
        if (opcion.Equals("asistencia"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            Panel1.Visible = false;
            P_Asistencia.Visible = true;
            P_menu.Visible = false;
            P_insertarPagos.Visible = false;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
        }
        if (opcion.Equals("pagos"))
        {
            P_usuario.Visible = false;
            P_rol.Visible = false;
            Panel1.Visible = false;
            P_Asistencia.Visible = false;
            P_menu.Visible = false;
            P_insertarPagos.Visible = true;
            P_estado.Visible = false;
            P_tipoMenu.Visible = false;
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
            ASISTENCIA nuevo = new ASISTENCIA();
            nuevo.id_restaurante= int.Parse(DropDownList1.SelectedValue);
            nuevo.id_tipo= int.Parse(DDL_tipoComida.SelectedValue);
            nuevo.id_usuario = buscado.Id_usuario;
            nuevo.fecha = DateTime.Now;
            new Usuarios().insertarAsistencia(nuevo);
            Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");
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
        nuevo.id_Tipo=int.Parse(DDL_tipoComida0.SelectedValue);
        new Usuarios().insertarMenuAdmin(nuevo);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //tipo menu
        string nombre = TextBox5.Text;
        int costo = int.Parse(TextBox7.Text);
        TIPO nuevo = new TIPO();
        nuevo.descripcion = nombre;
        nuevo.costo = costo;
        new Usuarios().insertarTipoMenu(nuevo);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");

    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        string nombre = TextBox6.Text;
        RESTAURANTE nuevo = new RESTAURANTE();
        nuevo.Nombre = nombre;
        new Usuarios().insertarRestaurante(nuevo);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");

    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        string identificacion = TextBox8.Text;
        string pagado = TextBox9.Text;
        int id_estado = int.Parse(DropDownList2.SelectedValue);
        string saldo = TextBox10.Text;
        string concepto = TextBox11.Text;
        PAGO nuevo = new PAGO();
        USUARIO user = new Usuarios().datos_usuario_cc(decimal.Parse(identificacion));
        nuevo.Id_estudiante = user.Id_usuario;
        nuevo.Id_estado = id_estado;
        nuevo.Saldo = int.Parse(saldo);
        nuevo.Fechas = (DateTime.Now).ToString();
        nuevo.Concepto = concepto;
        nuevo.Cantidad = decimal.Parse(pagado);
        new Usuarios().insertarPago(nuevo);
        Response.Write("<script>alert('ingresado con exito');window.location = 'administrador.aspx';</script>");
    }
}