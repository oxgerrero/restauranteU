using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("MENU",Schema ="dbo")]
public class MENU
{
    [Key]
    public int Id_menu { get; set; }
    public DateTime Dia { get; set; }
    public string Menu { get; set; }
    public int Tipo_menu { get; set; }

    public ICollection<RESTAURANTE> RESTAURANTEs { get; set; }
}