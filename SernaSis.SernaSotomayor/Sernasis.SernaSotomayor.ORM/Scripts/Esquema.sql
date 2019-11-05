-- Esquemas
begin
	if(not exists(select 1 from sys.schemas (nolock) where name = 'Configuracion'))
		exec ('Create schema Configuracion');

	if(not exists(select 1 from sys.schemas (nolock) where name = 'Administracion'))
		exec ('Create schema Administracion');

	if(not exists(select 1 from sys.schemas (nolock) where name = 'Medico'))
		exec ('Create schema Medico');

	if(not exists(select 1 from sys.schemas (nolock) where name = 'Paciente'))
		exec ('Create schema Paciente');

	if(not exists(select 1 from sys.schemas (nolock) where name = 'Configuracion'))
		exec ('Create schema HistoriaClinica');

	if(not exists(select 1 from sys.schemas (nolock) where name = 'Seguridad'))
		exec ('Create schema Seguridad');
end

-- Quitar llaves
begin
	if(exists (select 1 from sys.foreign_keys where name = 'fk_tipo_catalogo'))
	begin
		alter table Configuracion.Catalogo drop constraint fk_tipo_catalogo;
		print 'llave fk_tipo_catalogo eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_catalogo_personacatalogo'))
	begin
		alter table Administracion.PersonaCatalogo drop constraint fk_catalogo_personacatalogo;
		print 'llave fk_catalogo_personacatalogo eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_persona_personacatalogo'))
	begin
		alter table Administracion.PersonaCatalogo drop constraint fk_persona_personacatalogo;
		print 'llave fk_persona_personacatalogo eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Persona_PersonaLugares'))
	begin
		alter table Administracion.PersonaLugares drop constraint fk_Persona_PersonaLugares;
		print 'llave fk_Persona_PersonaLugares eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Tipo_PersonaLugares'))
	begin
		alter table Administracion.PersonaLugares drop constraint fk_Tipo_PersonaLugares;
		print 'llave fk_Tipo_PersonaLugares eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Ubicacion_PersonaLugares'))
	begin
		alter table Administracion.PersonaLugares drop constraint fk_Ubicacion_PersonaLugares;
		print 'llave fk_Ubicacion_PersonaLugares eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Persona_PersonaTelefonos'))
	begin
		alter table Administracion.PersonaTelefonos drop constraint fk_Persona_PersonaTelefonos;
		print 'llave fk_Persona_PersonaTelefonos eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Tipo_PersonaTelefonos'))
	begin
		alter table Administracion.PersonaTelefonos drop constraint fk_Tipo_PersonaTelefonos;
		print 'llave fk_Tipo_PersonaTelefonos eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Persona_Paciente'))
	begin
		alter table Paciente.Paciente drop constraint fk_Persona_Paciente;
		print 'llave fk_Persona_Paciente eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Rol_Usuario'))
	begin
		alter table Seguridad.Usuario drop constraint fk_Rol_Usuario;
		print 'llave fk_Rol_Usuario eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_persona_usuario'))
	begin
		alter table Seguridad.Usuario drop constraint fk_persona_usuario;
		print 'llave fk_persona_usuario eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Persona_Medico'))
	begin
		alter table Medico.Medico drop constraint fk_Persona_Medico;
		print 'llave fk_Persona_Medico eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Medico_MedicoEspecialidad'))
	begin
		alter table Medico.MedicoEspecialidad drop constraint fk_Medico_MedicoEspecialidad;
		print 'llave fk_Medico_MedicoEspecialidad eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Catalogo_MedicoEspecialidad'))
	begin
		alter table Medico.MedicoEspecialidad drop constraint fk_Catalogo_MedicoEspecialidad;
		print 'llave fk_Catalogo_MedicoEspecialidad eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Paciente_Adicciones'))
	begin
		alter table Paciente.Adicciones drop constraint fk_Paciente_Adicciones;
		print 'llave fk_Paciente_Adicciones eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Paciente_Alergias'))
	begin
		alter table Paciente.Alergias drop constraint fk_Paciente_Alergias;
		print 'llave fk_Paciente_Alergias eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Paciente_AntecedentesHereditarios'))
	begin
		alter table Paciente.AntecedentesHereditarios drop constraint fk_Paciente_AntecedentesHereditarios;
		print 'llave fk_Paciente_AntecedentesHereditarios eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Catalogo_AntecedentesHereditarios'))
	begin
		alter table Paciente.AntecedentesHereditarios drop constraint fk_Catalogo_AntecedentesHereditarios;
		print 'llave fk_Catalogo_AntecedentesHereditarios eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Paciente_AntecedentesPersonalesPatológicos'))
	begin
		alter table Paciente.AntecedentesPersonalesPatológicos drop constraint fk_Paciente_AntecedentesPersonalesPatológicos;
		print 'llave fk_Paciente_AntecedentesPersonalesPatológicos eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Catalogo_AntecedentesPersonalesPatológicos'))
	begin
		alter table Paciente.AntecedentesPersonalesPatológicos drop constraint fk_Catalogo_AntecedentesPersonalesPatológicos;
		print 'llave fk_Catalogo_AntecedentesPersonalesPatológicos eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Paciente_AntecedentesGinecoObstetricios'))
	begin
		alter table Paciente.AntecedentesGinecoObstetricios drop constraint fk_Paciente_AntecedentesGinecoObstetricios;
		print 'llave fk_Paciente_AntecedentesGinecoObstetricios eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Paciente_HistoriaClinica'))
	begin
		alter table HistoriaClinica.HistoriaClinica drop constraint fk_Paciente_HistoriaClinica;
		print 'llave fk_Paciente_HistoriaClinica eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Medico_HistoriaClinica'))
	begin
		alter table HistoriaClinica.HistoriaClinica drop constraint fk_Medico_HistoriaClinica;
		print 'llave fk_Medico_HistoriaClinica eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Historia_AntecedentesGinecoObstetricios'))
	begin
		alter table HistoriaClinica.AntecedentesGinecoObstetricios drop constraint fk_HistoriaClinica_AntecedentesGinecoObstetricios;
		print 'llave fk_HistoriaClinica_AntecedentesGinecoObstetricios eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_HistoriaClinica_MedicacionActual'))
	begin
		alter table HistoriaClinica.MedicacionActual drop constraint fk_HistoriaClinica_MedicacionActual;
		print 'llave fk_HistoriaClinica_MedicacionActual eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_HistoriaClinica_InterrogatorioAparatosSistemas'))
	begin
		alter table HistoriaClinica.InterrogatorioAparatosSistemas drop constraint fk_HistoriaClinica_InterrogatorioAparatosSistemas;
		print 'llave fk_HistoriaClinica_InterrogatorioAparatosSistemas eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Catalogo_InterrogatorioAparatosSistemas'))
	begin
		alter table HistoriaClinica.InterrogatorioAparatosSistemas drop constraint fk_Catalogo_InterrogatorioAparatosSistemas;
		print 'llave fk_Catalogo_InterrogatorioAparatosSistemas eliminada'
	end;
	if(exists (select 1 from sys.foreign_keys where name = 'fk_HistoriaClinica_NotaEvolutiva'))
	begin
		alter table HistoriaClinica.NotaEvolutiva drop constraint fk_HistoriaClinica_NotaEvolutiva;
		print 'llave fk_HistoriaClinica_NotaEvolutiva eliminada'
	end;
