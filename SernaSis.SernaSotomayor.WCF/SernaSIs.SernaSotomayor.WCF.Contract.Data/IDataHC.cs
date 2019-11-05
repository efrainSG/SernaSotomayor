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
        public override string ToString()
        {
            return string.Format("{0} - {1}", Id, Nombre);
        }

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
        public override string ToString()
        {
            return string.Format("{0} - {1} EN {2}", Id, Valor, Tipo.ToString());
        }
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
        public override string ToString()
        {
            return string.Format("{0} - {1}", Id, Nombre);
        }
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
        public string Lada { get; set; }
    }
    [DataContract]
    public class UbicacionResponse {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Lada { get; set; }
        public ErrorResponse Error { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} ({2} - {3})",Id, Nombre, Abreviatura, Lada);
        }
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
    public class AdiccionesRequest {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string Adiccion { get; set; }
    }
    [DataContract]
    public class AdiccionesResponse {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string Adiccion { get; set; }
        public ErrorResponse Error { get; set; }
        public AdiccionesResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelAdiccionesRequest {
        public AdiccionesRequest Adiccion { get; set; }
        public SelAdiccionesRequest()
        {
            Adiccion = new AdiccionesRequest();
        }
    }
    [DataContract]
    public class SelAdiccionesResponse {
        public List<AdiccionesResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelAdiccionesResponse()
        {
            Items = new List<AdiccionesResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class AlergiasRequest {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string Alergia { get; set; }
    }
    [DataContract]
    public class AlergiasResponse {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public string Alergia { get; set; }
        public ErrorResponse Error { get; set; }
        public AlergiasResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelAlergiasRequest {
        public AlergiasRequest Alergia { get; set; }
        public SelAlergiasRequest()
        {
            Alergia = new AlergiasRequest();
        }
    }
    [DataContract]
    public class SelAlergiasResponse {
        public List<AlergiasResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelAlergiasResponse()
        {
            Items = new List<AlergiasResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class AntecedentesGinecoObstetriciosPacienteRequest {
        public int IdPaciente { get; set; }
        public DateTime Menarca { get; set; }
        public byte Gesta { get; set; }
        public byte Parto { get; set; }
        public byte Cesarea { get; set; }
        public byte Aborto { get; set; }
    }
    [DataContract]
    public class AntecedentesGinecoObstetriciosPacienteResponse {
        public int IdPaciente { get; set; }
        public DateTime Menarca { get; set; }
        public byte Gesta { get; set; }
        public byte Parto { get; set; }
        public byte Cesarea { get; set; }
        public byte Aborto { get; set; }
        public ErrorResponse Error { get; set; }
        public AntecedentesGinecoObstetriciosPacienteResponse()
        {
            Error = new ErrorResponse();
        }

    }
    [DataContract]
    public class SelAntecedentesGinecoObstetriciosPacienteRequest {
        public AntecedentesGinecoObstetriciosPacienteRequest AntecedentesGinecoObstetricios { get; set; }
        public SelAntecedentesGinecoObstetriciosPacienteRequest()
        {
            AntecedentesGinecoObstetricios = new AntecedentesGinecoObstetriciosPacienteRequest();
        }
    }
    [DataContract]
    public class SelAntecedentesGinecoObstetriciosPacienteResponse {
        public List<AntecedentesGinecoObstetriciosPacienteResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelAntecedentesGinecoObstetriciosPacienteResponse()
        {
            Items = new List<AntecedentesGinecoObstetriciosPacienteResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class AntecedentesHereditariosRequest {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdCatalogo { get; set; }
        public string Padecimiento { get; set; }
    }
    [DataContract]
    public class AntecedentesHereditariosResponse {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdCatalogo { get; set; }
        public string Padecimiento { get; set; }
        public ErrorResponse Error { get; set; }
        public AntecedentesHereditariosResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelAntecedentesHereditariosRequest {
        public AntecedentesHereditariosRequest AntecedentesHereditarios { get; set; }
        public SelAntecedentesHereditariosRequest()
        {
            AntecedentesHereditarios = new AntecedentesHereditariosRequest();
        }
    }
    [DataContract]
    public class SelAntecedentesHereditariosResponse {
        public List<AntecedentesHereditariosResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelAntecedentesHereditariosResponse()
        {
            Items = new List<AntecedentesHereditariosResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class AntecedentesPersonalesPatologicosRequest {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdCatalogo { get; set; }
        public string Enfermedad { get; set; }
        public DateTime Inicio { get; set; }
    }
    [DataContract]
    public class AntecedentesPersonalesPatologicosResponse {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdCatalogo { get; set; }
        public string Enfermedad { get; set; }
        public DateTime Inicio { get; set; }
        public ErrorResponse Error { get; set; }
        public AntecedentesPersonalesPatologicosResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelAntecedentesPersonalesPatologicosRequest {
        public AntecedentesPersonalesPatologicosRequest AntecedentesPersonalesPatologicos { get; set; }
        public SelAntecedentesPersonalesPatologicosRequest()
        {
            AntecedentesPersonalesPatologicos = new AntecedentesPersonalesPatologicosRequest();
        }
    }
    [DataContract]
    public class SelAntecedentesPersonalesPatologicosResponse {
        public List<AntecedentesPersonalesPatologicosResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelAntecedentesPersonalesPatologicosResponse()
        {
            Items = new List<AntecedentesPersonalesPatologicosResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class PacienteRequest {
        public int Id { get; set; }
        public PersonaRequest Persona { get; set; }
        public AntecedentesGinecoObstetriciosPacienteRequest AntecedentesGinecoObstetricios { get; set; }
        public SelAntecedentesHereditariosRequest AntecedentesHereditarios { get; set; }
        public SelAntecedentesPersonalesPatologicosRequest AntecedentesPersonalesPatologicos { get; set; }
        public SelAdiccionesRequest Adicciones { get; set; }
        public SelAlergiasRequest Alergias { get; set; }
        public PacienteRequest()
        {
            Persona = new PersonaRequest();
            AntecedentesGinecoObstetricios = new AntecedentesGinecoObstetriciosPacienteRequest();
            AntecedentesHereditarios = new SelAntecedentesHereditariosRequest();
            AntecedentesPersonalesPatologicos = new SelAntecedentesPersonalesPatologicosRequest();
            Adicciones = new SelAdiccionesRequest();
            Alergias = new SelAlergiasRequest();
        }
    }
    [DataContract]
    public class PacienteResponse {
        public int Id { get; set; }
        public PersonaResponse Persona { get; set; }
        public AntecedentesGinecoObstetriciosPacienteResponse AntecedentesGinecoObstetricios { get; set; }
        public SelAntecedentesHereditariosResponse AntecedentesHereditarios { get; set; }
        public SelAntecedentesPersonalesPatologicosResponse AntecedentesPersonalesPatologicos { get; set; }
        public SelAdiccionesResponse Adicciones { get; set; }
        public SelAlergiasResponse Alergias { get; set; }
        public ErrorResponse Error { get; set; }
        public PacienteResponse()
        {
            Persona = new PersonaResponse();
            AntecedentesGinecoObstetricios = new AntecedentesGinecoObstetriciosPacienteResponse();
            AntecedentesHereditarios = new SelAntecedentesHereditariosResponse();
            AntecedentesPersonalesPatologicos = new SelAntecedentesPersonalesPatologicosResponse();
            Alergias = new SelAlergiasResponse();
            Adicciones = new SelAdiccionesResponse();
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
        public override string ToString()
        {
            return string.Format("{0} - {1} :: {2}\n\t{3}\n\t{4}",Id, Nombre, Email, Domicilio, Ocupacion);
        }
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
    public class AntecedentesGinecoObstetriciosRequest {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public DateTime FUR { get; set; }
        public DateTime Papanicolaou { get; set; }
        public DateTime Mastografia { get; set; }
        public int IdCatalogo { get; set; }
    }
    [DataContract]
    public class AntecedentesGinecoObstetriciosResponse {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public DateTime FUR { get; set; }
        public DateTime Papanicolaou { get; set; }
        public DateTime Mastografia { get; set; }
        public int IdCatalogo { get; set; }
        public ErrorResponse Error { get; set; }
        public AntecedentesGinecoObstetriciosResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelAntecedentesGinecoObstetriciosRequest {
        public AntecedentesGinecoObstetriciosRequest AntecedentesGinecoObstetricios { get; set; }
        public SelAntecedentesGinecoObstetriciosRequest()
        {
            AntecedentesGinecoObstetricios = new AntecedentesGinecoObstetriciosRequest();
        }
    }
    [DataContract]
    public class SelAntecedentesGinecoObstetriciosResponse {
        public List<AntecedentesGinecoObstetriciosResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelAntecedentesGinecoObstetriciosResponse()
        {
            Items = new List<AntecedentesGinecoObstetriciosResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class ExploracionFisicaRequest {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public string TA { get; set; }
        public int Pulso { get; set; }
        public int FR { get; set; }
        public int FC { get; set; }
        public decimal Tempertura { get; set; }
        public int Estatura { get; set; }
        public decimal Peso { get; set; }
        public string Texto { get; set; }
    }
    [DataContract]
    public class ExploracionFisicaResponse {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public string TA { get; set; }
        public int Pulso { get; set; }
        public int FR { get; set; }
        public int FC { get; set; }
        public decimal Tempertura { get; set; }
        public int Estatura { get; set; }
        public decimal Peso { get; set; }
        public string Texto { get; set; }
        public ErrorResponse Error { get; set; }
        public ExploracionFisicaResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelExploracionFisicaRequest {
        public ExploracionFisicaRequest ExploracionFisica { get; set; }
        public SelExploracionFisicaRequest()
        {
            ExploracionFisica = new ExploracionFisicaRequest();
        }
    }
    [DataContract]
    public class SelExploracionFisicaResponse {
        public List<ExploracionFisicaResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelExploracionFisicaResponse()
        {
            Items = new List<ExploracionFisicaResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class InterrogatorioAparatosSistemasRequest {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public int IdCatalogo { get; set; }
        public string Descripcion { get; set; }
    }
    [DataContract]
    public class InterrogatorioAparatosSistemasResponse {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public int IdCatalogo { get; set; }
        public string Descripcion { get; set; }
        public ErrorResponse Error { get; set; }
        public InterrogatorioAparatosSistemasResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelInterrogatorioAparatosSistemasRequest {
        public InterrogatorioAparatosSistemasRequest InterrogatorioAparatosSistemas { get; set; }
        public SelInterrogatorioAparatosSistemasRequest()
        {
            InterrogatorioAparatosSistemas = new InterrogatorioAparatosSistemasRequest();
        }
    }
    [DataContract]
    public class SelInterrogatorioAparatosSistemasResponse {
        public List<InterrogatorioAparatosSistemasResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelInterrogatorioAparatosSistemasResponse()
        {
            Items = new List<InterrogatorioAparatosSistemasResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class MedicacionActualRequest {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public DateTime Inicio { get; set; }
    }
    [DataContract]
    public class MedicacionActualResponse {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public string Medicamento { get; set; }
        public string Dosis { get; set; }
        public DateTime Inicio { get; set; }
        public ErrorResponse Error { get; set; }
        public MedicacionActualResponse()
        {
            Error = new ErrorResponse();
        }
    }
    [DataContract]
    public class SelMedicacionActualRequest {
        public MedicacionActualRequest MedicacionActual { get; set; }
        public SelMedicacionActualRequest()
        {
            MedicacionActual = new MedicacionActualRequest();
        }
    }
    [DataContract]
    public class SelMedicacionActualResponse {
        public List<MedicacionActualResponse> Items { get; set; }
        public ErrorResponse Error { get; set; }
        public SelMedicacionActualResponse()
        {
            Items = new List<MedicacionActualResponse>();
            Error = new ErrorResponse();
        }
    }

    [DataContract]
    public class HistoriaRequest {
        public int Id { get; set; }
        public PacienteRequest Paciente { get; set; }
        public AntecedentesGinecoObstetriciosRequest AntecedentesGinecoObstetricios { get; set; }
        public SelInterrogatorioAparatosSistemasRequest InterrogatorioAparatosSistemas { get; set; }
        public SelMedicacionActualRequest MedicacionActual { get; set; }
        public ExploracionFisicaRequest ExploracionFisica { get; set; }
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
            AntecedentesGinecoObstetricios = new AntecedentesGinecoObstetriciosRequest();
            InterrogatorioAparatosSistemas = new SelInterrogatorioAparatosSistemasRequest();
            MedicacionActual = new SelMedicacionActualRequest();
            ExploracionFisica = new ExploracionFisicaRequest();
        }
    }
    [DataContract]
    public class HistoriaResponse {
        public int Id { get; set; }
        public PacienteRequest Paciente { get; set; }
        public AntecedentesGinecoObstetriciosResponse AntecedentesGinecoObstetricios { get; set; }
        public SelInterrogatorioAparatosSistemasResponse InterrogatorioAparatosSistemas { get; set; }
        public SelMedicacionActualResponse MedicacionActual { get; set; }
        public ExploracionFisicaResponse ExploracionFisica { get; set; }
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
            AntecedentesGinecoObstetricios = new AntecedentesGinecoObstetriciosResponse();
            InterrogatorioAparatosSistemas = new SelInterrogatorioAparatosSistemasResponse();
            MedicacionActual = new SelMedicacionActualResponse();
            ExploracionFisica = new ExploracionFisicaResponse();
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
