﻿using System;
using System.Collections.Generic;

namespace PruebaTrabajo.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string? NombreDepartamento { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
