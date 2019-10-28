if(not exists(select 1 from sys.schemas (nolock) where name = 'Configuracion'))
	exec ('Create schema Configuracion');
go

if(not exists(select 1 from sys.schemas (nolock) where name = 'Administracion'))
	exec ('Create schema Administracion');
go

if(not exists(select 1 from sys.schemas (nolock) where name = 'Medico'))
	exec ('Create schema Medico');
go

if(not exists(select 1 from sys.schemas (nolock) where name = 'Paciente'))
	exec ('Create schema Paciente');
go

if(not exists(select 1 from sys.schemas (nolock) where name = 'Configuracion'))
	exec ('Create schema HistoriaClinica');
go

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
	if(exists (select 1 from sys.foreign_keys where name = 'fk_Persona_Medico'))
	begin
		alter table Medico.Medico drop constraint fk_Persona_Medico;
		print 'llave fk_Persona_Medico eliminada'
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
end;

declare @esquema varchar(50), @tabla varchar(50)

set @esquema = 'Configuracion'
set @tabla = 'Tipo'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Configuracion.Tipo ( -- {Sexo, Grupo sanguíneo, Tipo Teléfono, Familiar, Anticonceptivo, Sistema, Status, Tipo Ubicacion}
	Id INT IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL
);

set @esquema = 'Configuracion'
set @tabla = 'Catalogo'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Configuracion.Catalogo (
	Id INT IDENTITY PRIMARY KEY,
	IdTipo INT NOT NULL,
	Valor VARCHAR(100) NOT NULL
);

alter table Configuracion.Catalogo 
	add constraint fk_tipo_catalogo foreign key (IdTipo) 
	references Configuracion.Tipo(Id) on update no action on delete no action

set @esquema = 'Configuracion'
set @tabla = 'Ubicacion'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Configuracion.Ubicacion (
	Id INT IDENTITY PRIMARY KEY,
	Nombre VARCHAR(100) NOT NULL,
	Abreviatura VARCHAR(20) NOT NULL,
	Lada VARCHAR(20) NOT NULL
);

set @esquema = 'Administracion'
set @tabla = 'Persona'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
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

set @esquema = 'Administracion'
set @tabla = 'PersonaCatalogo'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Administracion.PersonaCatalogo (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdCatalogo INT NOT NULL -- {Sexo, Grupo Sanguíneo}
);

