using System;
using System.Collections.Generic;

namespace PruebaTrabajo.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public int? IdDepartamento { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateTime? FechaContratacion { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }


}
