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
-- Los Tigres (IdEquipo = 1)
('Andrés', 'Chávez', '56789012', '2001-01-15', 1),
('Sebastián', 'Tello', '67890123', '1998-06-25', 1),
('Eduardo', 'Martínez', '78901234', '2000-12-08', 1),
('Gabriel', 'Pérez', '89012345', '1999-04-17', 1),
('Ricardo', 'López', '90123456', '2002-09-30', 1),
('Diego', 'Salvador', '01234567', '1997-02-05', 1),
('Martín', 'Cornejo', '11223344', '2003-03-11', 1),
('Alonso', 'Villanueva', '22334455', '2001-07-22', 1),
('James', 'Lucas', '33445566', '2000-11-13', 1),
('Moises', 'Pinto', '44556677', '1999-08-06', 1),
('Renzo', 'Molina', '55667788', '1998-10-21', 1),

-- Los Lobos (IdEquipo = 2)
('Luis', 'Zamora', '66778899', '2002-05-14', 2),
('Pedro', 'Guzmán', '77889900', '2001-08-19', 2),
('Mario', 'Rivas', '88990011', '1999-03-22', 2),
('Samuel', 'Morales', '99001122', '1997-07-03', 2),
('Joel', 'Ortega', '10111213', '2000-09-25', 2),
('Arturo', 'Soto', '12131415', '1998-11-29', 2),
('Javier', 'Silva', '13141516', '2003-02-10', 2),
('Rodrigo', 'Palacios', '14151617', '2001-06-05', 2),
('César', 'Mendoza', '15161718', '1999-12-14', 2),
('Óscar', 'Reyes', '16171819', '2000-03-09', 2),
('Dylan', 'Aguilar', '17181920', '1998-01-27', 2),

-- Furia Roja (IdEquipo = 3)
('Enzo', 'Paredes', '18192021', '2002-04-15', 3),
('Alan', 'Ibarra', '19202122', '2001-12-02', 3),
('Kevin', 'Bravo', '20212223', '1999-07-30', 3),
('Carlos', 'Ramírez', '21222324', '2000-10-08', 3),
('Miguel', 'Campos', '22232425', '1998-06-12', 3),
('Fernando', 'Quispe', '23242526', '1997-09-17', 3),
('Pablo', 'Vega', '24252627', '2003-01-24', 3),
('Alexander', 'Rojas', '25262728', '2000-08-31', 3),
('Bruno', 'Estrada', '26272829', '1999-11-20', 3),
('Julio', 'Delgado', '27282930', '1998-02-14', 3),
('Adrián', 'Suárez', '28293031', '2002-05-07', 3),

-- Águilas FC (IdEquipo = 4)
('Francisco', 'Gómez', '29303132', '2000-07-18', 4),
('Manuel', 'Del Carpio', '30313233', '1999-05-23', 4),
('Iván', 'Huerta', '31323334', '1998-03-28', 4),
('Raúl', 'Galvez', '32333435', '2002-10-11', 4),
('Fabián', 'Valdez', '33343536', '1997-08-04', 4),
('Henry', 'Caballero', '34353637', '2001-11-15', 4),
('Nicolás', 'Solís', '35363738', '1999-01-09', 4),
('Leonardo', 'Ramos', '36373839', '2000-06-22', 4),
('Gustavo', 'Rosales', '37383940', '1998-09-19', 4),
('Walter', 'Mejía', '38394041', '1997-12-06', 4),
('Cristian', 'Montoya', '39404142', '2003-02-03', 4),

-- Trueno Azul (IdEquipo = 5)
('Daniel', 'Reynoso', '40414243', '1999-03-14', 5),
('Mauricio', 'Benites', '41424344', '2001-06-07', 5),
('Felipe', 'Mora', '42434445', '2002-08-28', 5),
('Jorge', 'Arévalo', '43444546', '1998-05-11', 5),
('Victor', 'Peña', '44454647', '2000-09-02', 5),
('Antonio', 'Chacón', '45464748', '1997-12-25', 5),
('Sandro', 'Oliva', '46474849', '2001-01-18', 5),
('Cristofer', 'Salazar', '47484950', '1999-04-30', 5),
('Axel', 'Camacho', '48495051', '2000-07-03', 5),
('Jhon', 'Nieto', '49505152', '1998-10-20', 5),
('Giancarlo', 'Vilca', '50515253', '2003-03-12', 5),

