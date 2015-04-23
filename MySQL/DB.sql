#DROP DATABASE IF EXISTS SIESM;
CREATE DATABASE IF NOT EXISTS siesm;
USE siesm;

CREATE TABLE IF NOT EXISTS articulo (
	id_articulo VARCHAR(20) NOT NULL,
    nombre_corto VARCHAR(15) NOT NULL,
    nombre_largo VARCHAR(30) NOT NULL,
    descripcion VARCHAR(120),
    imagen LONGBLOB,
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
        imagen AS 'Imagen',
        CAST(fecha_registro AS char) AS 'Fecha de registro'
		FROM articulo;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS articulo_consultar;
 DELIMITER //
CREATE PROCEDURE articulo_consultar(IN id_art VARCHAR(20))
   BEGIN
		SELECT id_articulo AS 'Código',
		nombre_corto AS 'Nombre corto',
		nombre_largo AS 'Nombre del articulo',
		descripcion AS 'Descripción',
        imagen AS 'Imagen',
        CAST(fecha_registro AS char) AS 'Fecha de registro'
		FROM articulo 
        WHERE id_articulo=id_art;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS articulo_insertar;
 DELIMITER //
CREATE PROCEDURE articulo_insertar(
	IN id_art VARCHAR(20), 
    IN nom_cor VARCHAR(15),
    IN nom_lar VARCHAR(30),
    IN des VARCHAR(120),
    IN ima LONGBLOB,
    IN fec_reg DATE
)
   BEGIN
		INSERT INTO articulo(id_articulo, nombre_corto, nombre_largo, descripcion, imagen, fecha_registro) 
		VALUES(id_art, nom_cor, nom_lar, des, ima, fec_reg);
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_editar;
 DELIMITER //
CREATE PROCEDURE articulo_editar(
	IN id_art VARCHAR(20), 
    IN nom_cor VARCHAR(15),
    IN nom_lar VARCHAR(30),
    IN des VARCHAR(120),
    IN ima MEDIUMBLOB,
    IN fec_reg DATE
)
   BEGIN
		UPDATE articulo SET nombre_corto=nom_cor, 
		nombre_largo=nom_lar, 
		descripcion=des, 
		imagen=ima, 
		fecha_registro=fec_reg
		WHERE id_articulo=id_art;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_eliminar;
 DELIMITER //
CREATE PROCEDURE articulo_eliminar(IN articulo VARCHAR(20))
   BEGIN
		DELETE FROM articulo WHERE id_articulo=articulo;
   END //
DELIMITER ;



#TABLA INVENTARIO ----------------------------------------------

DROP PROCEDURE IF EXISTS inventario_mostrar;
 DELIMITER //
CREATE PROCEDURE inventario_mostrar()
   BEGIN
		SELECT id_registro AS 'Código',
		id_sucursal AS 'Sucursal a la que pertenece el articulo',
		id_proveedor AS 'Nombre dl proveedor del articulo',
		id_articulo AS 'Clave única para cada artículo (código de barra).',
		unidad_medida AS 'Forma en que se vende el artículo: litros, metros o por pieza',
		existencia AS 'Cantidad en existencia del articulo',
        nivel_critico AS 'Nivel mínimo para el articulo, se mostrara alerta cuando las existencias lleguen a nivel critico',
        precio_compra AS 'Precio al que se adquirió el articulo',
        precio_venta AS 'Precio al que se venderá al publico',
        fecha_surtido AS 'Ultima fecha en que se surtió el articulo'
        
		FROM inventario;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_ingresar;
 DELIMITER //
CREATE PROCEDURE inventario_ingresar(
	IN id_reg INT, 
    IN  id_suc INT,
    IN  id_pro INT,
    IN id_art VARCHAR(20),
    IN uni_med VARCHAR(10),
    IN exi DECIMAL(5,2),
    IN niv_cri INT,
    IN pre_com DECIMAL(5,2),
    IN pre_ven DECIMAL(5,2),
    IN fec_sur DATE
)
   BEGIN
		INSERT INTO inventario(id_registro, id_sucursal, id_proveedor, id_articulo, unidad_medida, existencia, nivel_critico, precio_compra, precio_venta, fecha_surtido) 
		VALUES(id_reg, id_suc, id_pro, id_art, uni_medida, exi, niv_cri, pre_com, pre_ven, fec_sur);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS inventario_editar;
 DELIMITER //
CREATE PROCEDURE inventario_editar(
	IN id_reg INT, 
    IN  id_suc INT,
    IN  id_pro INT,
    IN id_art VARCHAR(20),
    IN uni_med VARCHAR(10),
    IN exi DECIMAL(5,2),
    IN niv_cri INT,
    IN pre_com DECIMAL(5,2),
    IN pre_ven DECIMAL(5,2),
    IN fec_sur DATE
)
   BEGIN
		UPDATE inventario SET id_sucursal=id_suc, 
		id_proveedor=id_pro, 
		id_articulo=id_art, 
		unidad_medida=uni_med, existencia=exi,  
		nivel_critico=niv_cri, precio_compra=pre_com, precio_venta=pre_ven, fecha_surtid=fec_sur
		WHERE id_registro=id_reg;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS inventario_eliminar;
 DELIMITER //
CREATE PROCEDURE inventario_eliminar(IN registro INT, sucursal INT, proveedor INT, articulo VARCHAR(20))
   BEGIN
		DELETE FROM inventario WHERE (id_registro=registro, id_sucursal=sucursal, id_proveedor=proveedor, id_articulo=articulo);
   END //
DELIMITER ;



#TABLA PROVEEDOR -----------------------------------------------

DROP PROCEDURE IF EXISTS proveedor_mostrar;
 DELIMITER //
CREATE PROCEDURE proveedor_mostrar()
   BEGIN
		SELECT id_proveedor AS 'Clave única para el proveedor',
		nombre AS 'Nombre del proveedor',
		direccion AS 'Dirección del proveedor',
		descripcion AS 'Descripción o anotaciones acerca del proveedor',
		telefono AS 'Teléfono del proveedor',
		fecha_registro AS 'Fecha en que se registró el proveedor'
		FROM proveedor;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_ingresar;
 DELIMITER //
CREATE PROCEDURE proveedor_ingresar(
	IN id_prov INT,
    IN nom VARCHAR(30),
    IN dir VARCHAR(250),
    IN des VARCHAR(250),
    IN tel VARCHAR(12),
    IN fec_reg DATE
)
   BEGIN
		INSERT INTO proveedor(id_proveedor, nombre, direccion, descripcion, telefono, fecha_registro) 
		VALUES(id_pro, nom, dir, des, tel, fec_reg);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_editar;
 DELIMITER //
CREATE PROCEDURE proveedor_editar(
	IN id_prov INT,
    IN nom VARCHAR(30),
    IN dir VARCHAR(250),
    IN des VARCHAR(250),
    IN tel VARCHAR(12),
    IN fec_reg DATE
)
   BEGIN
		UPDATE proveedor SET nombre=nom, 
		direccion=dir, descricion=dir,  
		telefono=tel, 
		fecha_registro=fec_reg
		WHERE id_proveedor=id_pro;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_eliminar;
 DELIMITER //
CREATE PROCEDURE proveedor_eliminar(IN proveedor INT)
   BEGIN
		DELETE FROM proveedor WHERE id_proveedor=proveedor;
   END //
DELIMITER ;



#TABLA SUCURSAL ------------------------------------------------

DROP PROCEDURE IF EXISTS sucursal_mostrar;
 DELIMITER //
CREATE PROCEDURE sucursal_mostrar()
   BEGIN
		SELECT id_sucursal AS 'Clave única para cada sucursal',
		nombre AS 'Nombre de la sucursal',
		direccion AS 'Dirección de la sucursal',
		descripcion AS 'Descripción o anotaciones acerca del proveedor',
		telefono AS 'Teléfono del proveedor',
        fecha_registro AS 'Fecha en que se registró el proveedor'
		FROM articulo;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS sucursal_agregar;
 DELIMITER //
CREATE PROCEDURE sucursal_agregar(
	IN id_suc INT,
    IN nom VARCHAR(30),
    IN dir VARCHAR(250),
    IN des VARCHAR(250),
    IN tel VARCHAR(12),
    IN ima DATE,
    IN fec_reg DATE
)
   BEGIN
		INSERT INTO sucursal(id_sucursal, nombre, direccion, descripcin, telefono, imagen, fecha_registro) 
		VALUES(id_suc, nom, dir, des, tel, ima, fec_reg);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS sucursal_editar;
 DELIMITER //
CREATE PROCEDURE sucursal_editar(
	IN id_art VARCHAR(20), 
    IN nom_cor VARCHAR(15),
    IN nom_lar VARCHAR(30),
    IN des VARCHAR(120),
    IN ima MEDIUMBLOB,
    IN fec_reg DATE
)
   BEGIN
		UPDATE articulo SET nombre_corto=nom_cor, 
		nombre_largo=nom_lar, 
		descripcion=des, 
		imagen=ima, 
		fecha_registro=fec_reg
		WHERE id_articulo=id_art;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS sucursal_eliminar;
 DELIMITER //
CREATE PROCEDURE sucursal_eliminar(IN sucursal INT)
   BEGIN
		DELETE FROM sucursal WHERE id_sucursal=sucursal;
   END //
DELIMITER ;

