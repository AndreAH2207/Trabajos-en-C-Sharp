USE SistemaDeBiblioteca;

-- INSERT Usuarios
INSERT INTO Usuarios (Contraseña, Nombre, Apellido, Dni, Correo, Telefono, Pais, Ciudad, ZonaHoraria, Activo, Eliminado)
VALUES
('1234', 'Oscar', 'Valderramix', '11111111', 'oscar@mail.com', '987654321', 'Peru', 'Lima', '-5', 1, 0),
('abcd', 'Maria', 'Lopez', '22222222', 'maria@mail.com', '123456789', 'Peru', 'Arequipa', '-5', 1, 0),
('5678', 'Luis', 'Martinez', '33333333', 'luis@mail.com', '987123456', 'Chile', 'Santiago', '-4', 1, 0),
('xyz1', 'Ana', 'Fernandez', '44444444', 'ana@mail.com', '765432198', 'Argentina', 'Buenos Aires', '-3', 1, 0);

-- INSERT Administradores
INSERT INTO Administradores (Codigo, Contraseña, Nombre, Apellido, ZonaHoraria, Activo, Eliminado)
VALUES
('ADM001', 'admin123', 'Carlos', 'Perez', '-5', 1, 0),
('ADM002', 'admin456', 'Laura', 'Gomez', '-5', 1, 0),
('ADM003', 'admin789', 'Pedro', 'Hernandez', '-4', 1, 0);

-- INSERT Autores
INSERT INTO Autores (Nombre, Apellido, Nacionalidad, Activo, Eliminado)
VALUES
('Gabriel', 'García Márquez', 'Colombiana', 1, 0),
('Isabel', 'Allende', 'Chilena', 1, 0),
('Mario', 'Vargas Llosa', 'Peruana', 1, 0),
('J.K.', 'Rowling', 'Británica', 1, 0),
('George', 'Orwell', 'Británica', 1, 0),
('Haruki', 'Murakami', 'Japonesa', 1, 0),
('Jane', 'Austen', 'Británica', 0, 1),
('Leo', 'Tolstoy', 'Rusa', 0, 1),
('F. Scott', 'Fitzgerald', 'Estadounidense', 1, 0),
('Ernest', 'Hemingway', 'Estadounidense', 0, 1);

-- INSERT Libros
INSERT INTO Libros (Titulo, Genero, Idioma, FechaPublicacion, CantidadPaginas, Ubicacion, Activo, Eliminado)
VALUES
('Cien años de soledad', 'Ficción', 'Español', '1967-06-05', 417, 'Estante A1', 1, 0),
('La casa de los espíritus', 'Ficción', 'Español', '1982-01-01', 368, 'Estante B2', 1, 0),
('La ciudad y los perros', 'Ficción', 'Español', '1963-01-01', 322, 'Estante C3', 1, 0),
('Harry Potter y la piedra filosofal', 'Fantasía', 'Inglés', '1997-06-26', 223, 'Estante D4', 1, 0),
('1984', 'Distopía', 'Inglés', '1949-06-08', 328, 'Estante E5', 1, 0),
('Kafka en la orilla', 'Ficción', 'Japonés', '2002-09-12', 505, 'Estante F6', 1, 0),
('Orgullo y prejuicio', 'Romance', 'Inglés', '1813-01-28', 432, 'Estante G7', 0, 1),
('Guerra y paz', 'Historia', 'Ruso', '1869-01-01', 1225, 'Estante H8', 0, 1),
('El gran Gatsby', 'Ficción', 'Inglés', '1925-04-10', 180, 'Estante I9', 1, 0),
('El viejo y el mar', 'Ficción', 'Inglés', '1952-09-01', 127, 'Estante J10', 0, 1);

-- INSERT Ejemplares
INSERT INTO Ejemplares (LibroId, Estado, Activo, Eliminado)
VALUES
(1, 'Bajo', 1, 0),
(2, 'Medio', 1, 0),
(3, 'Grave', 1, 0),
(4, 'Inutilizable', 1, 0),
(5, 'Bajo', 1, 0),
(6, 'Medio', 1, 0),
(7, 'Grave', 1, 0),
(8, 'Inutilizable', 1, 0),
(9, 'Bajo', 1, 0),
(10, 'Medio', 1, 0);

-- INSERT Inventario
INSERT INTO Inventario (LibroId, Ejemplares, Disponibles, Activo, Eliminado)
VALUES
(1, 5, 5, 1, 0),
(2, 3, 3, 1, 0),
(3, 2, 2, 1, 0),
(4, 4, 4, 1, 0),
(5, 6, 6, 1, 0);


-- INSERT LibrosAutores
INSERT INTO LibrosAutores (LibroId, AutorId, Eliminado)
VALUES
(1, 1, 0),
(2, 2, 0),
(3, 3, 0),
(4, 4, 0),
(5, 5, 0),
(6, 6, 0),
(7, 7, 1),
(8, 8, 1),
(9, 9, 0),
(10, 10, 1);

-- INSERT Reservas
INSERT INTO Reservas (EjemplarId, UsuarioId, FechaInicio, FechaFin, Estado, Activo, Eliminado)
VALUES 
(1, 1, '2024-11-18', '2024-11-25', 'Reservado', 1, 0),
(2, 1, '2024-11-18', '2024-11-25', 'Reservado', 1, 0),
(3, 1, '2024-11-18', '2024-11-25', 'Reservado', 1, 0),
(4, 1, '2024-11-18', '2024-11-25', 'Reservado', 1, 0);


-- Insertar registros en Prestamos si no existen
INSERT INTO Prestamos (Id, EjemplarId, AdministradorId, Dni, ReservaId, FechaInicio, FechaDevolucionPrevista, FechaDevolucionReal, Estado, Activo, Eliminado)
VALUES
(1, 1, 1, '11111111', 1, '2024-11-01', '2024-11-10', NULL, 'Prestado', 1, 0),
(2, 2, 2, '22222222', 2, '2024-11-05', '2024-11-15', NULL, 'Prestado', 1, 0);



-- INSERT Multas
INSERT INTO Multas (AdministradorId, PrestamoId, Monto, Motivo, Estado, Activo, Eliminado)
VALUES 
(1, 1, 10.50, 'Devolución tardía', 1, 1, 0),
(2, 2, 5.00, 'Deterioro del libro', 1, 1, 0);
