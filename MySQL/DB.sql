#DROP DATABASE IF EXISTS SIESM;
CREATE DATABASE IF NOT EXISTS siesm;
USE siesm;

CREATE TABLE IF NOT EXISTS articulo (
	id_articulo VARCHAR(20) NOT NULL,
    nombre_corto VARCHAR(15) NOT NULL,
    nombre_largo VARCHAR(30) NOT NULL,
    descripcion VARCHAR(120),
    imagen MEDIUMBLOB,
    fecha_registro DATE,
    PRIMARY KEY (id_articulo)
);

CREATE TABLE IF NOT EXISTS inventario (
	id_registro INT NOT NULL AUTO_INCREMENT,
    id_sucursal INT NOT NULL,
    id_proveedor INT NOT NULL,
    id_articulo VARCHAR(20),
    unidad_medida VARCHAR(10),
    existencia DECIMAL(5,2),
    nivel_critico INT,
    precio_compra DECIMAL(5,2),
    precio_venta DECIMAL(5,2),
    fecha_surtido DATE,
    PRIMARY KEY (id_registro)
);

CREATE TABLE IF NOT EXISTS sucursal (
	id_sucursal INT NOT NULL AUTO_INCREMENT,
	nombre VARCHAR(30) NOT NULL,
    direccion VARCHAR(250),
    descripcion VARCHAR(250),
    telefono VARCHAR(12),
    imagen MEDIUMBLOB,
    fecha_registro DATE,
    PRIMARY KEY (id_sucursal)
);

CREATE TABLE IF NOT EXISTS proveedor (
	id_proveedor INT NOT NULL AUTO_INCREMENT,
	nombre VARCHAR(30) NOT NULL,
    direccion VARCHAR(250),
    descripcion VARCHAR(250),
    telefono VARCHAR(12),
    fecha_registro DATE,
    PRIMARY KEY (id_proveedor)
);



# PROCEDIMIENTOS ALMACENADOS ************************************************************************************************

#TABLA ARTICULO -----------------------------------------------

DROP PROCEDURE IF EXISTS articulo_mostrar;
 DELIMITER //
CREATE PROCEDURE articulo_mostrar()
   BEGIN
   SELECT id_articulo AS 'Código',
   nombre_corto AS 'Nombre corto',
   nombre_largo AS 'Nombre del articulo',
   descripcion AS 'Descripción',
   imagen AS 'Imagen del articulo',
   fecha_registro AS 'Fecha en que se registró'
   FROM articulo;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_insertar;
 DELIMITER //
CREATE PROCEDURE articulo_insertar(
	IN id_art VARCHAR(20), 
    IN nom_cor VARCHAR(15),
    IN nom_lar VARCHAR(30),
    IN des VARCHAR(120),
    IN ima MEDIUMBLOB,
    IN fec_reg DATE
)
   BEGIN
   INSERT INTO articulo(id_articulo, nombre_corto, nombre_largo, descripcion, imagen, fecha_registro) 
   VALUES(id_art, nom_cor, nom_lar, des, ima, fec_reg);
   
   END //
DELIMITER ;


#TABLA INVENTARIO ----------------------------------------------
#TABLA PROVEEDOR -----------------------------------------------
#TABLA SUCURSAL ------------------------------------------------