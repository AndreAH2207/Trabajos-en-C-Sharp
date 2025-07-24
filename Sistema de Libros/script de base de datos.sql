CREATE DATABASE SistemaDeBiblioteca
USE SistemaDeBiblioteca


-- Tabla Usuarios
CREATE TABLE Usuarios
(
  Id INT NOT NULL IDENTITY (1, 1),
  Contraseña VARCHAR(30) NULL,
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  Dni VARCHAR(20) NULL,
  Correo VARCHAR(100) NULL,
  Telefono VARCHAR(15) NULL,
  Pais VARCHAR(60) NOT NULL,
  Ciudad VARCHAR(70) NOT NULL,
  ZonaHoraria VARCHAR(10) NULL,

  -- Campos de auditoría  
  Activo BIT NOT NULL DEFAULT 1,
  Eliminado BIT NOT NULL DEFAULT 0,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id)
);

-- Tabla Administradores
CREATE TABLE Administradores
(
  Id INT NOT NULL IDENTITY (1, 1),
  Codigo VARCHAR(20) NOT NULL,
  Contraseña VARCHAR(30) NULL,
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,

  -- Campos de auditoría
  ZonaHoraria VARCHAR(10) NULL,
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id)
);

-- Tabla Autores
CREATE TABLE Autores
(
  Id INT NOT NULL IDENTITY (1, 1),
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  Nacionalidad VARCHAR(50) NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id)
);

-- Tabla Libros
CREATE TABLE Libros
(
  Id INT NOT NULL IDENTITY (1, 1),
  Titulo VARCHAR(200) NOT NULL,
  Genero VARCHAR(50) NULL,
  Idioma VARCHAR(50) NULL,
  FechaPublicacion DATE NULL,
  CantidadPaginas INT NULL,
  Ubicacion VARCHAR(100) NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id)
);

-- Tabla Ejemplares
CREATE TABLE Ejemplares
(
  Id INT NOT NULL IDENTITY (1, 1),
  LibroId INT NOT NULL,
  Estado VARCHAR(20) NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id),
  FOREIGN KEY (LibroId) REFERENCES Libros(Id)
);

-- Tabla Inventario
CREATE TABLE Inventario
(
  Id INT NOT NULL IDENTITY (1, 1),   
  LibroId INT NOT NULL,
  Ejemplares INT NOT NULL,
  Disponibles INT NOT NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (LibroId),
  FOREIGN KEY (LibroId) REFERENCES Libros(Id)
);

-- Tabla LibrosAutores
CREATE TABLE LibrosAutores
(
  LibroId INT NOT NULL,
  AutorId INT NOT NULL,

  -- Campos de auditoría
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (LibroId, AutorId),
  FOREIGN KEY (LibroId) REFERENCES Libros(Id),
  FOREIGN KEY (AutorId) REFERENCES Autores(Id)
);

-- Tabla Reservas
CREATE TABLE Reservas
(
  Id INT NOT NULL IDENTITY (1, 1),
  EjemplarId INT NOT NULL,
  UsuarioId INT NOT NULL,
  FechaInicio DATE NULL,
  FechaFin DATE NULL,
  Disponible DATE NULL,
  Estado VARCHAR(20) NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id),
  FOREIGN KEY (EjemplarId) REFERENCES Ejemplares(Id),
  FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);


-- Tabla Prestamos
CREATE TABLE Prestamos
(
  Id INT NOT NULL IDENTITY (1, 1),
  EjemplarId INT NOT NULL,
  AdministradorId INT NOT NULL,
  Dni VARCHAR(10) NOT NULL,
  ReservaId INT NOT NULL,
  FechaInicio DATE NULL,
  FechaDevolucionPrevista DATE NULL,
  FechaDevolucionReal DATE NULL,
  Estado VARCHAR(20) NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id),
  FOREIGN KEY (AdministradorId) REFERENCES Administradores(Id),
  FOREIGN KEY (ReservaId) REFERENCES Reservas(Id)
);

-- Tabla Multas
CREATE TABLE Multas
(
  Id INT NOT NULL IDENTITY (1, 1),
  AdministradorId INT NOT NULL,
  PrestamoId INT NOT NULL,
  Monto DECIMAL(10,2) NULL,
  Motivo VARCHAR(200) NULL,
  Estado BIT NOT NULL,

  -- Campos de auditoría
  Activo BIT NOT NULL,
  Eliminado BIT NOT NULL,
  CreacionId INT NULL,
  FechaCreacion DATETIME NULL,
  ModificacionId INT NULL,
  FechaModificacion DATETIME NULL,

  PRIMARY KEY (Id),
  FOREIGN KEY (AdministradorId) REFERENCES Administradores(Id),
  FOREIGN KEY (PrestamoId) REFERENCES Prestamos(Id)
);


SELECT * FROM Administradores