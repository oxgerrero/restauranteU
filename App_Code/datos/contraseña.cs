using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Descripción breve de contraseña
/// </summary>
public class contraseña
{
    private string correo = "dg1342732@gmail.com";
    private string contrasena = "rwxghlsyxrtqkzog";
    public token validartoken(string token, int id)
    {
        return new WELFAREContext().TOKENs.Where(x => x.tactivo == token && x.id_user == id).FirstOrDefault();
    }

    public string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
        {
            output.Append(hashedBytes[i].ToString("x2").ToLower());
        }
        return output.ToString();
    }

    public void enviarmail(string correodestino, string usertoken, string linkacceso)
    {
        //mail
        string correol = "<body>"
+ "<table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0'>"
+ "<tr>"
+ "<td class='esd-block-banner' style='position: relative;' align='center' esdev-config='h1'><a target='_blank'><img class='adapt-img esdev-stretch-width esdev-banner-rendered' src='https://www.nicepng.com/png/full/414-4144393_en-virtud-de-su-misin-2015-se-busca.png' alt title style='display: block;' width='100%'></a>"
+ "</td>"
+ "</tr>"
+ "<tr>"
+ "<tr>"
+ "<td class='esd-block-text es-p15t es-p15b es-p20r es-p20l' bgcolor='transparent' align='center'>"
+ "<h2 style='color: #333333;'>" + "Señor Usuario \n</h2>"
+ "</td>"
+ "</tr>"
+ "<tr>"
+ "<td class='esd-block-text es-p15b es-p30r es-p30l' bgcolor='transparent' align='center'>"
+ "<h3 style='line-height: 150%;'><em>Usted a solicitado un recuperacion de contraseña, utilice este codigo para recuperar su contraseña ahoramismo.\n" +
        "Cuenta con diez (10) minutos para hacer valida la recuperacion.\n" + "su codigo de acceso es \n" + " <a href='http://localhost:60813/vista/Rcontraseña.aspx?tk=" + linkacceso + "'>" + "RECUPERAR" + "</a></em></h3>"
+ "</td>"
+ "</tr>"
+ "</tr>"
+ "<tr>"
+ "<tr>"
+ "<td class='esd-block-image' align='center' style='font-size:0'><a target='_blank'><img class='adapt-img' src='http://catdelune.files.wordpress.com/2013/06/18226884-conjunto-de-elementos-decorativos-bordes-y-el-marco-de-pagina-de-las-reglas.png' alt style='display: block;' width='600'></a>"
+ "</td>"
+ "</tr>"
+ "</tr>"
+ "</table>"
+ "</body>";
        MailMessage mail = new MailMessage();
        SmtpClient SmtpSever = new SmtpClient("smtp.gmail.com");
        mail.IsBodyHtml = true;
        mail.From = new MailAddress(correo, "Recuperacion contrasena");//correo que envia, diplay name
        SmtpSever.Host = "smtp.gmail.com";//servidor gmail
        mail.Subject = "Recupere su contraseña";//asunto
        mail.Body = correol;
        mail.To.Add(correodestino);//destino del correo
        mail.Priority = MailPriority.Normal;

        //Configuracion del SMTP
        SmtpSever.Port = 587;
        SmtpSever.Credentials = new System.Net.NetworkCredential(correo, contrasena);//correo origen, contra*
        SmtpSever.EnableSsl = true;
        SmtpSever.Send(mail);//eviar
                             //mail

    }

    public void enviarmail_actualizarUsuario(string correodestino, USUARIO datos)
    {
        //mail
        string correol = "<body>"
+ "<table class='es-wrapper' width='100%' cellspacing='0' cellpadding='0'>"
+ "<tr>"
+ "<td class='esd-block-banner' style='position: relative;' align='center' esdev-config='h1'><a target='_blank'><img class='adapt-img esdev-stretch-width esdev-banner-rendered' src='https://www.nicepng.com/png/full/414-4144393_en-virtud-de-su-misin-2015-se-busca.png' alt title style='display: block;' width='100%'></a>"
+ "</td>"
+ "</tr>"
+ "<tr>"
+ "<tr>"
+ "<td class='esd-block-text es-p15t es-p15b es-p20r es-p20l' bgcolor='transparent' align='center'>"
+ "<h2 style='color: #333333;'>Señor usuario \t" + datos.Nombre + "\n</h2>"
+ "</td>"
+ "</tr>"
+ "<tr>"
+ "<td class='esd-block-text es-p15b es-p30r es-p30l' bgcolor='transparent' align='center'>"
+ "<h3 style='line-height: 150%;'><em>Sus datos se an actualizado de manera exitosa </br>"
            + "nombres: " + datos.Nombre + " </br>"
            + "email: " + datos.Correo_electronico + " </br>"
            + "telefono: " + datos.Telefono + " </br>"
            + "usuario: " + datos.Usuario + " </br>"
            + "contraseña: " + datos.Contraseña + "    </br></br></br></br>"
            + "si no fue usted quien modifico estos datos acceda a su cuenta con las credenciales anteriores y modifique los datos </br>" +
            "ademas envianos un correo para verificar lo sucedido" + "<a href='http://localhost:60813/vista/inicio.aspx'>ingresar</a>" + " </a></em></h3>"
+ "</td>"
+ "</tr>"
+ "</tr>"
+ "<tr>"
+ "<tr>"
+ "<td class='esd-block-image' align='center' style='font-size:0'><a target='_blank'><img class='adapt-img' src='http://catdelune.files.wordpress.com/2013/06/18226884-conjunto-de-elementos-decorativos-bordes-y-el-marco-de-pagina-de-las-reglas.png' alt style='display: block;' width='600'></a>"
+ "</td>"
+ "</tr>"
+ "</tr>"
+ "</table>"
+ "</body>";
        MailMessage mail = new MailMessage();
        SmtpClient SmtpSever = new SmtpClient("smtp.gmail.com");
        mail.IsBodyHtml = true;
        mail.From = new MailAddress(correo, "datos actualizados");//correo que envia, diplay name
        SmtpSever.Host = "smtp.gmail.com";//servidor gmail
        mail.Subject = "Datos actualizados";//asunto
        mail.Body = correol;
        mail.To.Add(correodestino);//destino del correo
        mail.Priority = MailPriority.Normal;

        //Configuracion del SMTP
        SmtpSever.Port = 587;
        SmtpSever.Credentials = new System.Net.NetworkCredential(correo, contrasena);//correo origen, contra*
        SmtpSever.EnableSsl = true;
        SmtpSever.Send(mail);//eviar
                             //mail

    }

}