using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("USUARIO",Schema="dbo")]
public class USUARIO
{
    [Key]
    public int Id_usuario { get; set; }
    [ForeignKey("ESTADO")]
    public int Id_estado { get; set; }
    [ForeignKey("ROL")]
    public int Id_rol { get; set; }
    public string Nombre { get; set; }
    public string Usuario { get; set; }
    public string Contraseña { get; set; }
    //tablas referenciadas
    public ROL ROL { get; set; }
    public ESTADO ESTADO { get; set; }

    //tablas donde existe referencia
    public ICollection<RESTAURANTE> RESTAURANTEs { get; set; }
    public ICollection<PAGO> PAGOs { get; set; }
}