using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Pago", Schema = "dbo")]
public class PAGO
{
    [Key]
    public int Id_pago { get; set; }

    [ForeignKey("USUARIO")]
    public int Id_estudiante { get; set; }
    public DateTime Fechas { get; set; }
    public double Cantidad { get; set; }

    [ForeignKey("ESTADO")]
    public int Id_estado { get; set; }
    public String Saldo { get; set; }
    public string Concepto { get; set; }


    public USUARIO USUARIO { get; set; }

    public ESTADO ESTADO { get; set; }
}