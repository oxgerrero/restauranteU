using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class Usuarios
{
    public List<ESTUDIANTES> datos_usuarios()
    {
        List<ESTUDIANTES> usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.ESTUDIANTESs.OrderBy(x => x.Id_usuario).ToList();
        }
        foreach (ESTUDIANTES user in usuarios)
        {
            //user.Contraseña = DesEncriptar(user.Contraseña);
        }
        return usuarios;
    }
    public void insertarUsuario(ESTUDIANTES usuarios)
    {
        usuarios.Id_rol = 2;
        usuarios.Id_estado = 1;
        //usuarios.Contraseña = Encriptar(usuarios.Contraseña);
        using (var db = new WELFAREContext())
        {
            db.ESTUDIANTESs.Add(usuarios);
            db.SaveChanges();
        }
    }
    public ESTUDIANTES login(string usuario, string contraseña)
    {

        //contraseña = Encriptar(contraseña);
        using (var db = new WELFAREContext())
        {
            ESTUDIANTES eusuario = db.ESTUDIANTESs.Where(u => u.Usuario == usuario).Where(c => c.Contraseña == contraseña).FirstOrDefault();
            if (eusuario == null)
            {
                return null;
            }
            else
            {
                //eusuario.Contraseña = DesEncriptar(eusuario.Contraseña);
                return eusuario;
            }

        }
    }
    /*public string Encriptar(string clave)
    {
        string result = string.Empty;
        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(clave);
        result = Convert.ToBase64String(encryted);
        Console.WriteLine("clave encriptada" + result);
        return result;
    }
    public string DesEncriptar(string claveE)
    {
        try
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(claveE);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            Console.WriteLine("clave desencriptada" + result);
            return result;
        }
        catch (Exception ex)
        {
            return claveE;
        }

    }*/
    public void Ac_User(ESTUDIANTES usuario)
    {
        //usuario.Contraseña = Encriptar(usuario.Contraseña);
        using (var db = new WELFAREContext())
        {
            db.ESTUDIANTESs.Attach(usuario);
            var entry = db.Entry(usuario);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
    public ESTUDIANTES datos_usuario_log(int id)
    {
        ESTUDIANTES usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.ESTUDIANTESs.Where(x => x.Id_usuario == id).FirstOrDefault();
        }
        //usuarios.Contraseña = DesEncriptar(usuarios.Contraseña);
        return usuarios;
    }
    public ESTUDIANTES comprobar_usuario(ESTUDIANTES user)
    {
        using (var db = new WELFAREContext())
        {
            return (ESTUDIANTES)db.ESTUDIANTESs.Where(x => x.Usuario.Equals(user.Usuario)).FirstOrDefault();
        }
    }
}