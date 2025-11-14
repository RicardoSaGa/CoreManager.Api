CREATE DATABASE CoreManagerDB;
GO

USE CoreManagerDB;
GO

CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    Direccion NVARCHAR(250) NOT NULL
);
GO

CREATE TABLE TiposEmpleado (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreTipo NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Empleados (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    TipoEmpleadoId INT NOT NULL,
    CONSTRAINT FK_Empleado_TipoEmpleado 
        FOREIGN KEY (TipoEmpleadoId) REFERENCES TiposEmpleado(Id)
);
GO

CREATE TABLE TiposPersiana (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreTipo NVARCHAR(150) NOT NULL,
    PrecioMetroCuadrado DECIMAL(10,2) NOT NULL
);
GO

-- CONSULTAS


