CREATE DATABASE IF NOT EXISTS siesm;
USE siesm;

CREATE TABLE IF NOT EXISTS articulo (
		id_articulo 	VARCHAR(20),
		nombre_corto 	VARCHAR(15) NOT NULL,
		nombre_largo 	VARCHAR(30) NOT NULL,
		descripcion 	VARCHAR(120),
		imagen 			LONGBLOB,
		fecha_registro 	DATE NOT NULL,
		nivel_critico 	INT,
		unidad_medida 	VARCHAR(10),
		precio_compra 	DEC(10,4) NOT NULL,
		precio_venta 	DEC(10,4) NOT NULL,
    PRIMARY KEY (id_articulo)
);

CREATE TABLE IF NOT EXISTS inventario (
		id_inventario 	INT AUTO_INCREMENT,
		id_sucursal 	INT NOT NULL,
		id_proveedor 	INT NOT NULL,
		id_usuario 		VARCHAR(15) NOT NULL,
		id_articulo 	VARCHAR(20) NOT NULL,
		existencia 		DEC(10,4),
		condicion 		VARCHAR(16),
		fecha 			DATE NOT NULL,
    PRIMARY KEY (id_inventario)
);

CREATE TABLE IF NOT EXISTS sucursal (
		id_sucursal 	INT AUTO_INCREMENT,
		nombre 			VARCHAR(30) NOT NULL,
		direccion 		VARCHAR(500),
		descripcion 	VARCHAR(300),
		telefono 		VARCHAR(12),
		imagen 			LONGBLOB,
		fecha 			DATE NOT NULL,
    PRIMARY KEY (id_sucursal)
);

CREATE TABLE IF NOT EXISTS proveedor (
		id_proveedor 	INT AUTO_INCREMENT,
		nombre 			VARCHAR(30) NOT NULL,
		direccion 		VARCHAR(500),
		descripcion 	VARCHAR(300),
		telefono 		VARCHAR(12),
		fecha 			DATE NOT NULL,
    PRIMARY KEY (id_proveedor)
);

CREATE TABLE IF NOT EXISTS usuario (
		id_usuario 		VARCHAR(15),
		contrasena 		VARCHAR(15) NOT NULL,
		nombre 			VARCHAR(20) NOT NULL,
		apellidos 		VARCHAR(30) NOT NULL,
		sexo 			VARCHAR(2) NOT NULL,
		tipo 			INT NOT NULL,
		imagen 			LONGBLOB,
		fecha 			DATE NOT NULL,
    PRIMARY KEY (id_usuario)
);

CREATE TABLE IF NOT EXISTS merma (
		id_merma 		INT AUTO_INCREMENT,
		id_usuario 		VARCHAR(15) NOT NULL,
		id_articulo 	VARCHAR(20) NOT NULL,
		motivo 			VARCHAR(500) NOT NULL,
		cantidad 		DEC(10,4) NOT NULL,
		fecha 			DATE NOT NULL,
		hora 			VARCHAR(15),
    PRIMARY KEY (id_merma)
);

CREATE TABLE IF NOT EXISTS ventas (
		id_reg 			INT AUTO_INCREMENT,
		id_venta 		VARCHAR(12) NOT NULL,
		id_usuario 		VARCHAR(15),
		id_articulo 	VARCHAR(20) NOT NULL,
		cantidad 		DEC(10,4) NOT NULL,
		precio_compra 	DEC(10,4),
		precio_venta 	DEC(10,4),
		fecha 			DATE NOT NULL,
		hora 			VARCHAR(15),
    PRIMARY KEY (id_reg)
);

CREATE TABLE IF NOT EXISTS devoluciones (
		id_reg 			INT AUTO_INCREMENT,
		id_venta 		VARCHAR(12) NOT NULL,
		id_usuario 		VARCHAR(15),
		id_articulo 	VARCHAR(20) NOT NULL,
		motivo 			VARCHAR(6) NOT NULL,
		accion 			VARCHAR(3) NOT NULL,
		descripcion 	VARCHAR(300),
		cantidad 		DEC(10,4) NOT NULL,
		fecha 			DATE NOT NULL,
		hora 			VARCHAR(15),
    PRIMARY KEY (id_reg)
);








#    ________________________________________________________________________________________________________________________________________
#   /PROCEDIMIENTOS ALMACENADOS *********PROCEDIMIENTOS ALMACENADOS*********PROCEDIMIENTOS ALMACENADOS********PROCEDIMIENTOS ALMACENADOS*****\
#  --------------------------------------------------------------------------------------------------------------------------------------------








#TABLA ARTICULO *********** TABLA ARTICULO ***********TABLA ARTICULO*********************************************************************************

