using System;
using System.Collections.Generic;

namespace webapi.inlock.db.First.manha.Domains;

public partial class TipoUsuario
{
    public Guid IdTipoUsuario { get; set; }

    public string? Titulo { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