end;

-- Quitar tablas
begin
declare @esquema varchar(50), @tabla varchar(50)

set @esquema = 'Configuracion'
set @tabla = 'tipo'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('drop table ' + @esquema + '.' + @tabla)

set @tabla = 'Catalogo'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'Ubicacion'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @esquema = 'Administracion'
set @tabla = 'Persona'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'PersonaCatalogo'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'PersonaLugares'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'PersonaTelefonos'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @esquema = 'Seguridad'
set @tabla = 'Rol'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'Usuario'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @esquema = 'Medico'
set @tabla = 'Medico'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'MedicoEspecialidad'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @esquema = 'Paciente'
set @tabla = 'Paciente'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'Adicciones'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'Alergias'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'AntecedentesHereditarios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'AntecedentesPersonalesPatológicos'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'AntecedentesGinecoObstetricios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @esquema = 'HistoriaClinica'
set @tabla = 'HistoriaClinica'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'AntecedentesGinecoObstetricios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'MedicacionActual'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'InterrogatorioAparatosSistemas'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)

set @tabla = 'ExploracionFisica'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
set @tabla = 'NotaEvolutiva'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
end;

 -- Agregar tablas
begin
Create table Configuracion.Tipo ( -- {Sexo, Grupo sanguíneo, Tipo Teléfono, Familiar, Anticonceptivo, Sistema, Status, Tipo Ubicacion}
	Id INT IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL
);
Create table Configuracion.Catalogo (
	Id INT IDENTITY PRIMARY KEY,
	IdTipo INT NOT NULL,
	Valor VARCHAR(100) NOT NULL
);
Create table Configuracion.Ubicacion (
	Id INT IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Abreviatura VARCHAR(20) NOT NULL,
	Lada VARCHAR(20) NOT NULL
);
Create table Administracion.Persona (
	Id INT IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Domicilio VARCHAR(200) NOT NULL,
	Rh CHAR(3) NOT NULL,
	Edad INT,
	Email VARCHAR(100) NOT NULL,
	Ocupación VARCHAR(100) NOT NULL,
	Nacimiento DATE NOT NULL
);
Create table Administracion.PersonaCatalogo (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdCatalogo INT NOT NULL -- {Sexo, Grupo Sanguíneo}
);
Create table Administracion.PersonaLugares (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdTipo INT NOT NULL, -- {Tipo Ubicación}
	IdUbicacion INT NOT NULL,
	Fecha DATE
);
Create table Administracion.PersonaTelefonos (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdTipo INT NOT NULL, -- {Tipo Teléfono}
	Numero VARCHAR(20) NOT NULL,
);
Create table Seguridad.Rol(
	Id INT IDENTITY PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL
);
Create table Seguridad.Usuario(
	IdUsr UNIQUEIDENTIFIER PRIMARY KEY,
	Usuario varchar(50) not null,
	Pass varchar(200) not null,
	IdRol INT NOT NULL,
	IdPersona INT NOT NULL
);
Create table Medico.Medico (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
);
Create table Medico.MedicoEspecialidad(
	Id INT IDENTITY PRIMARY KEY,
	IdMedico INT NOT NULL,
	Cedula VARCHAR(50) NOT NULL,
	IdEspecialidad INT NOT NULL -- {Catalogo}
);
Create table Paciente.Paciente (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
);
Create table Paciente.Adicciones (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	Adiccion VARCHAR(100) NOT NULL,
);
Create table Paciente.Alergias (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	Alergia VARCHAR(100) NOT NULL
);
Create table Paciente.AntecedentesHereditarios (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	IdCatalogo INT NOT NULL, -- {Familiar}
	Padecimiento VARCHAR(100) NOT NULL
);
Create table Paciente.AntecedentesPersonalesPatológicos (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	Enfermedad VARCHAR(100) NOT NULL,
	Inicio DATE NOT NULL,
	IdCatalogo INT NOT NULL, -- {status}
);
Create table Paciente.AntecedentesGinecoObstetricios ( -- {0...1}
	IdPaciente INT NOT NULL,
	Menarca DATE,
	G TINYINT DEFAULT 0 NOT NULL,
	P TINYINT DEFAULT 0 NOT NULL,
	C TINYINT DEFAULT 0 NOT NULL,
	A TINYINT DEFAULT 0 NOT NULL
);
Create table HistoriaClinica.HistoriaClinica (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	IdMedico INT NOT NULL,
	Fecha DATE NOT NULL DEFAULT GETDATE(),
	Tabaquitico BIT NOT NULL DEFAULT 0,
	Alcoholico BIT NOT NULL DEFAULT 0,
	PadecimientoActual TEXT NOT NULL,
	Analisis TEXT NOT NULL,
	ImpresionDiagnostica TEXT NOT NULL,
	PlanTerapeutico TEXT NOT NULL
);
Create table HistoriaClinica.AntecedentesGinecoObstetricios ( -- {0...1}
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	FUR DATE,
	Papanicolaou DATE,
	Mastografia DATE,
	IdCatalogo INT NOT NULL -- {Método anticonceptivo}
);
Create table HistoriaClinica.MedicacionActual ( -- {0...n}
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	Medicamento VARCHAR(100) NOT NULL,
	Dosis VARCHAR(100) NOT NULL,
	Inicio DATE
);
Create table HistoriaClinica.InterrogatorioAparatosSistemas ( -- {0...n}
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	IdCatalogo INT NOT NULL, -- {Sistema}
	Descripcion TEXT NOT NULL
);
Create table HistoriaClinica.ExploracionFisica (
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	TA VARCHAR(100) NOT NULL,
	Pulso INT,
	FR INT,
	FC INT,
	Temp decimal(6,2),
	Estatura INT, -- cm.
	Peso Decimal(6,2),
	Texto TEXT
);
Create table HistoriaClinica.NotaEvolutiva (
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	Texto TEXT NOT NULL
);
end;

