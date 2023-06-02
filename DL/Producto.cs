﻿using System;
using System.Collections.Generic;

namespace DL;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? IdDepartamento { get; set; }

    public DateTime? FechaIngredo { get; set; }

    public string? CodigoBarras { get; set; }

    public byte[]? Imagen { get; set; }

    public string? Modelo { get; set; }

    public int? IdMarca { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdUsuarioModificacion { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual Proveedor? IdProveedorNavigation { get; set; }

    public virtual Usuario? IdUsuarioModificacionNavigation { get; set; }

    public virtual ICollection<ProductoInventario> ProductoInventarios { get; set; } = new List<ProductoInventario>();
}
