CREATE DATABASE academia;
GO

-- Usar la base de datos academia
USE academia;
GO

-- Crear la tabla personas
CREATE TABLE personas (
    id_persona INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    direccion VARCHAR(50),
    email VARCHAR(50),
    telefono VARCHAR(50),
    fecha_nac DATE,
	activo BIT
);

-- Crear la tabla usuarios (sin el campo habilitado)
CREATE TABLE usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    id_persona INT FOREIGN KEY REFERENCES personas(id_persona),
    nombre_usuario VARCHAR(50),
    clave VARCHAR(50),    
	tipo_usuario INT, -- 1=Alumno, 2=Profesor, 3=Administrativo
    legajo INT,
    id_plan INT,
    activo BIT
);

-- Crear la tabla especialidades
CREATE TABLE especialidades (
    id_especialidad INT IDENTITY(1,1) PRIMARY KEY,
    desc_especialidad VARCHAR(50),
    activo BIT
);

-- Crear la tabla planes
CREATE TABLE planes (
    id_plan INT IDENTITY(1,1) PRIMARY KEY,
    id_especialidad INT FOREIGN KEY REFERENCES especialidades(id_especialidad),
    desc_plan VARCHAR(50),
    activo BIT
);

-- Crear la tabla materias
CREATE TABLE materias (
    id_materia INT IDENTITY(1,1) PRIMARY KEY,
    id_plan INT FOREIGN KEY REFERENCES planes(id_plan),
    desc_materia VARCHAR(50),
    hs_semanales INT,
    hs_totales INT,
    activo BIT
);

-- Crear la tabla comisiones
CREATE TABLE comisiones (
    id_comision INT IDENTITY(1,1) PRIMARY KEY,
    id_plan INT FOREIGN KEY REFERENCES planes(id_plan),
    desc_comision VARCHAR(50),
    anio_especialidad INT,
    hs_totales INT,
    activo BIT
);

-- Crear la tabla cursos
CREATE TABLE cursos (
    id_curso INT IDENTITY(1,1) PRIMARY KEY,
    id_materia INT FOREIGN KEY REFERENCES materias(id_materia) ON DELETE CASCADE,
    id_comision INT FOREIGN KEY REFERENCES comisiones(id_comision) ON DELETE CASCADE,
    anio_calendario INT,
    cupo INT
);

-- Crear la tabla docentes_cursos
	CREATE TABLE dictados (
    id_dictado INT IDENTITY(1,1) PRIMARY KEY,
    id_curso INT FOREIGN KEY REFERENCES cursos(id_curso),
    id_docente INT FOREIGN KEY REFERENCES personas(id_persona),
    cargo VARCHAR(50)
);

-- Crear la tabla inscripciones
CREATE TABLE inscripciones (
    id_inscripcion INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario) ON DELETE CASCADE, 
    id_curso INT FOREIGN KEY REFERENCES cursos(id_curso) ON DELETE CASCADE,
    condicion VARCHAR(50),
    nota INT
);

-- Insertar datos en la tabla personas
INSERT INTO personas (nombre, apellido, direccion, email, telefono, fecha_nac, activo)
VALUES 
('Juan', 'Perez', 'Calle Falsa 123', 'juan.perez@example.com', '123456789', '1985-05-12', 1),
('Maria', 'Gonzalez', 'Avenida Siempre Viva 456', 'maria.gonzalez@example.com', '987654321', '1990-07-22', 1),
('Pedro', 'Lopez', 'Calle Real 789', 'pedro.lopez@example.com', '654321987', '1988-03-15', 1),
('Profe', 'Gomez', 'Calle Real 100', 'profe.gomez@example.com', '341341341', '1970-04-20', 1),
('Francisco', 'Buthet', 'Montevideo 700', 'fjb@gmail.com', '341341341', '2000-08-11', 1);


-- Insertar datos en la tabla especialidades
INSERT INTO especialidades (desc_especialidad, activo)
VALUES 
('Ingenieria en Sistemas', 1), 
('Ciencias de la Computacion', 1);

-- Insertar datos en la tabla planes
INSERT INTO planes (id_especialidad, desc_plan, activo)
VALUES 
(1, 'Plan 2023', 1), 
(1, 'Plan 2022', 1),
(2, 'Plan 2022', 1);

-- Insertar datos en la tabla usuarios
INSERT INTO usuarios (id_persona, nombre_usuario, clave, tipo_usuario, legajo, id_plan, activo)
VALUES 
(1, 'juan.perez', '1', 3, 12345, 1, 1), -- Juan Perez
(2, 'maria.gonzalez', '1', 3, 12346, 2, 1), -- Maria Gonzalez
(3, 'pedro.lopez', '1',3 , 12347, 1, 1), -- Pedro Lopez
(4, 'profesor.gomez', '1', 2, 12345, NULL, 1), -- profesor, legajo 
(4, 'profesor', '1', 2, 1245, NULL, 1), -- profesor, legajo 
(5, 'fjb', '1', 1, NULL, null, 1); -- admin


-- Insertar datos en la tabla materias
INSERT INTO materias (id_plan, desc_materia, hs_semanales, hs_totales, activo)
VALUES 
(1, 'Programacion I', 4, 120, 1),
(1, 'Algebra', 3, 90, 1),
(2, 'Bases de Datos', 4, 120, 1);

-- Insertar datos en la tabla comisiones
INSERT INTO comisiones (id_plan, desc_comision, anio_especialidad, hs_totales, activo)
VALUES 
(1, 'Comision 1', 2024, 120, 1),
(1, 'Comision 2', 2024, 100, 1),
(2, 'Comision 3', 2024, 100, 1);

-- Insertar datos en la tabla cursos
INSERT INTO cursos (id_materia, id_comision, anio_calendario, cupo)
VALUES 
(1, 1, 2024, 30), -- Programacion I
(2, 2, 2024, 25), -- Algebra
(3, 3, 2024, 30); -- Bases de Datos

-- Insertar datos en la tabla inscripciones
INSERT INTO inscripciones (id_usuario, id_curso, condicion, nota)
VALUES 
(1, 1, 'Aprobado', 8), -- Juan Perez (id_usuario = 1) inscripto en Programacion I
(1, 2, 'Regular', NULL), -- Juan Pérez (id_usuario = 1) inscripto en Bases de Datos
(2, 3, 'Regular', NULL); -- Juan Pérez (id_usuario = 1) inscripto en Algebra

INSERT INTO dictados (id_curso, id_docente, cargo)
VALUES
(1,4, 'PROFESOR'),
(2,4, 'JEFE CATEDRA'),
(3, 5, 'AYUDANTE');

select * from usuarios;