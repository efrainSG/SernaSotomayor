using System;
using System.Data.Entity;
using System.Linq;
using Sernasis.SernaSotomayor.Assembler;
using Sernasis.SernaSotomayor.ORM;
using SernaSIs.SernaSotomayor.WCF.Contract.Data;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class ServicioHC : IServicioHC {
    #region Guardado de elementos
    public RolResponse guardaRol(RolRequest request)
    {
        var Contexto = new UMSernaSotomayorEntities();
        RolResponse response;
        var rol = Contexto.Rols.FirstOrDefault(r => r.Id.Equals(request.Id));
        if (rol == null)
            rol = Contexto.Rols.Add(Ensamblador.ToRol(request));
        else
            rol.Nombre = request.Nombre;
        try
        {
            Contexto.SaveChanges();
            response = new RolResponse { Id = rol.Id, Nombre = rol.Nombre };
        }
        catch (Exception ex)
        {
            response = new RolResponse { Id = rol.Id, Nombre = rol.Nombre };
            response.Error.ErrNum = ex.HResult;
            response.Error.ErrMensaje = ex.Message;
        }
        return response;
    }

    public TipoResponse guardaTipo(TipoRequest request)
    {
        var Contexto = new UMSernaSotomayorEntities();
        TipoResponse response;
        var tipo = Contexto.Tipoes.FirstOrDefault(t => t.Id.Equals(request.Id));
        if (tipo == null)
            tipo = Contexto.Tipoes.Add(Ensamblador.ToTipo(request));
        else
            tipo.Nombre = request.Nombre;
        try
        {
            Contexto.SaveChanges();
            response = new TipoResponse { Id = tipo.Id, Nombre = tipo.Nombre };
        }
        catch (Exception ex)
        {
            response = new TipoResponse { Id = tipo.Id, Nombre = tipo.Nombre };
            response.Error.ErrNum = ex.HResult;
            response.Error.ErrMensaje = ex.Message;
        }
        return response;
    }

    public CatalogoResponse guardaCatalogo(CatalogoRequest request)
    {
        var Contexto = new UMSernaSotomayorEntities();
        CatalogoResponse response;
        var catalogo = Contexto.Catalogoes.FirstOrDefault(c => c.Id.Equals(request.Id));
        var tipo = Contexto.Tipoes.FirstOrDefault(t => t.Id.Equals(request.Tipo.Id));
        if (catalogo == null)
            catalogo = Ensamblador.ToCatalogo(request);
        else
            catalogo.Valor = request.Valor;
        tipo.Catalogoes.Add(catalogo);
        try
        {
            Contexto.SaveChanges();
            response = new CatalogoResponse
            {
                Id = catalogo.Id,
                Valor = catalogo.Valor,
                Tipo = new TipoResponse
                {
                    Id = catalogo.IdTipo,
                    Nombre = catalogo.Tipo.Nombre
                }
            };

        }
        catch (Exception ex)
        {
            response = new CatalogoResponse
            {
                Id = catalogo.Id, Valor = catalogo.Valor,
                Tipo = new TipoResponse { Id = catalogo.Tipo.Id, Nombre = catalogo.Tipo.Nombre },
            };
            response.Error.ErrNum = ex.HResult;
            response.Error.ErrMensaje = ex.Message;
        }
        return response;
    }

    public UbicacionResponse guardaUbicacion(UbicacionRequest request)
    {
        var Contexto = new UMSernaSotomayorEntities();
        UbicacionResponse response;
        var ubicacion = Contexto.Ubicacions.FirstOrDefault(u => u.Id.Equals(request.Id));
        if (ubicacion == null)
            ubicacion = Contexto.Ubicacions.Add(Ensamblador.ToUbicacion(request));
        else
            ubicacion.Nombre = request.Nombre;
        try
        {
            Contexto.SaveChanges();
            response = new UbicacionResponse
            {
                Id = ubicacion.Id, Nombre = ubicacion.Nombre,
                Abreviatura = ubicacion.Abreviatura, Lada = ubicacion.Lada
            };
        }
        catch (Exception ex)
        {
            response = new UbicacionResponse
            {
                Id = ubicacion.Id, Nombre = ubicacion.Nombre,
                Lada = ubicacion.Lada, Abreviatura = ubicacion.Abreviatura
            };
            response.Error.ErrNum = ex.HResult;
            response.Error.ErrMensaje = ex.Message;
        }
        return response;
    }

    /// <summary>
    /// Solo está guardando los datos directos a la tabla de Personas.
    /// Faltan los datos asociados: Sexo, teléfonos, grupo sanguíneo, adicciones, alergias.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public PersonaResponse guardaPersona(PersonaRequest request)
    {
        var Contexto = new UMSernaSotomayorEntities();
        PersonaResponse response;
        var persona = Contexto.Personas.FirstOrDefault(p => p.Id.Equals(request.Id));
        if (persona == null)
        {
            persona = Contexto.Personas.Add(Ensamblador.ToPersona(request));
        }
        else
        {
            persona.Domicilio = request.Domicilio;
            persona.Edad = request.Edad;
            persona.Email = request.Email;
            persona.Nacimiento = request.Nacimiento;
            persona.Nombre = request.Nombre;
            persona.Ocupación = request.Ocupacion;
            persona.Rh = request.Rh;
        }
        try
        {
            Contexto.SaveChanges();
            response = new PersonaResponse
            {
                Domicilio = persona.Domicilio,
                Edad = persona.Edad.Value,
                Email = persona.Email,
                Id = persona.Id,
                Nacimiento = persona.Nacimiento,
                Nombre = persona.Nombre,
                Ocupacion = persona.Ocupación,
                Rh = persona.Rh
            };
        }
        catch (Exception ex)
        {
            response = new PersonaResponse
            {
                Domicilio = persona.Domicilio,
                Edad = persona.Edad.Value,
                Email = persona.Email,
                Id = persona.Id,
                Nacimiento = persona.Nacimiento,
                Nombre = persona.Nombre,
                Ocupacion = persona.Ocupación,
                Rh = persona.Rh
            };
            response.Error.ErrNum = ex.HResult;
            response.Error.ErrMensaje = ex.Message;

        }
        return response;
    }

    #endregion

    public CatalogoResponse delCatalogo(CatalogoRequest request)
    {
        throw new NotImplementedException();
    }

    public HistoriaResponse delHistoria(HistoriaRequest request)
    {
        throw new NotImplementedException();
    }

    public MedicoResponse delMedico(MedicoRequest request)
    {
        throw new NotImplementedException();
    }

    public NotaEvolutivaResponse delNotaEvolutiva(NotaEvolutivaRequest request)
    {
        throw new NotImplementedException();
    }

    public PacienteResponse delPaciente(PacienteRequest request)
    {
        throw new NotImplementedException();
    }

    public PersonaResponse delPersona(PersonaRequest request)
    {
        throw new NotImplementedException();
    }

    public RolResponse delRol(RolRequest request)
    {
        throw new NotImplementedException();
    }

    public TipoResponse delTipo(TipoRequest request)
    {
        throw new NotImplementedException();
    }

    public UbicacionResponse delUbicacion(UbicacionRequest request)
    {
        throw new NotImplementedException();
    }

    public UsuarioResponse delUsuario(UsuarioRequest request)
    {
        throw new NotImplementedException();
    }

    public HistoriaResponse guardaHistoria(HistoriaRequest request)
    {
        throw new NotImplementedException();
    }

    public MedicoResponse guardaMedico(MedicoRequest request)
    {
        throw new NotImplementedException();
    }

    public NotaEvolutivaResponse guardaNotaEvolutiva(NotaEvolutivaRequest request)
    {
        throw new NotImplementedException();
    }

    public PacienteResponse guardaPaciente(PacienteRequest request)
    {
        throw new NotImplementedException();
    }

    public UsuarioResponse guardaUsuario(UsuarioRequest request)
    {
        throw new NotImplementedException();
    }

    public SelCatalogosResponse selCatalogos(SelCatalogosRequest request)
    {
        throw new NotImplementedException();
    }

    public SelHistoriasResponse selHistoria(SelHistoriasRequest request)
    {
        throw new NotImplementedException();
    }

    public SelMedicosResponse selMedicos(SelMedicosRequest request)
    {
        throw new NotImplementedException();
    }

    public SelNotasEvolutivasResponse selNotaEvolutiva(SelNotasEvolutivasRequest request)
    {
        throw new NotImplementedException();
    }

    public SelPacientesResponse selPacientes(SelPacientesRequest request)
    {
        throw new NotImplementedException();
    }

    public SelPersonasResponse selPersonas(SelPersonasRequest request)
    {
        throw new NotImplementedException();
    }

    public SelRolesResponse selRoles(SelRolesRequest request)
    {
        throw new NotImplementedException();
    }

    public SelTiposResponse selTipos(SelTiposRequest request)
    {
        throw new NotImplementedException();
    }

    public SelUbicacionesResponse selUbicaciones(SelUbicacionesRequest request)
    {
        throw new NotImplementedException();
    }

    public SelUsuariosResponse selUsuarios(SelUsuariosRequest request)
    {
        throw new NotImplementedException();
    }
}
