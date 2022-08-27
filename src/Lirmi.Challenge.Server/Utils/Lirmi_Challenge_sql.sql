

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Lirmi_Challenge')
BEGIN
    CREATE DATABASE Lirmi_Challenge
END
	
	
BEGIN
	USE Lirmi_Challenge
IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'Asignatura')
	BEGIN
		CREATE TABLE  Asignatura (
		   Id_Asignatura int IDENTITY(1,1),  
		   Nombre_Asignatura VARCHAR ( 50 ) NOT NULL,
			PRIMARY KEY(Id_Asignatura)
		);

		INSERT INTO Asignatura (Nombre_Asignatura)
		VALUES
		('Matemáticas'),
		('Lengua'),
		('Física'),
		('Ingles')
	END

IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'Curso')
	BEGIN
		CREATE TABLE   Curso (
		   Id_Curso int IDENTITY(1,1),  
		   Nombre_Curso VARCHAR ( 50 ) NOT NULL,
		   Id_Asignatura INT NULL,
			PRIMARY KEY(Id_Curso),
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
	END


IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'Colegio')
	BEGIN
		CREATE TABLE  Colegio (
		   Id_Colegio int IDENTITY(1,1),  
		   Nombre_Colegio VARCHAR ( 50 ) NOT NULL,
			Id_Curso int NULL,
			PRIMARY KEY(Id_Colegio),
			FOREIGN KEY (Id_Curso)
			  REFERENCES Curso (Id_Curso)
		)

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
	END


SELECT id_asignatura, nombre_asignatura
	FROM asignatura

SELECT id_curso, nombre_curso
	FROM curso
	
SELECT id_colegio, nombre_colegio
	FROM colegio

	END