CREATE TABLE Persona (
    idPersona INT PRIMARY KEY IDENTITY(1,1),
    rut VARCHAR(20) NOT NULL,
    nombreCompleto VARCHAR(100) NOT NULL,
    apellidoPaterno VARCHAR(50) NOT NULL,
    apellidoMaterno VARCHAR(50) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    grupoSanguineo VARCHAR(10),
    direccionPersonal VARCHAR(255),
    direccionComercial VARCHAR(255),
    direccionFacturacion VARCHAR(255),
    telefonoFijo VARCHAR(20),
    telefonoMovil VARCHAR(20),
    correoLaboral VARCHAR(100),
    correoPersonal VARCHAR(100)
);