DROP PROCEDURE IF EXISTS articulo_mostrar;
 DELIMITER //
CREATE PROCEDURE articulo_mostrar()
   BEGIN
		SELECT 
			id_articulo 	AS	 'Código',
			nombre_corto 	AS	 'Nombre corto',
			nombre_largo 	AS	 'Nombre del articulo',
			descripcion 	AS	 'Descripción',
			nivel_critico 	AS	 'Nivel Critico',
			unidad_medida 	AS	 'Unidad de medida',
			precio_compra 	AS	 'Precio de compra',
			precio_venta 	AS	 'Precio de venta',
			imagen 			AS	 'Imagen',
			CAST(fecha_registro AS char) 	AS	 'Fecha de registro'
		FROM articulo;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS articulo_consultar;
 DELIMITER //
CREATE PROCEDURE articulo_consultar(IN id_art VARCHAR(20))
   BEGIN
		SELECT 
			id_articulo 	AS	 'Código',
			nombre_corto 	AS	 'Nombre corto',
			nombre_largo 	AS	 'Nombre del articulo',
			descripcion 	AS	 'Descripción',
			nivel_critico 	AS	 'Nivel Critico',
			unidad_medida 	AS	 'Unidad de medida',
			precio_compra 	AS	 'Precio de compra',
			precio_venta 	AS	 'Precio de venta',
			imagen 			AS	 'Imagen',
			CAST(fecha_registro AS char) 	AS	 'Fecha de registro'
		FROM articulo 
        WHERE id_articulo = id_art;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS articulo_insertar;
 DELIMITER //
