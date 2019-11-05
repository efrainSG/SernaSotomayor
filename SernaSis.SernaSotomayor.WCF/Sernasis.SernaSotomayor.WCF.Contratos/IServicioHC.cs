using SernaSIs.SernaSotomayor.WCF.Contract.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IServicioHC {

    #region Servicios de configuración
    TipoResponse guardaTipo(TipoRequest request);
    CatalogoResponse guardaCatalogo(CatalogoRequest request);
    UbicacionResponse guardaUbicacion(UbicacionRequest request);
    RolResponse guardaRol(RolRequest request);
    UsuarioResponse guardaUsuario(UsuarioRequest request);
    SelTiposResponse selTipos(SelTiposRequest request);
    SelCatalogosResponse selCatalogos(SelCatalogosRequest request);
    SelUbicacionesResponse selUbicaciones(SelUbicacionesRequest request);
    SelRolesResponse selRoles(SelRolesRequest request);
    SelUsuariosResponse selUsuarios(SelUsuariosRequest request);
    TipoResponse delTipo(TipoRequest request);
    CatalogoResponse delCatalogo(CatalogoRequest request);
    UbicacionResponse delUbicacion(UbicacionRequest request);
    RolResponse delRol(RolRequest request);
    UsuarioResponse delUsuario(UsuarioRequest request);
    #endregion

    #region Servicios de operación
    PacienteResponse guardaPaciente(PacienteRequest request);
    PersonaResponse guardaPersona(PersonaRequest request);
    MedicoResponse guardaMedico(MedicoRequest request);
    HistoriaResponse guardaHistoria(HistoriaRequest request);
    NotaEvolutivaResponse guardaNotaEvolutiva(NotaEvolutivaRequest request);
    SelPacientesResponse selPacientes(SelPacientesRequest request);
    SelPersonasResponse selPersonas(SelPersonasRequest request);
    SelMedicosResponse selMedicos(SelMedicosRequest request);
    SelHistoriasResponse selHistoria(SelHistoriasRequest request);
    SelNotasEvolutivasResponse selNotaEvolutiva(SelNotasEvolutivasRequest request);
    PacienteResponse delPaciente(PacienteRequest request);
    PersonaResponse delPersona(PersonaRequest request);
    MedicoResponse delMedico(MedicoRequest request);
    HistoriaResponse delHistoria(HistoriaRequest request);
    NotaEvolutivaResponse delNotaEvolutiva(NotaEvolutivaRequest request);
    #endregion


}

