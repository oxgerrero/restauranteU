using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("RESTAURANTE",Schema ="dbo")]
public class RESTAURANTE
{
    [Key]
    public int Id_restaurante { get; set; }
    [ForeignKey("MENU")]
    public int Id_menu { get; set; }
    public string Nombre { get; set; }
    [ForeignKey("USUARIO")]
    public int Id_usuario_estudiante { get; set; }
    public DateTime Fecha { get; set; }

    //tablas referenciadas
    public MENU MENU { get; set; }
    public USUARIO USUARIO { get; set; }
}