CREATE PROCEDURE articulo_insertar(
	IN id_art 	VARCHAR(20), 
    IN nom_cor 	VARCHAR(15),
    IN nom_lar 	VARCHAR(30),
    IN des 		VARCHAR(200),
	IN niv_cri 	INT,
    IN uni_med 	VARCHAR(10),
    IN pre_com 	DEC(10,4),
    IN pre_ven 	DEC(10,4),
    IN ima 		LONGBLOB,
    IN fec_reg 	DATE
)
   BEGIN
		INSERT INTO articulo(
			id_articulo, 
			nombre_corto, 
			nombre_largo, 
			descripcion, 
			nivel_critico, 
			unidad_medida, 
			precio_compra, 
			precio_venta, 
			imagen, 
			fecha_registro
            ) 
		VALUES(
			id_art, 
			nom_cor, 
			nom_lar, 
			des, 
			niv_cri, 
			uni_med, 
			pre_com, 
			pre_ven, 
			ima, 
			fec_reg
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_editar;
 DELIMITER //
CREATE PROCEDURE articulo_editar(
	IN id_art 	VARCHAR(20), 
    IN nom_cor 	VARCHAR(15),
    IN nom_lar 	VARCHAR(30),
    IN des 		VARCHAR(200),
	IN niv_cri 	INT,
    IN uni_med 	VARCHAR(10),
    IN pre_com 	DEC(10,4),
    IN pre_ven 	DEC(10,4),
    IN ima 		LONGBLOB,
    IN fec_reg 	DATE
)
   BEGIN
		UPDATE articulo SET 
			nombre_corto 	= 	nom_cor, 
			nombre_largo 	= 	nom_lar, 
			descripcion 	= 	des, 
			nivel_critico 	= 	niv_cri,
			unidad_medida 	= 	uni_med,
			precio_compra 	= 	pre_com,
			precio_venta 	= 	pre_ven,
			imagen 			= 	ima, 
			fecha_registro 	= 	fec_reg
		WHERE id_articulo = id_art;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_eliminar;
 DELIMITER //
CREATE PROCEDURE articulo_eliminar(IN articulo VARCHAR(20))
   BEGIN
		DELETE FROM articulo WHERE id_articulo = articulo;
   END //
DELIMITER ;




#TABLA INVENTARIO ***********TABLA INVENTARIO************TABLA INVENTARIO****************************************************************************

DROP PROCEDURE IF EXISTS inventario_mostrar;
 DELIMITER //
CREATE PROCEDURE inventario_mostrar(IN Sucursal INT)
   BEGIN
		SELECT 
			inventario.id_articulo	AS	 'ID', 
			articulo.nombre_largo 	AS	 'Nombre del artículo', 
			articulo.precio_compra 	AS	 'Precio compra', 
			articulo.precio_venta 	AS	 'Precio Venta', 
			inventario.existencia 	AS	 'Existencia',
			inventario.condicion 	AS	 'Condición', 
			CAST(inventario.fecha AS char) 	AS	 'Fecha de surtido' 
		FROM inventario
        INNER JOIN articulo ON articulo.id_articulo = inventario.id_articulo
        WHERE inventario.id_sucursal = Sucursal;
   END //
DELIMITER ;



#TABLA SUCURSAL ************TABLA SUCURSAL************TABLA SUCURSAL*********************************************************************************

DROP PROCEDURE IF EXISTS sucursal_mostrar;
 DELIMITER //
CREATE PROCEDURE sucursal_mostrar()
   BEGIN
		SELECT 
			id_sucursal		AS	 'ID',
			nombre 			AS	 'Sucursal',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM sucursal;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_consultar;
 DELIMITER //
CREATE PROCEDURE sucursal_consultar(IN id INT)
   BEGIN
		SELECT 
			id_sucursal 	AS	'ID',
			nombre 			AS	'Sucursal',
			direccion 		AS	'Dirección',
			descripcion 	AS	'Descripción',
			telefono 		AS	'Teléfono',
            imagen			AS	'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM sucursal
        WHERE id_sucursal = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_insertar;
 DELIMITER //
CREATE PROCEDURE sucursal_insertar(
	IN id_suc 	INT,
    IN nom 		VARCHAR(30),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel 		VARCHAR(12),
    IN ima 		LONGBLOB,
    IN fec 		DATE
)
   BEGIN
		INSERT INTO sucursal(
			id_sucursal, 
			nombre, 
			direccion, 
			descripcin, 
			telefono, 
			imagen, 
			fecha
        ) 
		VALUES(
			id_suc, 
            nom, 
            dir, 
            des, 
            tel, 
            ima, 
            fec
		);
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS sucursal_editar;
 DELIMITER //
CREATE PROCEDURE sucursal_editar(
	IN id_suc 	INT, 
    IN nom	 	VARCHAR(100),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel		VARCHAR(12),
    IN ima 		LONGBLOB,
    IN fec 		DATE
)
   BEGIN
		UPDATE sucursal SET 
			id_sucursal		=	nom_cor, 
			nombre			=	nom_lar, 
            direccion		=	dir,
			descripcion		=	des,
            telefono		=	tel,
			imagen			=	ima, 
			fecha			=	fec
		WHERE id_sucursal = id_suc;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS sucursal_eliminar;
 DELIMITER //
CREATE PROCEDURE sucursal_eliminar(IN Sucursal INT)
   BEGIN
		DELETE FROM sucursal WHERE id_sucursal = Sucursal;
   END //
DELIMITER ;



#TABLA PROVEEDOR ***********TABLA PROVEEDOR*************TABLA PROVEEDOR******************************************************************************

DROP PROCEDURE IF EXISTS proveedor_mostrar;
 DELIMITER //
CREATE PROCEDURE proveedor_mostrar()
   BEGIN
		SELECT 
			id_proveedor 		AS	 'ID',
			nombre 				AS	 'Proveedor',
			direccion 			AS	 'Dirección',
			descripcion 		AS	 'Descripción',
			telefono 			AS	 'Teléfono',
			CAST(fecha AS char) AS	 'Fecha en que se registró'
		FROM proveedor;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_consultar;
 DELIMITER //
CREATE PROCEDURE proveedor_consultar(IN id INT)
   BEGIN
		SELECT 
			id_proveedor 	AS	 'ID',
			nombre 			AS	 'Proveedor',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM proveedor
        WHERE id_proveedor = id;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_insertar;
 DELIMITER //
CREATE PROCEDURE proveedor_insertar(
	IN id_prov	INT,
    IN nom 		VARCHAR(30),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel 		VARCHAR(12),
    IN fec 		DATE
)
   BEGIN
		INSERT INTO proveedor(
			id_proveedor, 
            nombre, 
            direccion, 
            descripcion, 
            telefono, 
            fecha
		) 
		VALUES(
			id_pro, 
            nom, 
            dir, 
            des, 
            tel, 
            fec
		);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_editar;
 DELIMITER //
CREATE PROCEDURE proveedor_editar(
	IN id_prov	INT,
    IN nom 		VARCHAR(30),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel 		VARCHAR(12),
    IN fec	 	DATE
)
   BEGIN
		UPDATE proveedor SET 
			nombre		=	nom, 
			direccion	=	dir, 
            descricion	=	dir,  
			telefono	=	tel, 
			fecha		=	fec
		WHERE id_proveedor = id_pro;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS proveedor_eliminar;
 DELIMITER //
CREATE PROCEDURE proveedor_eliminar(IN proveedor INT)
   BEGIN
		DELETE FROM proveedor WHERE id_proveedor=proveedor;
   END //
DELIMITER ;



#TABLA USUARIO ***********TABLA USUARIO*************TABLA USUARIO************************************************************************************



