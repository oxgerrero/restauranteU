using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class Usuarios
{
    public List<USUARIO> datos_usuarios()
    {
        List<USUARIO> usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.USUARIOs.OrderBy(x => x.Id_usuario).ToList();
        }
        foreach (USUARIO user in usuarios)
        {
            user.Contraseña = DesEncriptar(user.Contraseña);
        }
        return usuarios;
    }
    public List<USUARIO> datos_usuariosAdmin()
    {
        List<USUARIO> usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.USUARIOs.OrderBy(x => x.Id_usuario).ToList();
        }
        foreach (USUARIO user in usuarios)
        {
            user.Contraseña = DesEncriptar(user.Contraseña);
        }
        return usuarios;
    }
    public List<ESTADO> datos_estadosAdmin()
    {
        List<ESTADO> estados;
        using (var db = new WELFAREContext())
        {
            estados = db.ESTADOs.OrderBy(x => x.Id_estado).ToList();
        }
        return estados;
    }
    public List<ROL> datos_rolAdmin()
    {
        List<ROL> estados;
        using (var db = new WELFAREContext())
        {
            estados = db.ROLs.OrderBy(x => x.Id_rol).ToList();
        }
        return estados;
    }
    public List<RESTAURANTE> datos_restauranteAdmin()
    {
        List<RESTAURANTE> estados;
        using (var db = new WELFAREContext())
        {
            estados = db.RESTAURANTEs.OrderBy(x => x.Id_restaurante).ToList();
        }
        return estados;
    }
    public List<MENU> datos_menuAdmin()
    {
        List<MENU> estados;
        using (var db = new WELFAREContext())
        {
            estados = db.MENUs.OrderBy(x => x.Id_menu).ToList();
        }
        return estados;
    }
    public List<PAGO> datos_pagoAdmin()
    {
        List<PAGO> estados;
        using (var db = new WELFAREContext())
        {
            estados = db.PAGOs.OrderBy(x => x.Id_pago).ToList();
        }
        return estados;
    }

    public void insertarUsuario(USUARIO usuarios)
    {
        usuarios.Id_rol = 2;
        usuarios.Id_estado = 1;
        usuarios.Contraseña = Encriptar(usuarios.Contraseña);
        using (var db = new WELFAREContext())
        {
            db.USUARIOs.Add(usuarios);
            db.SaveChanges();
        }
    }
    public void insertarUsuarioAdmin(USUARIO usuarios)
    {
        usuarios.Contraseña = Encriptar(usuarios.Contraseña);
        using (var db = new WELFAREContext())
        {
            db.USUARIOs.Add(usuarios);
            db.SaveChanges();
        }
    }
    public USUARIO login(string usuario, string contraseña)
    {

        contraseña = Encriptar(contraseña);
        using (var db = new WELFAREContext())
        {
            USUARIO eusuario = db.USUARIOs.Where(u => u.Usuario == usuario).Where(c => c.Contraseña == contraseña).FirstOrDefault();
            if (eusuario == null)
            {
                return null;
            }
            else
            {
                eusuario.Contraseña = DesEncriptar(eusuario.Contraseña);
                return eusuario;
            }

        }
    }
    public string Encriptar(string clave)
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

    }
    public void Ac_User(USUARIO usuario)
    {
        usuario.Contraseña = Encriptar(usuario.Contraseña);
        using (var db = new WELFAREContext())
        {
            db.USUARIOs.Attach(usuario);
            var entry = db.Entry(usuario);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
    public USUARIO datos_usuario_log(int id)
    {
        USUARIO usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.USUARIOs.Where(x => x.Id_usuario == id).FirstOrDefault();
        }
        usuarios.Contraseña = DesEncriptar(usuarios.Contraseña);
        return usuarios;
    }
    public USUARIO datos_usuario_cc(Decimal cc)
    {
        USUARIO usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.USUARIOs.Where(x => x.Identificacion == cc).FirstOrDefault();
        }
        usuarios.Contraseña = DesEncriptar(usuarios.Contraseña);
        return usuarios;
    }

    public USUARIO comprobar_usuario(USUARIO user)
    {
        using (var db = new WELFAREContext())
        {
            return (USUARIO)db.USUARIOs.Where(x => x.Usuario.Equals(user.Usuario)).FirstOrDefault();
        }
    }

    public void insertarEstadoAdmin(ESTADO usuarios)
    {
        using (var db = new WELFAREContext())
        {
            db.ESTADOs.Add(usuarios);
            db.SaveChanges();
        }
    }
    public void insertarRolAdmin(ROL usuarios)
    {
        using (var db = new WELFAREContext())
        {
            db.ROLs.Add(usuarios);
            db.SaveChanges();
        }
    }
    public void insertarMenuAdmin(MENU usuarios)
    {
        using (var db = new WELFAREContext())
        {
            db.MENUs.Add(usuarios);
            db.SaveChanges();
        }
    }
}