CREATE TABLE IF NOT EXISTS  Asignatura (
   Id_Asignatura INT  GENERATED ALWAYS AS IDENTITY,
   Nombre_Asignatura VARCHAR ( 50 ) NOT NULL,
	PRIMARY KEY(Id_Asignatura)
);

INSERT INTO Asignatura (Nombre_Asignatura)
VALUES
('Matemáticas'),
('Lengua'),
('Física'),
('Ingles')
;

CREATE TABLE  IF NOT EXISTS Curso (
   Id_Curso INT  GENERATED ALWAYS AS IDENTITY,
   Nombre_Curso VARCHAR ( 50 ) NOT NULL,
   Id_Asignatura INT NULL,
	PRIMARY KEY(Id_Curso),
	CONSTRAINT fk_Asignatura
	FOREIGN KEY (Id_Asignatura)
      REFERENCES Asignatura (Id_Asignatura)
);

INSERT INTO Curso (Nombre_Curso, Id_Asignatura)
VALUES
('1° Primaria',1),
('1° Primaria',2),
('1° Primaria',4),
('1° Bachillerato',1),
('1° Bachillerato',2),
('1° Bachillerato',3),
('1° Bachillerato',4),
('1° Básico',1),
('1° Básico',2)
;

CREATE TABLE IF NOT EXISTS Colegio (
   Id_Colegio INT  GENERATED ALWAYS AS IDENTITY,
   Nombre_Colegio VARCHAR ( 50 ) NOT NULL,
	Id_Curso int NULL,
	PRIMARY KEY(Id_Colegio),
	CONSTRAINT fk_Curso
	FOREIGN KEY (Id_Curso)
      REFERENCES Curso (Id_Curso)
);

INSERT INTO Colegio (Nombre_Colegio, Id_Curso)
VALUES
('Los trigales',8),
('Los trigales',9),
('Juan Pastor',1),
('Juan Pastor',2),
('Juan Pastor',3),
('Sagrado Corazon',4),
('Sagrado Corazon',5),
('Sagrado Corazon',6),
('Sagrado Corazon',7)
;


SELECT id_asignatura, nombre_asignatura
	FROM public.asignatura;

SELECT id_curso, nombre_curso
	FROM public.curso;
	
SELECT id_colegio, nombre_colegio
	FROM public.colegio;