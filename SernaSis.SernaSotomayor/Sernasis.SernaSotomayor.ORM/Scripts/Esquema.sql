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

if(exists (select 1 from sys.foreign_keys where name = 'fk_tipo_catalogo'))
begin
	alter table Configuracion.Catalogo drop constraint fk_tipo_catalogo;
	print 'llave eliminada'
end;
if(exists (select 1 from sys.foreign_keys where name = 'fk_catalogo_personacatalogo'))
begin
	alter table Administracion.PersonaCatalogo drop constraint fk_catalogo_personacatalogo;
	print 'llave eliminada'
end;
if(exists (select 1 from sys.foreign_keys where name = 'fk_persona_personacatalogo'))
begin
	alter table Administracion.PersonaCatalogo drop constraint fk_persona_personacatalogo;
	print 'llave eliminada'
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
	IdPersona INT NOT NULL,
	IdTipo INT NOT NULL, -- {Tipo Ubicación}
	IdUbicacion INT NOT NULL,
	Fecha DATE
);

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

set @esquema = 'Administracion'
set @tabla = 'Adicciones'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Administracion.Adicciones (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	Adicción VARCHAR(100) NOT NULL,
);

set @esquema = 'Administracion'
set @tabla = 'Alergias'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Administracion.Alergias (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	Alergia VARCHAR(100) NOT NULL
);

set @esquema = 'Paciente'
set @tabla = 'AntecedentesHereditarios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.AntecedentesHereditarios (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	IdCatalogo INT NOT NULL, -- {Familiar}
	Padecimiento VARCHAR(100) NOT NULL
);

set @esquema = 'Paciente'
set @tabla = 'AntecedentesPersonalesPatológicos'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.AntecedentesPersonalesPatológicos (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
	Enfermedad VARCHAR(100) NOT NULL,
	Inicio DATE NOT NULL,
	IdCatalogo INT NOT NULL, -- {status}
);

set @esquema = 'Paciente'
set @tabla = 'AntecedentesGinecoObstetricios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.AntecedentesGinecoObstetricios ( -- {0...1}
	IdPersona INT NOT NULL,
	Menarca DATE,
	G TINYINT DEFAULT 0 NOT NULL,
	P TINYINT DEFAULT 0 NOT NULL,
	C TINYINT DEFAULT 0 NOT NULL,
	A TINYINT DEFAULT 0 NOT NULL
);

set @esquema = 'Paciente'
set @tabla = 'Paciente'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table Paciente.Paciente (
	Id INT IDENTITY PRIMARY KEY,
	IdPersona INT NOT NULL,
);

set @esquema = 'HistoriaClinica'
set @tabla = 'HistoriaClinica'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table HistoriaClinica.HistoriaClinica (
	Id INT IDENTITY PRIMARY KEY,
	IdMédico INT NOT NULL,
	Fecha DATE NOT NULL DEFAULT GETDATE(),
	Tabaquitico BIT NOT NULL DEFAULT 0,
	Alcoholico BIT NOT NULL DEFAULT 0,
	PadecimientoActual TEXT NOT NULL,
	Analisis TEXT NOT NULL,
	ImpresionDiagnostica TEXT NOT NULL,
	PlanTerapeutico TEXT NOT NULL
);

set @esquema = 'HistoriaClinica'
set @tabla = 'AntecedentesGinecoObstetricios'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table HistoriaClinica.AntecedentesGinecoObstetricios ( -- {0...1}
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	FUR DATE,
	Papanicolaou DATE,
	Mastografia DATE,
	IdCatalogo INT NOT NULL -- {Método anticonceptivo}
);

set @esquema = 'HistoriaClinica'
set @tabla = 'MedicacionActual'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table HistoriaClinica.MedicacionActual ( -- {0...n}
	Id INT IDENTITY PRIMARY KEY,
	IdHistoria INT NOT NULL,
	Medicamento VARCHAR(100) NOT NULL,
	Dosis VARCHAR(100) NOT NULL,
	Inicio DATE
);

set @esquema = 'HistoriaClinica'
set @tabla = 'InterrogatorioAparatosSistemas'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table HistoriaClinica.InterrogatorioAparatosSistemas ( -- {0...n}
	IdHistoria INT NOT NULL,
	IdCatalogo INT NOT NULL, -- {Sistema}
	Descripcion TEXT NOT NULL
);
set @esquema = 'HistoriaClinica'
set @tabla = 'ExploracionFisica'
if(exists(select 1 from sys.schemas s (nolock) join sys.objects o (nolock) on s.[schema_id] = o.[schema_id] where s.name = @esquema and o.name = @tabla))
	exec('DROP TABLE ' + @esquema + '.' + @tabla)
Create table HistoriaClinica.ExploracionFisica (
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

