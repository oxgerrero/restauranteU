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

    }

    protected void B_insertarU_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "usuario";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void B_insertarE_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "estado";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void B_insertarR_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "rol";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void B_insertarRes_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "restaurante";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void B_insertarM_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "menu";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "tipoMenu";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "asistencia";
        Response.Redirect("insertarAdmin.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["opInsertar"] = "pagos";
        Response.Redirect("insertarAdmin.aspx");
        
    }

    protected void GridView6_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        PAGO pago = (PAGO)e.Row.DataItem;
        if (pago != null)
        {
            if (e.Row.FindControl("LB_Editar") != null)
            {

                ((Label)e.Row.FindControl("label4")).Text = pago.Fechas.ToString("yyyy-MM-dd");
            }
        }
    }

    protected void GridView6_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        PAGO pago = new PAGO();
        pago.Id_pago = int.Parse(e.NewValues[0].ToString());
        pago.Id_estudiante = int.Parse(e.NewValues[1].ToString());
        pago.Fechas = DateTime.Parse(e.NewValues[2].ToString());
        pago.Fechas=Convert.ToDateTime(pago.Fechas);
        pago.Cantidad = int.Parse((string)e.NewValues[3]);
        pago.Id_estado = int.Parse((String)e.NewValues[4]);
        pago.Saldo = Decimal.Parse((String)e.NewValues[5]);
        pago.Concepto = (String)e.NewValues[6];
        //Convert.ToDateTime(catalogo.Anio);
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        USUARIO user = new USUARIO();
        user.Id_usuario = int.Parse(e.NewValues[0].ToString());
        user.Id_estado = int.Parse(e.NewValues[1].ToString());
        user.Id_rol = int.Parse(e.NewValues[2].ToString());
        user.Nombre = (string)e.NewValues[3];
        user.Usuario = (string)e.NewValues[4];
        user.Contraseña = (string)e.NewValues[5];
        user.Telefono = Decimal.Parse(e.NewValues[6].ToString());
        user.Correo_electronico = e.NewValues[7].ToString();
        user.Identificacion = Decimal.Parse(e.NewValues[8].ToString());
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        USUARIO user = (USUARIO)e.Row.DataItem;
        if (user != null)
        {
            if (e.Row.FindControl("LB_Editar") != null)
            {
            }
        }
    }
}