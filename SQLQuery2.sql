CREATE TABLE formulario
(ID int PRIMARY KEY NOT NULL,
NOMBRE varchar (50) NOT NULL,
CORREO varchar (30) NOT NULL,
TELEFONO varchar (15) NOT NULL,
FECHA varchar (11) NOT NULL,
CIUDAD varchar (100) NOT NULL,
);
GO

SELECT *
FROM formulario
GO