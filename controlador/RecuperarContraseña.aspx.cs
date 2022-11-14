using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vista_RecuperarContraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void B_recuperar_Click(object sender, EventArgs e)
    {
        string user = TB_user.Text;
        Usuarios datos = new Usuarios();
        USUARIO Rusuario = datos.contraseña(user);
        contraseña rec = new contraseña();
        token Otoken = new token();
        Otoken.finicio = DateTime.Now;
        Otoken.ffin = DateTime.Now.AddMinutes(10);
        Otoken.id_user = Rusuario.Id_usuario;
        Otoken.tactivo = rec.encriptar(JsonConvert.SerializeObject(Otoken));//convierte en cadena JSON clase Token obj token
        datos.insertarRusuario(Otoken);
        string linkacceso = Otoken.tactivo;
        rec.enviarmail(Rusuario.Correo_electronico, Otoken.tactivo, linkacceso);
        Session["Rtoken"] = Otoken;
        Session["Rusuario"] = Rusuario;
    }
}