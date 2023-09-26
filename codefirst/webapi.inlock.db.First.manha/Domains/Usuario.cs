using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.db.First.manha.Domains;
    public partial class Usuario
    {
    public Guid IdUsuario { get; set; }

    public Guid? IdTipoUsuario { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }
    }
