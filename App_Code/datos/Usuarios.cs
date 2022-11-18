using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class Usuarios
{
    public void insertarRestaurante(RESTAURANTE nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.RESTAURANTEs.Add(nuevo);
            db.SaveChanges();
        }
    }
    public void insertarPago(PAGO nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.PAGOs.Add(nuevo);
            db.SaveChanges();
        }
    }
    public void eliminarUsuario(USUARIO nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.USUARIOs.Attach(nuevo);
            db.USUARIOs.Remove(nuevo);
            db.SaveChanges();
        }
    }
    public void eliminarTipo(TIPO nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.TIPOs.Attach(nuevo);
            db.TIPOs.Remove(nuevo);
            db.SaveChanges();
        }
    }
    public void eliminarRol(ROL nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.ROLs.Attach(nuevo);
            db.ROLs.Remove(nuevo);
            db.SaveChanges();
        }
    }
    public void eliminarRestaurante(RESTAURANTE nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.RESTAURANTEs.Attach(nuevo);
            db.RESTAURANTEs.Remove(nuevo);
            db.SaveChanges();
        }
    }
    public void eliminarMenu(MENU nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.MENUs.Attach(nuevo);
            db.MENUs.Remove(nuevo);
            db.SaveChanges();
        }
    }

    public void insertarTipoMenu(TIPO nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.TIPOs.Add(nuevo);
            db.SaveChanges();
        }
    }
    public void insertarAsistencia(ASISTENCIA nuevo)
    {
        using (var db = new WELFAREContext())
        {
            db.ASISTENCIAs.Add(nuevo);
            db.SaveChanges();
        }
    }
    public void insertarRusuario(token Rtoken)
    {
        using (var db = new WELFAREContext())
        {
            db.TOKENs.Add(Rtoken);
            db.SaveChanges();
        }
    }
    public USUARIO contraseña(string usuario)
    {
        using (var db = new WELFAREContext())
        {
            USUARIO eusuario = db.USUARIOs.Where(u => u.Usuario == usuario).FirstOrDefault();
            return eusuario;
        }
    }
    public token token_id_us(string token)
    {
        using (var db = new WELFAREContext())
        {
            token tk = db.TOKENs.Where(u => u.tactivo == token).FirstOrDefault();
            return tk;
        }
    }
    public USUARIO id_us_usuario(int id)
    {
        using (var db = new WELFAREContext())
        {
            USUARIO eusuario = db.USUARIOs.Where(u => u.Id_usuario == id).FirstOrDefault();
            return eusuario;
        }
    }
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

    //tipo menu
    public List<TIPO> datos_tipoMenu()
    {
        List<TIPO> usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.TIPOs.OrderBy(x => x.id_tipo).ToList();
        }
        return usuarios;
    }
    public List<ASISTENCIA> datos_Asistencia()
    {
        List<ASISTENCIA> usuarios;
        using (var db = new WELFAREContext())
        {
            usuarios = db.ASISTENCIAs.OrderBy(x => x.id_asistencia).ToList();
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
    public List<asistenciaMostrar> datos_AsistenciaUser(string id)
    {
        int id_usuario = int.Parse(id);
        int idRestaurante = 0;
        int idTipo = 0;
        List<ASISTENCIA> asistencias;
        List<asistenciaMostrar> final= new List<asistenciaMostrar>();
        using (var db = new WELFAREContext())
        {
            asistencias = db.ASISTENCIAs.Where(x=>x.id_usuario==id_usuario).OrderBy(x => x.id_asistencia).ToList();
        }
        foreach (ASISTENCIA asistencia in asistencias)
        {
            idRestaurante = asistencia.id_restaurante;
            idTipo = asistencia.id_tipo;
            RESTAURANTE restaurantes;
            using (var db = new WELFAREContext())
            {
                restaurantes = db.RESTAURANTEs.Where(x => x.Id_restaurante == idRestaurante).OrderBy(x => x.Id_restaurante).FirstOrDefault();
            }
            asistenciaMostrar nuevo = new asistenciaMostrar();
            TIPO tipo;
            using (var db = new WELFAREContext())
            {
                tipo = db.TIPOs.Where(x => x.id_tipo == idTipo).OrderBy(x => x.id_tipo).FirstOrDefault();
            }
            nuevo.nombreRestaurante = restaurantes.Nombre;
            nuevo.tipoAsistencia = tipo.descripcion;
            nuevo.fechaAsistencia = asistencia.fecha;
            final.Add(nuevo);
        }
        return final;
    }

    public List<pagosMostrar> datos_PagosUser(string id)
    {
        int id_usuario = int.Parse(id);
        List<PAGO> pagos;
        List<pagosMostrar> final = new List<pagosMostrar>();
        using (var db = new WELFAREContext())
        {
            pagos = db.PAGOs.Where(x => x.Id_estudiante == id_usuario).OrderBy(x => x.Id_pago).ToList();
        }
        foreach (PAGO pago in pagos)
        {
            pagosMostrar nuevo = new pagosMostrar();
            nuevo.fecha = pago.Fechas;
            nuevo.pagado = int.Parse(pago.Cantidad+"");
            nuevo.saldo = Decimal.Parse(pago.Saldo+"");
            final.Add(nuevo);
        }
        return final;
    }

    public List<menuMostrar> datos_MenuUser()
    {
        List<MENU> menus;
        List<menuMostrar> final = new List<menuMostrar>();
        using (var db = new WELFAREContext())
        {
            menus = db.MENUs.OrderBy(x => x.Id_menu).ToList();
        }
        foreach (MENU menu in menus)
        {
            menuMostrar nuevo = new menuMostrar();
            nuevo.fecha = menu.Dia;
            nuevo.menu = menu.Menu;
            TIPO tipo = new TIPO();
            using (var db = new WELFAREContext())
            {
                tipo = db.TIPOs.Where(x=> x.id_tipo==menu.id_Tipo).OrderBy(x => x.id_tipo).FirstOrDefault();
            }
            nuevo.tipo = tipo.descripcion;
            final.Add(nuevo);
        }
        return final;
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
    public void Ac_Pagos(PAGO pago)
    {
        using (var db = new WELFAREContext())
        {
            db.PAGOs.Attach(pago);
            var entry = db.Entry(pago);
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