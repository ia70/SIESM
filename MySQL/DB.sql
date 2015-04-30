CREATE DATABASE IF NOT EXISTS siesm;
USE siesm;

CREATE TABLE IF NOT EXISTS articulo (
		id_articulo 	VARCHAR(20),
		nombre		 	VARCHAR(150) NOT NULL,
		descripcion 	VARCHAR(300),
		nivel_critico 	INT,
		unidad_medida 	VARCHAR(10),
		precio_compra 	DEC(10,2),
		precio_venta 	DEC(10,2) NOT NULL,
		imagen 			LONGBLOB,
		fecha		 	DATE NOT NULL,
    PRIMARY KEY (id_articulo)
);

CREATE TABLE IF NOT EXISTS inventario (
		id_inventario 	INT AUTO_INCREMENT,
		id_sucursal 	INT NOT NULL,
		id_proveedor 	INT NOT NULL,
		id_usuario 		VARCHAR(15) NOT NULL,
		id_articulo 	VARCHAR(20) NOT NULL,
		existencia 		DEC(10,2),
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
		cantidad 		DEC(10,2) NOT NULL,
		fecha 			DATE NOT NULL,
		hora 			VARCHAR(15),
    PRIMARY KEY (id_merma)
);

CREATE TABLE IF NOT EXISTS ventas (
		id_reg 			INT AUTO_INCREMENT,
		id_venta 		VARCHAR(12) NOT NULL,
		id_usuario 		VARCHAR(15),
		id_articulo 	VARCHAR(20) NOT NULL,
		cantidad 		DEC(10,2) NOT NULL,
		precio_compra 	DEC(10,2),
		precio_venta 	DEC(10,2),
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
		cantidad 		DEC(10,2) NOT NULL,
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
			nombre		 	AS	 'Nombre del articulo',
			descripcion 	AS	 'Descripción',
			nivel_critico 	AS	 'Nivel Critico',
			unidad_medida 	AS	 'Unidad de medida',
			precio_compra 	AS	 'Precio de compra',
			precio_venta 	AS	 'Precio de venta',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) AS	 'Fecha de registro'
		FROM articulo;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS articulo_consultar;
 DELIMITER //
CREATE PROCEDURE articulo_consultar(IN id_art VARCHAR(20))
   BEGIN
		SELECT 
			id_articulo 	AS	 'Código',
			nombre		 	AS	 'Nombre del articulo',
			descripcion 	AS	 'Descripción',
			nivel_critico 	AS	 'Nivel Critico',
			unidad_medida 	AS	 'Unidad de medida',
			precio_compra 	AS	 'Precio de compra',
			precio_venta 	AS	 'Precio de venta',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) AS	 'Fecha de registro'
		FROM articulo 
        WHERE id_articulo = id_art;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS articulo_insertar;
 DELIMITER //