alter table Administracion.PersonaCatalogo 
	add constraint fk_catalogo_personacatalogo foreign key (IdCatalogo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;
alter table Administracion.PersonaCatalogo 
	add constraint fk_persona_personacatalogo foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;

set @esquema = 'Administracion'
set @tabla = 'PersonaLugares'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Administracion.PersonaLugares (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdTipo INT NOT NULL, -- {Tipo Ubicación}
	IdUbicacion INT NOT NULL,
	Fecha DATE
);

alter table Administracion.PersonaLugares 
	add constraint fk_Persona_PersonaLugares foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;
alter table Administracion.PersonaLugares 
	add constraint fk_Tipo_PersonaLugares foreign key (IdTipo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;
alter table Administracion.PersonaLugares 
	add constraint fk_Ubicacion_PersonaLugares foreign key (IdUbicacion) 
	references Configuracion.Ubicacion(Id) on update no action on delete no action;

set @esquema = 'Administracion'
set @tabla = 'PersonaTelefonos'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Administracion.PersonaTelefonos (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdTipo INT NOT NULL, -- {Tipo Teléfono}
	Numero VARCHAR(20) NOT NULL,
);

alter table Administracion.PersonaTelefonos 
	add constraint fk_Persona_PersonaTelefonos foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;
alter table Administracion.PersonaTelefonos 
	add constraint fk_Tipo_PersonaTelefonos foreign key (IdTipo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;

set @esquema = 'Paciente'
set @tabla = 'Paciente'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.Paciente (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
);

set @esquema = 'Medico'
set @tabla = 'Medico'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Medico.Medico (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
);

alter table Medico.Medico 
	add constraint fk_Persona_Medico foreign key (IdPersona) 
	references Administracion.Persona(Id) on update no action on delete no action;

set @esquema = 'Paciente'
set @tabla = 'Adicciones'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.Adicciones (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	Adiccion VARCHAR(100) NOT NULL,
);

alter table Paciente.Adicciones 
	add constraint fk_Paciente_Adicciones foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;

set @esquema = 'Paciente'
set @tabla = 'Alergias'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.Alergias (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	Alergia VARCHAR(100) NOT NULL
);

alter table Paciente.Alergias 
	add constraint fk_Paciente_Alergias foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;

set @esquema = 'Paciente'
set @tabla = 'AntecedentesHereditarios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.AntecedentesHereditarios (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	IdCatalogo INT NOT NULL, -- {Familiar}
	Padecimiento VARCHAR(100) NOT NULL
);

alter table Paciente.AntecedentesHereditarios 
	add constraint fk_Paciente_AntecedentesHereditarios foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;
alter table Paciente.AntecedentesHereditarios 
	add constraint fk_Catalogo_AntecedentesHereditarios foreign key (IdCatalogo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;

set @esquema = 'Paciente'
set @tabla = 'AntecedentesPersonalesPatológicos'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.AntecedentesPersonalesPatológicos (
	Id INT IDENTITY PRIMARY KEY,
	IdPaciente INT NOT NULL,
	Enfermedad VARCHAR(100) NOT NULL,
	Inicio DATE NOT NULL,
	IdCatalogo INT NOT NULL, -- {status}
);

alter table Paciente.AntecedentesPersonalesPatológicos 
	add constraint fk_Paciente_AntecedentesPersonalesPatológicos foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;
alter table Paciente.AntecedentesPersonalesPatológicos 
	add constraint fk_Catalogo_AntecedentesPersonalesPatológicos foreign key (IdCatalogo) 
	references Configuracion.Catalogo(Id) on update no action on delete no action;

set @esquema = 'Paciente'
set @tabla = 'AntecedentesGinecoObstetricios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.AntecedentesGinecoObstetricios ( -- {0...1}
	IdPaciente INT NOT NULL,
	Menarca DATE,
	G TINYINT DEFAULT 0 NOT NULL,
	P TINYINT DEFAULT 0 NOT NULL,
	C TINYINT DEFAULT 0 NOT NULL,
	A TINYINT DEFAULT 0 NOT NULL
);

alter table Paciente.AntecedentesGinecoObstetricios 
	add constraint fk_Paciente_AntecedentesGinecoObstetricios foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;

set @esquema = 'HistoriaClinica'
set @tabla = 'HistoriaClinica'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
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

alter table HistoriaClinica.HistoriaClinica 
	add constraint fk_Paciente_HistoriaClinica foreign key (IdPaciente) 
	references Paciente.Paciente(Id) on update no action on delete no action;
alter table HistoriaClinica.HistoriaClinica 
	add constraint fk_Medico_HistoriaClinica foreign key (IdMedico) 
	references Medico.Medico(Id) on update no action on delete no action;

--set @esquema = 'HistoriaClinica'
--set @tabla = 'AntecedentesGinecoObstetricios'
--if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
--	exec('DROP TABLE ' + @esquema + '.' + @tabla)
--Create table HistoriaClinica.AntecedentesGinecoObstetricios ( -- {0...1}
--	Id INT IDENTITY PRIMARY KEY,
--	IdHistoria INT NOT NULL,
--	FUR DATE,
--	Papanicolaou DATE,
--	Mastografia DATE,
--	IdCatalogo INT NOT NULL -- {Método anticonceptivo}
--);

--set @esquema = 'HistoriaClinica'
--set @tabla = 'MedicacionActual'
--if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
--	exec('DROP TABLE ' + @esquema + '.' + @tabla)
--Create table HistoriaClinica.MedicacionActual ( -- {0...n}
--	Id INT IDENTITY PRIMARY KEY,
--	IdHistoria INT NOT NULL,
--	Medicamento VARCHAR(100) NOT NULL,
--	Dosis VARCHAR(100) NOT NULL,
--	Inicio DATE
--);

--set @esquema = 'HistoriaClinica'
--set @tabla = 'InterrogatorioAparatosSistemas'
--if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
--	exec('DROP TABLE ' + @esquema + '.' + @tabla)
--Create table HistoriaClinica.InterrogatorioAparatosSistemas ( -- {0...n}
--	IdHistoria INT NOT NULL,
--	IdCatalogo INT NOT NULL, -- {Sistema}
--	Descripcion TEXT NOT NULL
--);
--set @esquema = 'HistoriaClinica'
--set @tabla = 'ExploracionFisica'
--if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
--	exec('DROP TABLE ' + @esquema + '.' + @tabla)
--Create table HistoriaClinica.ExploracionFisica (
--	IdHistoria INT NOT NULL,
--	TA VARCHAR(100) NOT NULL,
--	Pulso INT,
--	FR INT,
--	FC INT,
--	Temp decimal(6,2),
--	Estatura INT, -- cm.
--	Peso Decimal(6,2),
--	Texto TEXT
--);

