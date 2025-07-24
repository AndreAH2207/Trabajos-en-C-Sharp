-- Crear base de datos

CREATE DATABASE ImpactoDeportivoDB_Final;
GO
USE ImpactoDeportivoDB_Final;
GO

-- 1. Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY,
    NombreCompleto VARCHAR(100),
    Correo VARCHAR(100) UNIQUE,
    ClaveHash VARCHAR(255),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- 2. Torneos
CREATE TABLE Torneos (
    IdTorneo INT PRIMARY KEY IDENTITY,
    NombreTorneo VARCHAR(100),
    Categoria VARCHAR(50),
    Genero VARCHAR(10),
    FechaInicio DATE,
    FechaFin DATE,
    Estado VARCHAR(20) CHECK (Estado IN ('Abierto', 'En curso', 'Finalizado')),
    CostoInscripcion MONEY,
    PremioTotal MONEY,
    NumeroPremiados INT,
    IdOrganizador INT FOREIGN KEY REFERENCES Usuarios(IdUsuario)
);

-- 3. Equipos
CREATE TABLE Equipos (
    IdEquipo INT PRIMARY KEY IDENTITY,
    NombreEquipo VARCHAR(100),
    TelefonoEquipo VARCHAR(15),
    CorreoEquipo VARCHAR(100),
    DireccionEquipo VARCHAR(200),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- 4. Jugadores
CREATE TABLE Jugadores (
    IdJugador INT PRIMARY KEY IDENTITY,
    Nombres VARCHAR(100),
    Apellidos VARCHAR(100),
    DNI CHAR(8),
    FechaNacimiento DATE,
    IdEquipo INT FOREIGN KEY REFERENCES Equipos(IdEquipo),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- 5. Inscripciones
CREATE TABLE Inscripciones (
    IdInscripcion INT PRIMARY KEY IDENTITY,
    IdTorneo INT FOREIGN KEY REFERENCES Torneos(IdTorneo),
    IdEquipo INT FOREIGN KEY REFERENCES Equipos(IdEquipo),
    FechaInscripcion DATETIME DEFAULT GETDATE(),
    Estado VARCHAR(20) CHECK (Estado IN ('Pendiente', 'Confirmado', 'Rechazado'))
);

-- 6. Canchas
CREATE TABLE Canchas (
    IdCancha INT PRIMARY KEY IDENTITY,
    NombreCancha VARCHAR(100),
    Ubicacion VARCHAR(200)
);

-- 7. Partidos
CREATE TABLE Partidos (
    IdPartido INT PRIMARY KEY IDENTITY,
    IdTorneo INT FOREIGN KEY REFERENCES Torneos(IdTorneo),
    FechaHora DATETIME,
    IdCancha INT FOREIGN KEY REFERENCES Canchas(IdCancha),
    IdEquipoLocal INT FOREIGN KEY REFERENCES Equipos(IdEquipo),
    IdEquipoVisitante INT FOREIGN KEY REFERENCES Equipos(IdEquipo),
    Estado VARCHAR(20) CHECK (Estado IN ('Programado', 'Finalizado', 'Reprogramado')),
    Ronda VARCHAR(50),
    OrdenJuego INT NULL,
    IdGanador INT NULL FOREIGN KEY REFERENCES Equipos(IdEquipo)
);

ALTER TABLE Partidos
ADD CONSTRAINT CK_Partido_FinalizadoDebeTenerGanador
CHECK (NOT (Estado = 'Finalizado' AND IdGanador IS NULL));

-- 8. Resultados 
CREATE TABLE Resultados (
    IdResultado INT PRIMARY KEY IDENTITY,
    IdPartido INT FOREIGN KEY REFERENCES Partidos(IdPartido),
    GolesEquipoLocal INT DEFAULT 0,
    GolesEquipoVisitante INT DEFAULT 0,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- 9. Estadísticas por jugador 
CREATE TABLE EstadisticasJugador (
    IdEstadistica INT PRIMARY KEY IDENTITY,
    IdPartido INT FOREIGN KEY REFERENCES Partidos(IdPartido),
    IdJugador INT FOREIGN KEY REFERENCES Jugadores(IdJugador),
    Goles INT DEFAULT 0,
    Asistencias INT DEFAULT 0,
    Faltas INT DEFAULT 0,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- 10. Tabla de posiciones
CREATE TABLE ResumenEstadisticasEquipo (
    IdTorneo INT,
    IdEquipo INT,
    PartidosJugados INT DEFAULT 0,
    PartidosGanados INT DEFAULT 0,
    PartidosPerdidos INT DEFAULT 0,
    GolesFavor INT DEFAULT 0,
    GolesContra INT DEFAULT 0,
    PRIMARY KEY (IdTorneo, IdEquipo),
    FOREIGN KEY (IdTorneo) REFERENCES Torneos(IdTorneo),
    FOREIGN KEY (IdEquipo) REFERENCES Equipos(IdEquipo)
);


-- 1. Insertar USUARIOS 
INSERT INTO Usuarios (NombreCompleto, Correo, ClaveHash)
VALUES 
('Juan Pérez', 'juanperez@email.com', '1234'),
('María Ruiz', 'maria.ruiz@email.com', '1234');

-- 2. Insertar EQUIPOS
INSERT INTO Equipos (NombreEquipo, TelefonoEquipo, CorreoEquipo, DireccionEquipo)
VALUES 
('Los Tigres', '900111111', 'tigres@club.com', 'Av. Perú 123'),
('Los Lobos', '900222222', 'lobos@club.com', 'Jr. Los Andes 456'),
('Furia Roja', '900333333', 'furia@club.com', 'Calle Libertad 789'),
('Águilas FC', '900444444', 'aguilas@club.com', 'Av. Lima 101'),
('Trueno Azul', '900555555', 'trueno@club.com', 'Jr. Bolívar 202'),
('Halcones Negros', '900666666', 'halcones@club.com', 'Calle Grau 303'),
('Toros Bravos', '900777777', 'toros@club.com', 'Av. Sucre 404'),
('Dragones FC', '900888888', 'dragones@club.com', 'Jr. Amazonas 505');

-- 3. Insertar TORNEOS 
INSERT INTO Torneos (NombreTorneo, Categoria, Genero, FechaInicio, FechaFin, Estado, CostoInscripcion, PremioTotal, NumeroPremiados, IdOrganizador)
VALUES 
('Torneo Relámpago', 'Libre', 'Masculino', '2025-06-01', '2025-06-30', 'Abierto', 150.00, 500.00, 1, 1);

-- 4. Insertar CANCHAS
INSERT INTO Canchas (NombreCancha, Ubicacion)
VALUES 
('Cancha A', 'Av. Deporte 123'),
('Cancha B', 'Jr. Juego 456');



-- 5. Insertar JUGADORES
INSERT INTO Jugadores (Nombres, Apellidos, DNI, FechaNacimiento, IdEquipo)
VALUES 
('Andrés', 'Chávez', '56789012', '2001-01-15', 1),
('Sebastián', 'Tello', '67890123', '1998-06-25', 1),
('Eduardo', 'Martínez', '78901234', '2000-12-08', 1),
('Gabriel', 'Pérez', '89012345', '1999-04-17', 1),
('Ricardo', 'López', '90123456', '2002-09-30', 1),
('Diego', 'Salvador', '01234567', '1997-02-05', 1),
('Martín', 'Cornejo', '11223344', '2003-03-11', 1),
('Alonso', 'Villanueva', '22334455', '2001-07-22', 1),
('James', 'Lucas', '33445566', '2000-11-13', 1),
('Moises', 'Pinto', '44556677', '1999-08-06', 1);

SELECT *
FROM Inscripciones i
LEFT JOIN Torneos t ON i.IdTorneo = t.IdTorneo
LEFT JOIN Equipos e ON i.IdEquipo = e.IdEquipo
WHERE t.IdTorneo IS NULL OR e.IdEquipo IS NULL;

DELETE FROM Inscripciones
WHERE IdTorneo NOT IN (SELECT IdTorneo FROM Torneos)
   OR IdEquipo NOT IN (SELECT IdEquipo FROM Equipos);

SELECT * FROM Partidos

SELECT * FROM Jugadores
SELECT * FROM Usuarios;
SELECT * FROM Equipos;
SELECT * FROM Canchas;
SELECT * FROM Torneos;
SELECT * FROM Partidos;

DELETE FROM Jugadores;
DELETE FROM Equipos;
DELETE FROM Torneos;	
DELETE FROM Usuarios;
DELETE FROM Canchas;	

DBCC CHECKIDENT ('Jugadores', RESEED, 0);
DBCC CHECKIDENT ('Equipos', RESEED, 0);
DBCC CHECKIDENT ('Torneos', RESEED, 0);
DBCC CHECKIDENT ('Usuarios', RESEED, 0);
DBCC CHECKIDENT ('Canchas', RESEED, 0);
DBCC CHECKIDENT ('Partidos', RESEED, 0);