CREATE PROCEDURE articulo_insertar(
	IN id_art 	VARCHAR(20), 
    IN nom	 	VARCHAR(150),
    IN des 		VARCHAR(300),
	IN niv_cri 	INT,
    IN uni_med 	VARCHAR(10),
    IN pre_com 	DEC(10,2),
    IN pre_ven 	DEC(10,2),
    IN ima 		LONGBLOB,
    IN fec 		DATE
)
   BEGIN
		INSERT INTO articulo(
			id_articulo, 
			nombre, 
			descripcion, 
			nivel_critico, 
			unidad_medida, 
			precio_compra, 
			precio_venta, 
			imagen, 
			fecha
            ) 
		VALUES(
			id_art, 
			nom, 
			des, 
			niv_cri, 
			uni_med, 
			pre_com, 
			pre_ven, 
			ima, 
			fec
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_editar;
 DELIMITER //
CREATE PROCEDURE articulo_editar(
	IN id_art 	VARCHAR(20), 
    IN nom	 	VARCHAR(150),
    IN des 		VARCHAR(300),
	IN niv_cri 	INT,
    IN uni_med 	VARCHAR(10),
    IN pre_com 	DEC(10,2),
    IN pre_ven 	DEC(10,2),
    IN ima 		LONGBLOB,
    IN fec	 	DATE
)
   BEGIN
		UPDATE articulo SET 
			nombre		 	= 	nom, 
			descripcion 	= 	des, 
			nivel_critico 	= 	niv_cri,
			unidad_medida 	= 	uni_med,
			precio_compra 	= 	pre_com,
			precio_venta 	= 	pre_ven,
			imagen 			= 	ima, 
			fecha		 	= 	fec
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



DROP PROCEDURE IF EXISTS articulo_inicio;
 DELIMITER //
CREATE PROCEDURE articulo_inicio()
   BEGIN
		select 
        id_articulo 	AS 	"ID",
        nombre			AS 	"Nombre del artículo",
        descripcion		AS 	"Descripción",
        nivel_critico	AS 	"Nivel critico",
        unidad_medida	AS  "Unidad de medida",
        precio_compra	AS  "Precio compra",
        precio_venta	AS  "Precio venta",
        imagen			AS  "Imagen",
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM articulo LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_final;
 DELIMITER //
CREATE PROCEDURE articulo_final()
   BEGIN
		select 
        id_articulo 	AS 	"ID",
        nombre			AS 	"Nombre del artículo",
        descripcion		AS 	"Descripción",
        nivel_critico	AS 	"Nivel critico",
        unidad_medida	AS  "Unidad de medida",
        precio_compra	AS  "Precio compra",
        precio_venta	AS  "Precio venta",
        imagen			AS  "Imagen",
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM articulo ORDER BY id_articulo DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_siguiente;
 DELIMITER //
CREATE PROCEDURE articulo_siguiente(
	IN id_art VARCHAR(20)
)
   BEGIN
		select 
        id_articulo 	AS 	"ID",
        nombre			AS 	"Nombre del artículo",
        descripcion		AS 	"Descripción",
        nivel_critico	AS 	"Nivel critico",
        unidad_medida	AS  "Unidad de medida",
        precio_compra	AS  "Precio compra",
        precio_venta	AS  "Precio venta",
        imagen			AS  "Imagen",
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM articulo WHERE id_articulo > id_art ORDER BY id_articulo ASC LIMIT 1;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS articulo_atras;
 DELIMITER //
CREATE PROCEDURE articulo_atras(
	IN id_art VARCHAR(20)
)
   BEGIN
		select 
        id_articulo 	AS 	"ID",
        nombre			AS 	"Nombre del artículo",
        descripcion		AS 	"Descripción",
        nivel_critico	AS 	"Nivel critico",
        unidad_medida	AS  "Unidad de medida",
        precio_compra	AS  "Precio compra",
        precio_venta	AS  "Precio venta",
        imagen			AS  "Imagen",
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM articulo WHERE id_articulo < id_art ORDER BY id_articulo DESC LIMIT 1;
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

DROP PROCEDURE IF EXISTS usuario_mostrar;
 DELIMITER //
CREATE PROCEDURE usuario_mostrar()
   BEGIN
		SELECT 

			id_usuario		AS	 'ID',
			contraseña	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM sucursal;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS usuario_consultar;
 DELIMITER //
CREATE PROCEDURE usuario_consultar(IN id_usu VARCHAR(15))
   BEGIN
		SELECT 
			id_usuario		AS	 'ID',
			contraseña	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM usuario 
        WHERE id_usuario = id_usu;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS usuario_insertar;
 DELIMITER //
CREATE PROCEDURE usuario_insertar(
	IN id_usu 	VARCHAR(15), 
    IN contr 	VARCHAR(15),
    IN nom   	VARCHAR(20),
    IN apell	VARCHAR(30),
	IN sex   	VARCHAR(2),
    IN tip  	INT,
    IN ima 		LONGBLOB,
    IN fec_reg 	DATE
)
   BEGIN
		INSERT INTO usuario(
			id_usuario, 
			contraseña, 
			nombre, 
			apellidos, 
			sexo, 
			tipo, 
			imagen, 
			fecha_registro
            ) 
		VALUES(
			id_usu, 
			contr, 
			usu, 
		    apell, 
			sex, 
			tip, 
			ima, 
			fec_reg
            );
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS usuario_editar;
 DELIMITER //
CREATE PROCEDURE usuario_editar(
	IN id_usu 	VARCHAR(15), 
    IN contr 	VARCHAR(15),
    IN nom   	VARCHAR(20),
    IN apell	VARCHAR(30),
	IN sex   	VARCHAR(2),
    IN tip  	INT,
    IN ima 		LONGBLOB,
    IN fec_reg 	DATE
)
   BEGIN
		UPDATE usuario SET 
			contraseña      =   contr, 
            nombre      	= 	nom, 
			apellidos   	= 	apell, 
			nivel_critico 	= 	niv_cri,
			sexo        	= 	sex,
			tipo        	= 	tip,
			imagen 			= 	ima, 
			fecha_registro 	= 	fec_reg
		WHERE id_usuario = id_usu;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS usuario_eliminar;
 DELIMITER //
CREATE PROCEDURE usuario_eliminar(IN usuario VARCHAR(15))
   BEGIN
		DELETE FROM usuario WHERE id_usuario = usuario;
   END //
DELIMITER ;

#TABLA MERMA************************************ #TABLA MERMA***************************************************** #TABLA MERMA***************************

DROP PROCEDURE IF EXISTS merma_mostrar;
 DELIMITER //
CREATE PROCEDURE merma_mostrar()
   BEGIN
		SELECT 
			id_merma     	AS	 'ID',
			id_usuario      AS	 'ID',
			motivo      	AS	 'motivo de entrada a merma',
			cantidad	    AS	 'cantidad de articulos',
			fecha       	AS	 'fecha de registro',
			hora 			AS	 'hora de registro',
			CAST(fecha_registro AS char) 	AS	 'Fecha de registro'
		FROM articulo;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS merma_consultar;
 DELIMITER //
CREATE PROCEDURE merma_consultar(IN id_mer INT)
   BEGIN
		SELECT 
			id_merma     	AS	 'ID',
			id_usuario      AS	 'ID',
			motivo      	AS	 'motivo de entrada a merma',
			cantidad	    AS	 'cantidad de articulos',
			hora 			AS	 'hora de registro',
			CAST(fecha_registro AS char) 	AS	 'Fecha de registro'
		FROM articulo 
        WHERE id_merma = id_mer;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS merma_insertar;
 DELIMITER //
CREATE PROCEDURE merma_insertar(
	IN id_mer  	INT,
    IN id_usu	VARCHAR(15),
    IN id_art   VARCHAR(20),
    IN mot 		VARCHAR(500),
    IN cant     DECIMAL(10,4),
    IN hor 		VARCHAR(15),
    IN fecha    DATE
)
   BEGIN
		INSERT INTO merma(
			id_merma, 
			id_sucursal, 
			id_art, 
			motivo, 
			cantidad, 
			fecha,
			hora
        ) 
		VALUES(
			id_mer, 
            id_suc, 
            id_art, 
            mot, 
            cant, 
            fec, 
            hor
		);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS merma_editar;
 DELIMITER //
CREATE PROCEDURE merma_editar(
	IN id_mer  	INT,
    IN id_usu	VARCHAR(15),
    IN id_art   VARCHAR(20),
    IN mot 		VARCHAR(500),
    IN cant     DECIMAL(10,4),
    IN hor 		VARCHAR(15),
    IN fec 		DATE
)
   BEGIN
		UPDATE merma SET 
			id_merma    	=	id_mer, 
			id_usuario		=	id_usu, 
            di_articulo		=	id_art,
			motivo   		=	mot,
            cantidad 		=	cant,
			fecha			=	fec, 
			hora			=	hor
		WHERE id_merma = id_mer;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS merma_eliminar;
 DELIMITER //
CREATE PROCEDURE merma_eliminar(IN merma INT)
   BEGIN
		DELETE FROM merma WHERE id_merma = merma;
   END //
DELIMITER ;

# TABLA VENTAS ************************************ #TABLA VENTAS*****************************************************************

DROP PROCEDURE IF EXISTS venta_mostrar;
 DELIMITER //
CREATE PROCEDURE venta_mostrar()
   BEGIN
		SELECT 
			id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'cantidad de articulos vendidos',
            precio_compra   AS   'precio de compra del producto',
            precio_venta    AS   'precio de venta del producto',
			fecha       	AS	 'fecha de la venta',
			hora 			AS	 'hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM venta;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS venta_consultar;
 DELIMITER //
CREATE PROCEDURE venta_consultar(IN id_ven INT)
   BEGIN
		SELECT 
			id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'cantidad de articulos vendidos',
            precio_compra   AS   'precio de compra del producto',
            precio_venta    AS   'precio de venta del producto',
			fecha       	AS	 'fecha de la venta',
			hora 			AS	 'hora de la venta',
			CAST(fecha      AS char) 	AS	 'Fecha de la venta'
		FROM venta 
        WHERE id_venta = id_ven;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS venta_insertar;
 DELIMITER //
CREATE PROCEDURE venta_insertar(
	IN id_reg    	INT,
    IN id_ven	  VARCHAR(12),
    IN id_usu     VARCHAR(15),
    IN id_art 	  VARCHAR(20),
    IN cant       DECIMAL(10,4),
    IN pre_com    DECIMAL(10,4),
    IN pre_ven    DECIMAL(10,4),
    IN fec 		  DATE,
    IN hor 		  VARCHAR(15)
)
   BEGIN
		INSERT INTO venta(
			id_registro, 
			id_venta, 
			id_usuario, 
            id_articulo,
			cantidad, 
            precio_compra,
            precio_venta,
			fecha,
			hora
        ) 
		VALUES(
			id_reg, 
            id_ven, 
            id_usu, 
            cant, 
            pre_com,
            pre_ven,
            fec, 
            hor
		);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS venta_editar;
 DELIMITER //
CREATE PROCEDURE venta_editar(
	IN id_reg    	INT,
    IN id_ven	  VARCHAR(12),
    IN id_usu     VARCHAR(15),
    IN id_art 	  VARCHAR(20),
    IN cant       DECIMAL(10,4),
    IN pre_com    DECIMAL(10,4),
    IN pre_ven    DECIMAL(10,4),
    IN fec 		  DATE,
    IN hor 		  VARCHAR(15)
)
   BEGIN
		UPDATE merma SET 
			id_registro    	=	id_reg, 
			id_venta		=	id_ven, 
            id_usuario      =   id_usu,
            id_articulo 	=	id_art,
			cantidad 		=	cant,
            precio_compra	=	pre_com,
			precio_venta	    =	pre_ven, 
            fecha           =   fec,
			hora			=	hor
		WHERE id_venta = id_ven;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS venta_eliminar;
 DELIMITER //
CREATE PROCEDURE venta_eliminar(IN venta INT)
   BEGIN
		DELETE FROM venta WHERE id_venta = venta;
   END //
DELIMITER ;

#TABLA DEVOLUCIONES***************************************#TABLA DEVOLUCIONES************************************************

DROP PROCEDURE IF EXISTS devoluciones_mostrar;
 DELIMITER //
CREATE PROCEDURE devoluciones_mostrar()
   BEGIN
		SELECT 
			id_reg          AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			motivo	        AS	 'causa por la que se hace la devolucion',
            accion          AS   'forma en la que resuelve el problema',
            descripcion     AS   'precio de venta del producto',
			cantidad      	AS	 'cantidad a devolver',
            fecha           AS   'fecha de la venta',
			hora			AS	 'hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM devolucion;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS devolucion_consultar;
 DELIMITER //
CREATE PROCEDURE devolucion_consultar(IN id_dev INT)
   BEGIN
		SELECT 
			id_reg          AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			motivo	        AS	 'causa por la que se hace la devolucion',
            accion          AS   'forma en la que resuelve el problema',
            descripcion     AS   'precio de venta del producto',
			cantidad      	AS	 'cantidad a devolver',
            fecha           AS   'fecha de la venta',
			hora			AS	 'hora de la venta',
			CAST(fecha      AS char) 	AS	 'Fecha de la venta'
		FROM devolucion
        WHERE id_devolucion = id_dev;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS devolucion_insertar;
 DELIMITER //
CREATE PROCEDURE devolucion_insertar(
	IN id_reg    	INT,
    IN id_ven	  VARCHAR(12),
    IN id_usu     VARCHAR(15),
    IN id_art 	  VARCHAR(20),
    IN mot        VARCHAR(6),
    IN acc        VARCHAR(3),
    IN des        VARCHAR(300),
    IN can	      DECIMAL(10,4),
    IN fec        DATE,
    IN hor 		  VARCHAR(15)
)
   BEGIN
		INSERT INTO venta(
			id_registro, 
			id_venta, 
			id_usuario, 
            id_articulo,
			motivo, 
            accion,
            descripcion,
			cantidad,
            fecha,
			hora
        ) 
		VALUES(
			id_reg, 
            id_ven, 
            id_usu, 
            id_art,
            mot, 
            acc,
            des,
            can, 
            fec,
            hor
		);
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS devolucion_editar;
 DELIMITER //
CREATE PROCEDURE devolucion_editar(
	IN id_reg    	INT,
    IN id_ven	  VARCHAR(12),
    IN id_usu     VARCHAR(15),
    IN id_art 	  VARCHAR(20),
    IN mot        VARCHAR(6),
    IN acc        VARCHAR(3),
    IN des        VARCHAR(300),
    IN can	      DECIMAL(10,4),
    IN fec        DATE,
    IN hor 		  VARCHAR(15)
)
   BEGIN
		UPDATE merma SET 
			id_registro    	=	id_reg, 
			id_venta		=	id_ven, 
            id_usuario      =   id_usu,
            id_articulo 	=	id_art,
			motivo		    =	mot,
            accion      	=	acc,
			descripcion	    =	des, 
            cantidad        =   can,
            fecha           =   fec,
			hora			=	hor
		WHERE id_devolucion = id_dev;
   END //
DELIMITER ;



DROP PROCEDURE IF EXISTS devolucion_eliminar;
 DELIMITER //
CREATE PROCEDURE devolucion_eliminar(IN devolucion INT)
   BEGIN
		DELETE FROM devolucion WHERE id_devolucion = devolucion;
   END //
DELIMITER ;