-- Agregar llaves
begin
alter table Configuracion.Catalogo 
	add constraint fk_tipo_catalogo foreign key (IdTipo) 
	references Configuracion.Tipo(Id) on update no action on delete no action;

alter table Administracion.PersonaCatalogo 
	add constraint fk_catalogo_personacatalogo foreign key (IdCatalogo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action,
	constraint fk_persona_personacatalogo foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;

alter table Administracion.PersonaLugares 
	add constraint fk_Persona_PersonaLugares foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action,
	constraint fk_Tipo_PersonaLugares foreign key (IdTipo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action,
	constraint fk_Ubicacion_PersonaLugares foreign key (IdUbicacion) 
	references Configuracion.Ubicacion(Id) on update no action on delete no action;

alter table Administracion.PersonaTelefonos 
	add constraint fk_Persona_PersonaTelefonos foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action,
	constraint fk_Tipo_PersonaTelefonos foreign key (IdTipo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;

alter table Seguridad.Usuario
	add constraint fk_Rol_Usuario foreign key (IdRol)
	references Seguridad.Rol(Id) on update no action on delete no action,
	constraint fk_persona_usuario foreign key (IdPersona)
	references Administracion.Persona(Id) on update no action on delete no action;

alter table Medico.Medico 
	add constraint fk_Persona_Medico foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;

alter table Medico.MedicoEspecialidad
	add constraint fk_Medico_MedicoEspecialidad foreign key(IdMedico)
	references Medico.Medico(Id) on update no action on delete no action,
	constraint fk_Catalogo_MedicoEspecialidad foreign key(IdEspecialidad)
	references Configuracion.Catalogo(Id) on update no action on delete no action;

alter table Paciente.Paciente 
	add constraint fk_Persona_Paciente foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;

alter table Paciente.Adicciones 
	add constraint fk_Paciente_Adicciones foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;

alter table Paciente.Alergias 
	add constraint fk_Paciente_Alergias foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;

alter table Paciente.AntecedentesHereditarios 
	add constraint fk_Paciente_AntecedentesHereditarios foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action,
	constraint fk_Catalogo_AntecedentesHereditarios foreign key (IdCatalogo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;

alter table Paciente.AntecedentesPersonalesPatológicos 
	add constraint fk_Paciente_AntecedentesPersonalesPatológicos foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action,
	constraint fk_Catalogo_AntecedentesPersonalesPatológicos foreign key (IdCatalogo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;

alter table Paciente.AntecedentesGinecoObstetricios 
	add constraint fk_Paciente_AntecedentesGinecoObstetricios foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;

alter table HistoriaClinica.HistoriaClinica 
	add constraint fk_Paciente_HistoriaClinica foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action,
	constraint fk_Medico_HistoriaClinica foreign key (IdMedico) 
	references Medico.Medico(Id) on update no action on delete no action;

alter table HistoriaClinica.AntecedentesGinecoObstetricios
	add constraint fk_HistoriaClinica_AntecedentesGinecoObstetricios foreign key (IdHistoria)
	references HistoriaClinica.HistoriaClinica(Id) on update no action on delete no action,
	constraint fk_Catalogo_AntecedentesGinecoObstetricios foreign key (IdCatalogo)
	references Configuracion.Catalogo(Id) on update no action on delete no action;

alter table HistoriaClinica.MedicacionActual
	add constraint fk_HistoriaClinica_MedicacionActual foreign key (idHistoria)
	references HistoriaClinica.HistoriaClinica(Id) on update no action on delete no action;

alter table HistoriaClinica.InterrogatorioAparatosSistemas
	add constraint fk_HistoriaClinica_InterrogatorioAparatosSistemas foreign key(IdHistoria)
	references HistoriaClinica.HistoriaClinica(Id) on update no action on delete no action,
	constraint fk_Catalogo_InterrogatorioAparatosSistemas foreign key(IdCatalogo)
	references Configuracion.Catalogo (Id) on update no action on delete no action;

alter table HistoriaClinica.ExploracionFisica 
	add constraint fk_HistoriaClinica_ExploracionFisica foreign key(IdHistoria)
	references HistoriaClinica.HistoriaClinica(Id) on update no action on delete no action;

alter table HistoriaClinica.NotaEvolutiva
	add constraint fk_HistoriaClinica_NotaEvolutiva foreign key (IdHistoria)
	references HistoriaClinica.HistoriaClinica(Id) on update no action on delete no action;
end;