-- Halcones Negros (IdEquipo = 6)
('Esteban', 'Barrios', '51525354', '2002-05-26', 6),
('Cristian', 'Poma', '52535455', '2001-09-15', 6),
('Roberto', 'Carpio', '53545556', '1999-11-01', 6),
('Julian', 'García', '54555657', '2000-02-13', 6),
('Erick', 'Quinteros', '55565758', '1998-08-07', 6),
('Álvaro', 'Navarro', '56575859', '1997-12-18', 6),
('Bryan', 'Luna', '57585960', '2003-01-05', 6),
('Josué', 'Sánchez', '58596061', '2000-04-27', 6),
('Yamil', 'Medina', '59606162', '1999-06-16', 6),
('Leandro', 'Moreno', '60616263', '1998-10-04', 6),
('Joel', 'Espinoza', '61626364', '2002-03-09', 6),

-- Toros Bravos (IdEquipo = 7)
('Emanuel', 'Delgado', '62636465', '1999-08-30', 7),
('Tomás', 'Pérez', '63646566', '2001-05-17', 7),
('Ulises', 'Farfán', '64656667', '2002-07-08', 7),
('Fabricio', 'Bravo', '65666768', '1998-12-12', 7),
('Sergio', 'Reategui', '66676869', '2000-03-21', 7),
('Lisandro', 'Ruiz', '67686970', '1997-09-28', 7),
('Andrés', 'Valverde', '68697071', '2001-11-04', 7),
('Hernán', 'Marquez', '69707172', '1999-06-25', 7),
('Lautaro', 'Huamán', '70717273', '2000-02-16', 7),
('Jonatan', 'Sandoval', '71727374', '1998-04-19', 7),
('Aldair', 'Peralta', '72737475', '2003-01-31', 7),

-- Dragones FC (IdEquipo = 8)
('Kevin', 'Fuentes', '73747576', '2002-06-08', 8),
('Jerson', 'Valdivia', '74757677', '2001-10-10', 8),
('Ricardo', 'Becerra', '75767778', '1999-12-01', 8),
('Óscar', 'Gamarra', '76777879', '2000-05-23', 8),
('Yordi', 'Gallo', '77787980', '1998-09-06', 8),
('Victor', 'Roldán', '78798081', '1997-11-19', 8),
('Elmer', 'Zambrano', '79808182', '2003-03-13', 8),
('Hugo', 'Callirgos', '80818283', '2001-01-27', 8),
('Junior', 'Acevedo', '81828384', '1999-07-21', 8),
('Renato', 'Lara', '82838485', '2000-08-03', 8),
('Franco', 'Barco', '83848586', '1998-02-09', 8);


SELECT *
FROM Inscripciones i
LEFT JOIN Torneos t ON i.IdTorneo = t.IdTorneo
LEFT JOIN Equipos e ON i.IdEquipo = e.IdEquipo
WHERE t.IdTorneo IS NULL OR e.IdEquipo IS NULL;

DELETE FROM Inscripciones
WHERE IdTorneo NOT IN (SELECT IdTorneo FROM Torneos)
   OR IdEquipo NOT IN (SELECT IdEquipo FROM Equipos);


SELECT * FROM Jugadores
SELECT * FROM Usuarios;
SELECT * FROM Equipos;
SELECT * FROM Canchas;
SELECT * FROM Torneos;
SELECT * FROM Partidos;
SELECT * FROM Resultados;
SELECT * FROM Inscripciones;
SELECT * FROM EstadisticasJugador;
SELECT * FROM ResumenEstadisticasEquipo;

DELETE FROM Jugadores;
DELETE FROM Equipos;
DELETE FROM Torneos;	
DELETE FROM Usuarios;
DELETE FROM Canchas;	
DELETE FROM EstadisticasJugador

DBCC CHECKIDENT ('Jugadores', RESEED, 0);
DBCC CHECKIDENT ('Equipos', RESEED, 0);
DBCC CHECKIDENT ('Torneos', RESEED, 0);
DBCC CHECKIDENT ('Usuarios', RESEED, 0);
DBCC CHECKIDENT ('Canchas', RESEED, 0);
DBCC CHECKIDENT ('Partidos', RESEED, 0);