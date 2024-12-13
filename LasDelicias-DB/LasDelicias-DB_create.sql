-- Crear base de datos
Create database LasDelicias
go

-- Usar base de datos
Use LasDelicias
go

-- tables
-- Table: administradores
CREATE TABLE administradores (
    codigo int  NOT NULL,
    correo varchar(100)  NOT NULL,
    contrasena varchar(100)  NOT NULL,
    CONSTRAINT administradores_pk PRIMARY KEY  (codigo)
);

-- Table: encuestas
CREATE TABLE encuestas (
    codigo int  NOT NULL,
    preguntas varchar(100)  NOT NULL,
    usuarios_codigo int  NOT NULL,
    frecuencia varchar(100)  NOT NULL,
    tipo varchar(100)  NOT NULL,
    ocasion varchar(100)  NOT NULL,
    sabor varchar(100)  NOT NULL,
    CONSTRAINT encuestas_pk PRIMARY KEY  (codigo)
);

-- Table: metodos_de_pago
CREATE TABLE metodos_de_pago (
    codigo int  NOT NULL,
    tipo_de_pago varchar(100)  NOT NULL,
    CONSTRAINT metodos_de_pago_pk PRIMARY KEY  (codigo)
);

-- Table: ordenes
CREATE TABLE ordenes (
    codigo int  NOT NULL,
    fecha_entrega date  NOT NULL,
    direccion varchar(100)  NOT NULL,
    distrito varchar(100)  NOT NULL,
    cantidad int  NOT NULL,
    precio int  NOT NULL,
    usuarios_codigo int  NOT NULL,
    administradores_codigo int  NOT NULL,
    pagos_codigo int  NOT NULL,
    sedes_codigo int  NOT NULL,
    CONSTRAINT ordenes_pk PRIMARY KEY  (codigo)
);

-- Table: pagos
CREATE TABLE pagos (
    codigo int  NOT NULL,
    metodos_de_pago_codigo int  NOT NULL,
    CONSTRAINT pagos_pk PRIMARY KEY  (codigo)
);

-- Table: reportes
CREATE TABLE reportes (
    codigo int  NOT NULL,
    resultados varchar(100)  NOT NULL,
    administradores_codigo int  NOT NULL,
    CONSTRAINT reportes_pk PRIMARY KEY  (codigo)
);

-- Table: sedes
CREATE TABLE sedes (
    codigo int  NOT NULL,
    distrito varchar(100)  NOT NULL,
    CONSTRAINT sedes_pk PRIMARY KEY  (codigo)
);

-- Table: tortas
CREATE TABLE tortas (
    codigo int  NOT NULL,
    nombre varchar(100)  NOT NULL,
    sabor varchar(100)  NOT NULL,
    tematica varchar(100)  NOT NULL,
    tamano varchar(100)  NOT NULL,
    ordenes_codigo int  NOT NULL,
    CONSTRAINT tortas_pk PRIMARY KEY  (codigo)
);

-- Table: usuarios
CREATE TABLE usuarios (
    codigo int  NOT NULL,
    dni varchar(8)  NOT NULL,
    nombre varchar(100)  NOT NULL,
    fecha_de_nacimiento date  NOT NULL,
    direccion varchar(100)  NOT NULL,
    distrito varchar(100)  NOT NULL,
    correo varchar(100)  NOT NULL,
    contrasena varchar(100)  NOT NULL,
    CONSTRAINT usuarios_pk PRIMARY KEY  (codigo)
);

-- foreign keys
-- Reference: encuestas_usuarios (table: encuestas)
ALTER TABLE encuestas ADD CONSTRAINT encuestas_usuarios
    FOREIGN KEY (usuarios_codigo)
    REFERENCES usuarios (codigo);

-- Reference: ordenes_administradores (table: ordenes)
ALTER TABLE ordenes ADD CONSTRAINT ordenes_administradores
    FOREIGN KEY (administradores_codigo)
    REFERENCES administradores (codigo);

-- Reference: ordenes_pagos (table: ordenes)
ALTER TABLE ordenes ADD CONSTRAINT ordenes_pagos
    FOREIGN KEY (pagos_codigo)
    REFERENCES pagos (codigo);

-- Reference: ordenes_sedes (table: ordenes)
ALTER TABLE ordenes ADD CONSTRAINT ordenes_sedes
    FOREIGN KEY (sedes_codigo)
    REFERENCES sedes (codigo);

-- Reference: ordenes_usuarios (table: ordenes)
ALTER TABLE ordenes ADD CONSTRAINT ordenes_usuarios
    FOREIGN KEY (usuarios_codigo)
    REFERENCES usuarios (codigo);

-- Reference: pagos_metodos_de_pago (table: pagos)
ALTER TABLE pagos ADD CONSTRAINT pagos_metodos_de_pago
    FOREIGN KEY (metodos_de_pago_codigo)
    REFERENCES metodos_de_pago (codigo);

-- Reference: reportes_administradores (table: reportes)
ALTER TABLE reportes ADD CONSTRAINT reportes_administradores
    FOREIGN KEY (administradores_codigo)
    REFERENCES administradores (codigo);

-- Reference: tortas_ordenes (table: tortas)
ALTER TABLE tortas ADD CONSTRAINT tortas_ordenes
    FOREIGN KEY (ordenes_codigo)
    REFERENCES ordenes (codigo);

-- End of file.

-- Ingresar datos
use LasDelicias
go

----Ingresar en orden (esta dividido por parrafos):
INSERT INTO administradores(codigo, correo, contrasena)
VALUES (1, 'admin@gmail.com', 'contra1');
INSERT INTO administradores(codigo, correo, contrasena)
VALUES (2, 'admin2@gmail.com', 'contra2');

----Luego: 
INSERT INTO metodos_de_pago(codigo, tipo_de_pago)
VALUES (1, 'Tarjeta');


-----Luego:
INSERT INTO pagos (codigo, metodos_de_pago_codigo)
VALUES (1, 1);


----Luego:
INSERT INTO sedes (codigo, distrito) 
VALUES (1, 'Surco');

INSERT INTO sedes (codigo, distrito) 
VALUES (2, 'La Molina');


INSERT INTO sedes (codigo, distrito) 
VALUES (3, 'Villa María del Triunfo');


INSERT INTO sedes (codigo, distrito) 
VALUES (4, 'Manchay');

INSERT INTO sedes (codigo, distrito) 
VALUES (5, 'Independencia');

INSERT INTO sedes (codigo, distrito) 
VALUES (6, 'Los Olivos');

INSERT INTO sedes (codigo, distrito) 
VALUES (7, 'Online');


----Luego:
INSERT INTO usuarios(codigo, dni, nombre, fecha_de_nacimiento, direccion, distrito, correo, contrasena)
VALUES (1, '12345678', 'administrador','2000-06-06','Local','Local','admin@gmail.com', 'contra1');