using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SernaSIs.SernaSotomayor.WCF.Contract.Data {
    [DataContract]
    public class ErrorResponse {
        public int ErrNum { get; set; }
        public string ErrMensaje { get; set; }
    }

    #region Datos de configuracion
    [DataContract]
    public class UsuarioRequest {
        public Guid IdUsr { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public PersonaRequest Persona { get; set; }
        public RolRequest Rol { get; set; }
        public UsuarioRequest()
        {
            Persona = new PersonaRequest();
            Rol = new RolRequest();
        }
    }
    [DataContract]
    public class UsuarioResponse {
        public Guid IdUsr { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public PersonaRequest Persona { get; set; }
        public RolRequest Rol { get; set; }
        public ErrorResponse Error { get; set; }
        public UsuarioResponse()
        {
            Persona = new PersonaRequest();
            Rol = new RolRequest();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelUsuariosRequest {
        public UsuarioRequest Usuario { get; set; }
        public SelUsuariosRequest()
        {
            Usuario = new UsuarioRequest();
        }
    }
    [DataContract]
    public class SelUsuariosResponse {
        public List<UsuarioResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelUsuariosResponse()
        {
            Items = new List<UsuarioResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class TipoRequest {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    [DataContract]
    public class TipoResponse {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ErrorResponse Error { get; set; }
        public TipoResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelTiposRequest {
        public TipoRequest Tipo { get; set; }
        public SelTiposRequest()
        {
            Tipo = new TipoRequest();
        }
    }
    [DataContract]
    public class SelTiposResponse {
        public List<TipoResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelTiposResponse()
        {
            Error = new ErrorResponse();
            Items = new List<TipoResponse>();
        }
    }

    [DataContract]
    public class CatalogoRequest {
        public int Id { get; set; }
        public string Valor { get; set; }
        public TipoRequest Tipo { get; set; }
        public CatalogoRequest()
        {
            Tipo = new TipoRequest();
        }
    }
    [DataContract]
    public class CatalogoResponse {
        public int Id { get; set; }
        public string Valor { get; set; }
        public TipoResponse Tipo { get; set; }
        public ErrorResponse Error { get; set; }
        public CatalogoResponse()
        {
            Tipo = new TipoResponse();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelCatalogosRequest {
        public CatalogoRequest Catalogo { get; set; }
        public SelCatalogosRequest()
        {
            Catalogo = new CatalogoRequest();
        }
    }
    [DataContract]
    public class SelCatalogosResponse {
        public List<CatalogoRequest> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelCatalogosResponse()
        {
            Error = new ErrorResponse();
            Items = new List<CatalogoRequest>();
        }
    }

    [DataContract]
    public class RolRequest {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    [DataContract]
    public class RolResponse {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ErrorResponse Error { get; set; }
        public RolResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelRolesRequest {
        public RolRequest Rol { get; set; }
        public SelRolesRequest()
        {
            Rol = new RolRequest();
        }
    }
    [DataContract]
    public class SelRolesResponse {
        public List<RolResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelRolesResponse()
        {
            Error = new ErrorResponse();
            Items = new List<RolResponse>();
        }
    }

    [DataContract]
    public class UbicacionRequest {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public int Lada { get; set; }
    }
    [DataContract]
    public class UbicacionResponse {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public int Lada { get; set; }
        public ErrorResponse Error { get; set; }
        public UbicacionResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelUbicacionesRequest {
        public UbicacionRequest Ubicacion { get; set; }
        public SelUbicacionesRequest()
        {
            Ubicacion = new UbicacionRequest();
        }
    }
    [DataContract]
    public class SelUbicacionesResponse {
        public List<UbicacionResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelUbicacionesResponse()
        {
            Error = new ErrorResponse();
            Items = new List<UbicacionResponse>();
        }
    }
    #endregion

    #region Datos de operación
    [DataContract]
    public class 

    [DataContract]
    public class PacienteRequest {
        public int Id { get; set; }
        public PersonaRequest Persona { get; set; }
        public PacienteRequest()
        {
            Persona = new PersonaRequest();
        }
    }
    [DataContract]
    public class PacienteResponse {
        public int Id { get; set; }
        public PersonaResponse Persona { get; set; }
        public ErrorResponse Error { get; set; }
        public PacienteResponse()
        {
            Persona = new PersonaResponse();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelPacientesRequest {
        public PacienteRequest Paciente { get; set; }
        public SelPacientesRequest()
        {
            Paciente = new PacienteRequest();
        }
    }
    [DataContract]
    public class SelPacientesResponse {
        public List<PacienteResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelPacientesResponse()
        {
            Items = new List<PacienteResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class PersonaCatalogoRequest {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdCatalogo { get; set; }
    }
    [DataContract]
    public class PersonaCatalogoResponse {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdCatalogo { get; set; }
        public ErrorResponse Error { get; set; }
        public PersonaCatalogoResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelPersonasCatalogosRequest {
        public PersonaCatalogoRequest PersonaCatalogo { get; set; }
        public SelPersonasCatalogosRequest()
        {
            PersonaCatalogo = new PersonaCatalogoRequest();
        }
    }
    [DataContract]
    public class SelPersonasCatalogosResponse {
        public ErrorResponse Error { get; set; }
        public List<PersonaCatalogoResponse> Items { get; set; }
        public SelPersonasCatalogosResponse()
        {
            Error = new ErrorResponse();
            Items = new List<PersonaCatalogoResponse>();
        }
    }

    [DataContract]
    public class PersonaLugaresRequest {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdTipo { get; set; }
        public int IdUbicacion { get; set; }
        public DateTime Fecha { get; set; }
    }
    [DataContract]
    public class PersonaLugaresResponse {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdTipo { get; set; }
        public int IdUbicacion { get; set; }
        public DateTime Fecha { get; set; }
        public ErrorResponse Error { get; set; }
        public PersonaLugaresResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelPersonasLugaresRequest {
        public PersonaLugaresRequest PersonaLugar { get; set; }
        public SelPersonasLugaresRequest()
        {
            PersonaLugar = new PersonaLugaresRequest();
        }
    }
    [DataContract]
    public class SelPersonasLugaresResponse {
        public List<PersonaLugaresResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelPersonasLugaresResponse()
        {
            Items = new List<PersonaLugaresResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class PersonaTelefonosRequest {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdTipo { get; set; }
        public string Numero { get; set; }
    }
    [DataContract]
    public class PersonaTelefonosResponse {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdTipo { get; set; }
        public string Numero { get; set; }
        public ErrorResponse Error { get; set; }
        public PersonaTelefonosResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelPersonasTelefonosRequest {
        public PersonaTelefonosRequest PersonaTelefonos { get; set; }
        public SelPersonasTelefonosRequest()
        {
            PersonaTelefonos = new PersonaTelefonosRequest();
        }
    }
    [DataContract]
    public class SelPersonasTelefonosResponse {
        public ErrorResponse Error { get; set; }
        public List<PersonaTelefonosResponse> Items { get; set; }
        public SelPersonasTelefonosResponse()
        {
            Error = new ErrorResponse();
            Items = new List<PersonaTelefonosResponse>();
        }
    }

    [DataContract]
    public class PersonaRequest {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Rh { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Ocupacion { get; set; }
        public DateTime Nacimiento { get; set; }
        public List<PersonaCatalogoRequest> PersonasCatalogos { get; set; }
        public List<PersonaTelefonosRequest> PersonasTelefonos { get; set; }
        public List<PersonaLugaresRequest> PersonasLugares { get; set; }
        public PersonaRequest()
        {
            PersonasCatalogos = new List<PersonaCatalogoRequest>();
            PersonasLugares = new List<PersonaLugaresRequest>();
            PersonasTelefonos = new List<PersonaTelefonosRequest>();
        }
    }
    [DataContract]
    public class PersonaResponse {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Rh { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Ocupacion { get; set; }
        public DateTime Nacimiento { get; set; }
        public List<PersonaCatalogoResponse> PersonasCatalogos { get; set; }
        public List<PersonaLugaresResponse> PersonasLugares { get; set; }
        public List<PersonaTelefonosResponse> PersonasTelefonos { get; set; }
        public ErrorResponse Error { get; set; }
        public PersonaResponse()
        {
            PersonasCatalogos = new List<PersonaCatalogoResponse>();
            PersonasLugares = new List<PersonaLugaresResponse>();
            PersonasTelefonos = new List<PersonaTelefonosResponse>();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelPersonasRequest {
        PersonaRequest Persona { get; set; }
        public SelPersonasRequest()
        {
            Persona = new PersonaRequest();
        }
    }
    [DataContract]
    public class SelPersonasResponse {
        public List<PersonaResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelPersonasResponse()
        {
            Error = new ErrorResponse();
            Items = new List<PersonaResponse>();
        }
    }

    [DataContract]
    public class MedicoEspecialidadRequest {
        public int Id { get; set; }
        public int IdMedico { get; set; }
        public string Cedula { get; set; }
        public int IdEspecialidad { get; set; }
    }
    [DataContract]
    public class MedicoEspecialidadResponse {
        public int Id { get; set; }
        public int IdMedico { get; set; }
        public string Cedula { get; set; }
        public int IdEspecialidad { get; set; }
    }
    [DataContract]
    public class SelMedicosEspecialidadesRequest {
        public MedicoEspecialidadRequest MedicoEspecialidad { get; set; }
        public SelMedicosEspecialidadesRequest()
        {
            MedicoEspecialidad = new MedicoEspecialidadRequest();
        }
    }
    [DataContract]
    public class SelMedicosEspecialidadesResponse {
        public List<MedicoEspecialidadResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelMedicosEspecialidadesResponse()
        {
            Error = new ErrorResponse();
            Items = new List<MedicoEspecialidadResponse>();
        }
    }

    [DataContract]
    public class MedicoRequest {
        public int Id { get; set; }
        public PersonaRequest Persona { get; set; }
        public MedicoEspecialidadRequest MedicoEspecialidad { get; set; }
        public MedicoRequest()
        {
            MedicoEspecialidad = new MedicoEspecialidadRequest();
            Persona = new PersonaRequest();
        }
    }
    [DataContract]
    public class MedicoResponse {
        public int Id { get; set; }
        public PersonaResponse Persona { get; set; }
        public MedicoEspecialidadRequest MedicoEspecialidad { get; set; }
        public ErrorResponse Error { get; set; }
        public MedicoResponse()
        {
            Persona = new PersonaResponse();
            MedicoEspecialidad = new MedicoEspecialidadRequest();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelMedicosRequest {
        public MedicoRequest Medico { get; set; }
        public SelMedicosRequest()
        {
            Medico = new MedicoRequest();
        }
    }
    [DataContract]
    public class SelMedicosResponse {
        public List<MedicoResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelMedicosResponse()
        {
            Items = new List<MedicoResponse>();
        }
    }

    [DataContract]
    public class HistoriaRequest {
        public int Id { get; set; }
        public PacienteRequest Paciente { get; set; }
        public MedicoRequest Medico { get; set; }
        public DateTime Fecha { get; set; }
        public bool Tabaquitico { get; set; }
        public bool Alcoholico { get; set; }
        public string PadecimientoActual { get; set; }
        public string Analisis { get; set; }
        public string ImpresionDiagnostica { get; set; }
        public string PlanTerapeutico { get; set; }
        public HistoriaRequest()
        {
            Paciente = new PacienteRequest();
            Medico = new MedicoRequest();
        }
    }
    [DataContract]
    public class HistoriaResponse {
        public int Id { get; set; }
        public PacienteRequest Paciente { get; set; }
        public MedicoRequest Medico { get; set; }
        public DateTime Fecha { get; set; }
        public bool Tabaquitico { get; set; }
        public bool Alcoholico { get; set; }
        public string PadecimientoActual { get; set; }
        public string Analisis { get; set; }
        public string ImpresionDiagnostica { get; set; }
        public string PlanTerapeutico { get; set; }
        public ErrorResponse Error { get; set; }
        public HistoriaResponse()
        {
            Paciente = new PacienteRequest();
            Medico = new MedicoRequest();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelHistoriasRequest {
        public int Id { get; set; }
        public PacienteRequest Paciente { get; set; }
        public MedicoRequest Medico { get; set; }
        public DateTime Fecha { get; set; }
        public bool Tabaquitico { get; set; }
        public bool Alcoholico { get; set; }
        public string PadecimientoActual { get; set; }
        public string Analisis { get; set; }
        public string ImpresionDiagnostica { get; set; }
        public string PlanTerapeutico { get; set; }
        public SelHistoriasRequest()
        {
            Paciente = new PacienteRequest();
            Medico = new MedicoRequest();
        }
    }
    [DataContract]
    public class SelHistoriasResponse {
        public List<HistoriaResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelHistoriasResponse()
        {
            Items = new List<HistoriaResponse>();
        }
    }

    [DataContract]
    public class NotaEvolutivaRequest {
        public int Id { get; set; }
        public HistoriaRequest HistoriaClinica { get; set; }
        public NotaEvolutivaRequest()
        {
            HistoriaClinica = new HistoriaRequest();
        }
    }
    [DataContract]
    public class NotaEvolutivaResponse {
        public int Id { get; set; }
        public HistoriaRequest HistoriaClinica { get; set; }
        public ErrorResponse Error { get; set; }
        public NotaEvolutivaResponse()
        {
            HistoriaClinica = new HistoriaRequest();
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelNotasEvolutivasRequest {
        public NotaEvolutivaRequest NotaEvolutiva { get; set; }
        public SelNotasEvolutivasRequest()
        {
            NotaEvolutiva = new NotaEvolutivaRequest();
        }
    }
    [DataContract]
    public class SelNotasEvolutivasResponse {
        public List<NotaEvolutivaResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelNotasEvolutivasResponse()
        {
            Error = new ErrorResponse();
            Items = new List<NotaEvolutivaResponse>();
        }
    }
    #endregion

}
