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
}