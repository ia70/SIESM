CREATE DATABASE IF NOT EXISTS siesm;
USE siesm;

CREATE TABLE IF NOT EXISTS articulo (
		id_articulo 	VARCHAR(20),
		nombre		 	VARCHAR(150) NOT NULL,
		descripcion 	VARCHAR(300),
		unidad_medida 	VARCHAR(10),
		precio_compra 	DEC(10,2),
		precio_venta 	DEC(10,2) NOT NULL,
		imagen 			LONGBLOB,
		fecha		 	DATE NOT NULL,
    PRIMARY KEY (id_articulo)
);

CREATE TABLE IF NOT EXISTS inventario (
		id_inventario 	INT AUTO_INCREMENT,
		id_sucursal 	VARCHAR(100),
		id_proveedor 	VARCHAR(30),
		id_usuario 		VARCHAR(15) NOT NULL,
		id_articulo 	VARCHAR(20) NOT NULL,
		existencia 		DEC(10,2),
        nivel_critico 	INT,
        precio_venta 	DEC(10,2),
		condicion 		VARCHAR(16),
        inventario      INT,
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
        tipo			VARCHAR(10),
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
        id_reg          INT AUTO_INCREMENT,
		id_usuario 		VARCHAR(15),
		contrasena 		VARCHAR(15) NOT NULL,
		nombre 			VARCHAR(20) NOT NULL,
		apellidos 		VARCHAR(30) NOT NULL,
		sexo 			VARCHAR(2) NOT NULL,
		tipo 			INT NOT NULL,
		imagen 			LONGBLOB,
		fecha 			DATE NOT NULL,
    PRIMARY KEY (id_reg)
);

CREATE TABLE IF NOT EXISTS merma (
		id_merma 		INT AUTO_INCREMENT,
		id_usuario 		VARCHAR(15) NOT NULL,
        id_sucursal		INT,
		id_articulo 	VARCHAR(20) NOT NULL,
		motivo 			VARCHAR(500) NOT NULL,
		cantidad 		DEC(10,2) NOT NULL,
		fecha 			DATE NOT NULL,
		hora 			VARCHAR(15),
    PRIMARY KEY (id_merma)
);

CREATE TABLE IF NOT EXISTS venta (
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

CREATE TABLE IF NOT EXISTS devolucion (
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

CREATE TABLE IF NOT EXISTS articulo_d (
		id_reg		 	INT AUTO_INCREMENT,
		id_sucursal		VARCHAR(100),
		id_articulo		VARCHAR(20),
		id_defectuoso 	VARCHAR(22),
		precio_venta	DEC(10,2),
		cantidad 		INT,
		fecha 			DATE,
    PRIMARY KEY (id_reg)
);







#    ________________________________________________________________________________________________________________________________________
#   /PROCEDIMIENTOS ALMACENADOS *********PROCEDIMIENTOS ALMACENADOS*********PROCEDIMIENTOS ALMACENADOS********PROCEDIMIENTOS ALMACENADOS*****\
#  --------------------------------------------------------------------------------------------------------------------------------------------


#TABLA ARTICULO_D *********** TABLA ARTICULO_D ***********TABLA ARTICULO_D*********************************************************************************



DROP PROCEDURE IF EXISTS articulo_d_mostrar;
 DELIMITER //
CREATE PROCEDURE articulo_d_mostrar()
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
		FROM articulo_d;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_consultar;
 DELIMITER //
CREATE PROCEDURE articulo_d_consultar(IN id_art VARCHAR(20))
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
		FROM articulo_d 
        WHERE id_articulo = id_art;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_insertar;
 DELIMITER //
CREATE PROCEDURE articulo_d_insertar(
	IN id_re   INT, 
    IN id_suc	VARCHAR(100),
    IN id_art 	VARCHAR(20),
	IN is_def 	VARCHAR(22),
    IN pre_ven 	DEC(10,2),
    IN cant 	INT,
    IN fec 		DATE
)
   BEGIN
		INSERT INTO articulo_d(
			id_reg, 
			id_sucursal, 
			id_articulo, 
			id_defectuoso, 
			precio_venta, 
			cantidad, 
			fecha
            ) 
		VALUES(
			id_suc,
            id_art,
            id_def,
            pre_ven,
            can,
            fec
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_editar;
 DELIMITER //
CREATE PROCEDURE articulo_d_editar(
	IN id_re   INT, 
    IN id_suc	VARCHAR(100),
    IN id_art 	VARCHAR(20),
	IN is_def 	VARCHAR(22),
    IN pre_ven 	DEC(10,2),
    IN cant 	INT,
    IN fec 		DATE
)
   BEGIN
		UPDATE articulo_d SET 
			id_sucursal 	= id_suc, 
			id_articulo		=id_art, 
			id_defectuoso	=id_def, 
			precio_venta	=pre_ven, 
			cantidad		=can, 
			fecha			=fec
		WHERE id_reg  = id_re;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_eliminar;
 DELIMITER //
CREATE PROCEDURE articulo_d_eliminar(IN ID VARCHAR(20))
   BEGIN
		DELETE FROM articulo_d WHERE id_articulo = ID;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_inicio;
 DELIMITER //
CREATE PROCEDURE articulo_d_inicio()
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
        FROM articulo_d LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_final;
 DELIMITER //
CREATE PROCEDURE articulo_d_final()
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
        FROM articulo_d ORDER BY id_reg DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_siguiente;
 DELIMITER //
CREATE PROCEDURE articulo_d_siguiente(
	IN id VARCHAR(20)
)
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
        FROM articulo_d WHERE id_reg > id ORDER BY id_reg ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_atras;
 DELIMITER //
CREATE PROCEDURE articulo_d_atras(
	IN id VARCHAR(20)
)
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
        FROM articulo_d WHERE id_reg < id ORDER BY id_reg DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_d_filtrar;
 DELIMITER //
CREATE PROCEDURE articulo_d_filtrar(
	IN nom VARCHAR(150)
)
   BEGIN
		SELECT 
			id_reg 			AS	 '#',
			id_sucursal		AS	 'Sucursal',
			id_articulo 	AS	 'Articulo',
			id_defectuoso 	AS	 'Articulo defectuoso',
			precio_venta 	AS	 'Precio de venta',
			cantidad 		AS	 'Cantidad',
			CAST(fecha AS char) AS	 'Fecha de registro'
        FROM articulo_d WHERE id_articulo LIKE CONCAT('%',nom,'%') LIMIT 5;
   END //
DELIMITER ;



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
	IN id   	VARCHAR(20), 
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
			id, 
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
	IN id   	VARCHAR(20), 
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
		WHERE id_articulo  = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_eliminar;
 DELIMITER //
CREATE PROCEDURE articulo_eliminar(IN ID VARCHAR(20))
   BEGIN
		DELETE FROM articulo WHERE id_articulo = ID;
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
	IN id VARCHAR(20)
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
        FROM articulo WHERE id_articulo > id ORDER BY id_articulo ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_atras;
 DELIMITER //
CREATE PROCEDURE articulo_atras(
	IN id VARCHAR(20)
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
        FROM articulo WHERE id_articulo < id ORDER BY id_articulo DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS articulo_filtrar;
 DELIMITER //
CREATE PROCEDURE articulo_filtrar(
	IN nom VARCHAR(150)
)
   BEGIN
		SELECT 
			id_articulo 	AS 	"ID",
			nombre			AS 	"Nombre del articulo",
            descripcion 	AS  "Descripción"
        
        FROM articulo WHERE descripcion LIKE CONCAT('%',nom,'%') LIMIT 5;
   END //
DELIMITER ;



#TABLA INVENTARIO ***********TABLA INVENTARIO************TABLA INVENTARIO****************************************************************************

DROP PROCEDURE IF EXISTS inventario_articulo;
 DELIMITER //
CREATE PROCEDURE inventario_articulo(IN ID VARCHAR(100))
   BEGIN
   
		SELECT 
        id_articulo 	AS 'id_articulo',
        descripcion 	AS 'nombre',
		id_proveedor 	AS 'Proveedor',
        existencia 		AS 'Existencia'
		FROM inventario;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS inf_inventario_mostrar;
 DELIMITER //
CREATE PROCEDURE inf_inventario_mostrar(IN ID VARCHAR(100))
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
        WHERE inventario.id_sucursal = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_mostrar;
 DELIMITER //
CREATE PROCEDURE inventario_mostrar(IN ID VARCHAR(100))
   BEGIN
		SELECT 
			id_inventario			AS  'ID',
			id_sucursal				AS  'Sucursal',
			id_proveedor 			AS  'Proveedor',
			id_usuario				AS  'Usuario',
			id_articulo				AS  'Articulo',
			existencia				AS  'Existencia',
            nivel_critico			AS  'Nivel Critico',
			condicion				AS  'Condición',
			CAST(fecha AS CHAR) 	AS  'Fecha de registro'
		FROM inventario;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS inventario_consultar;
 DELIMITER //
CREATE PROCEDURE inventario_consultar(IN ID VARCHAR(100))
   BEGIN
		SELECT 
			id_inventario			AS  'ID',
			id_sucursal				AS  'Sucursal',
			id_proveedor 			AS  'Proveedor',
			id_usuario				AS  'Usuario',
			id_articulo				AS  'Articulo',
			existencia				AS  'Existencia',
            nivel_critico			AS  'Nivel Critico',
			condicion				AS  'Condición',
			CAST(fecha AS CHAR) 	AS  'Fecha de registro'
		FROM inventario
        WHERE id_inventario = id;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS inventario_insertar;
 DELIMITER //
CREATE PROCEDURE inventario_insertar(
	IN id   	INT,
    IN id_suc 	INT,
    IN id_pro 	INT,
    IN id_usu	VARCHAR(15),
    IN id_art	VARCHAR(20),
    IN exi	    DEC(10,2),
    IN niv_cri  INT,
    IN con 		VARCHAR(16),
    IN fec	 	DATE
)
   BEGIN
		INSERT INTO inventario(
			id_sucursal, 
			id_proveedor, 
			id_usuario, 
			id_articulo, 
			existencia,
            nivel_critico,
            condicion,
			fecha
        ) 
		VALUES(
            id_suc, 
            id_pro, 
            id_usu, 
            id_art, 
            exi,
            niv_cri,
            con,
            fec
		);
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_editar;
 DELIMITER //
CREATE PROCEDURE inventario_editar(
	IN id   	INT, 
    IN id_suc 	INT,
    IN id_pro	INT,
    IN id_usu	VARCHAR(15),
    IN id_art	VARCHAR(20),
    IN exi	    DEC(10,2),
    IN niv_cri	INT,
    IN con 		VARCHAR(16),
    IN fec 		DATE
)
   BEGIN
		UPDATE inventario SET 
			id_sucursal		    =	id_suc, 
            id_proveedor	    =	id_pro,
			id_usuario	        =	id_usu,
            id_articulo		    =   id_art,
			existencia			=	exi, 
            nivel_critico		=	niv_cri,
			condicion			=	con,
            fecha               =	fec
		WHERE id_inventario = id;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS inventario_eliminar;
 DELIMITER //
CREATE PROCEDURE inventario_eliminar(IN ID VARCHAR(100))
   BEGIN
		DELETE FROM inventario WHERE id_inventario = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_inicio;
 DELIMITER //
CREATE PROCEDURE inventario_inicio(IN ID VARCHAR(100))
   BEGIN
		SELECT 
			id_inventario			AS  'ID',
			id_sucursal				AS  'Sucursal',
			id_proveedor 			AS  'Proveedor',
			id_usuario				AS  'Usuario',
			id_articulo				AS  'Articulo',
			existencia				AS  'Existencia',
            nivel_critico			AS  'Nivel Critico',
			condicion				AS  'Condición',
			CAST(fecha AS CHAR) 	AS  'Fecha de registro'
		FROM inventario LIMIT 0,1;

   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_final;
 DELIMITER //
CREATE PROCEDURE inventario_final(IN ID VARCHAR(100))
   BEGIN
		SELECT 
			id_inventario			AS  'ID',
			id_sucursal				AS  'Sucursal',
			id_proveedor 			AS  'Proveedor',
			id_usuario				AS  'Usuario',
			id_articulo				AS  'Articulo',
			existencia				AS  'Existencia',
            nivel_critico			AS  'Nivel Critico',
			condicion				AS  'Condición',
			CAST(fecha AS CHAR) 	AS  'Fecha de registro'
		FROM inventario ORDER BY id_articulo DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_siguiente;
 DELIMITER //
CREATE PROCEDURE inventario_siguiente(
	IN ID INT
)
   BEGIN
		SELECT 
			id_inventario			AS  'ID',
			id_sucursal				AS  'Sucursal',
			id_proveedor 			AS  'Proveedor',
			id_usuario				AS  'Usuario',
			id_articulo				AS  'Articulo',
			existencia				AS  'Existencia',
            nivel_critico			AS  'Nivel Critico',
			condicion				AS  'Condición',
			CAST(fecha AS CHAR) 	AS  'Fecha de registro'
		FROM inventario WHERE id_inventario > ID ORDER BY id_inventario ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS inventario_atras;
 DELIMITER //
CREATE PROCEDURE inventario_atras(
	IN ID INT
)
   BEGIN
		SELECT 
			id_inventario			AS  'ID',
			id_sucursal				AS  'Sucursal',
			id_proveedor 			AS  'Proveedor',
			id_usuario				AS  'Usuario',
			id_articulo				AS  'Articulo',
			existencia				AS  'Existencia',
            nivel_critico			AS  'Nivel Critico',
			condicion				AS  'Condición',
			CAST(fecha AS CHAR) 	AS  'Fecha de registro'
		FROM inventario WHERE id_inventario < ID ORDER BY id_inventario DESC LIMIT 1;
   END //
DELIMITER ;





#TABLA SUCURSAL ************TABLA SUCURSAL************TABLA SUCURSAL*********************************************************************************


DROP PROCEDURE IF EXISTS sucursal_mostrar;
 DELIMITER //
CREATE PROCEDURE sucursal_mostrar()
   BEGIN
		SELECT 
			id_sucursal		AS	 'ID',
			nombre 			AS	 'Nombre',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			imagen 			AS	 'Imagen',
            tipo			AS 	 'Tipo',
			CAST(fecha AS char) 	AS	 'Fecha de registró'
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
			tipo			AS 	 'Tipo',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM sucursal
        WHERE id_sucursal = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_insertar;
 DELIMITER //
CREATE PROCEDURE sucursal_insertar(
	IN id   	INT,
    IN nom 		VARCHAR(30),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel 		VARCHAR(12),
    IN ima 		LONGBLOB,
    IN tip		VARCHAR(10),
    IN fec 		DATE
)
   BEGIN
		INSERT INTO sucursal(
			nombre, 
			direccion, 
			descripcion, 
			telefono, 
			imagen, 
            tipo,
			fecha
        ) 
		VALUES(
            nom, 
            dir, 
            des, 
            tel, 
            ima, 
            tip,
            fec
		);
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_editar;
 DELIMITER //
CREATE PROCEDURE sucursal_editar(
	IN id 		INT, 
    IN nom	 	VARCHAR(100),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel		VARCHAR(12),
    IN ima 		LONGBLOB,
    IN tip		VARCHAR(10),
    IN fec 		DATE
)
   BEGIN
		UPDATE sucursal SET 
			nombre			=	nom, 
            direccion		=	dir,
			descripcion		=	des,
            telefono		=	tel,
			imagen			=	ima, 
            tipo			=	tip,
			fecha			=	fec
		WHERE id_sucursal = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_eliminar;
 DELIMITER //
CREATE PROCEDURE sucursal_eliminar(IN id INT)
   BEGIN
		DELETE FROM sucursal WHERE id_sucursal = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_inicio;
 DELIMITER //
CREATE PROCEDURE sucursal_inicio()
   BEGIN
		SELECT 
            id_sucursal		AS	 'ID',
			nombre 			AS	 'Sucursal',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			imagen 			AS	 'Imagen',
            tipo			AS   'Tipo',
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM sucursal LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_final;
 DELIMITER //
CREATE PROCEDURE sucursal_final()
   BEGIN
		SELECT 
			id_sucursal		AS	 'ID',
			nombre 			AS	 'Sucursal',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			imagen 			AS	 'Imagen',
			tipo			AS   'Tipo',
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM sucursal ORDER BY id_sucursal DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_siguiente;
 DELIMITER //
CREATE PROCEDURE sucursal_siguiente(
	IN id VARCHAR(20)
)
   BEGIN
		SELECT 
			id_sucursal		AS	 'ID',
			nombre 			AS	 'Sucursal',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			imagen 			AS	 'Imagen',
			tipo			AS   'Tipo',
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM sucursal WHERE id_sucursal > id ORDER BY id_sucursal ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_atras;
 DELIMITER //
CREATE PROCEDURE sucursal_atras(
	IN id VARCHAR(20)
)
BEGIN
		SELECT 
			id_sucursal		AS	 'ID',
			nombre 			AS	 'Sucursal',
			direccion 		AS	 'Dirección',
			descripcion 	AS	 'Descripción',
			telefono 		AS	 'Teléfono',
			imagen 			AS	 'Imagen',
            tipo			AS   'Tipo',
        CAST(fecha AS CHAR) AS "Fecha" 
        FROM sucursal WHERE id_sucursal < ID ORDER BY id_sucursal DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS sucursal_filtrar;
 DELIMITER //
CREATE PROCEDURE sucursal_filtrar(
	IN nom VARCHAR(100)
)
   BEGIN
		SELECT 
			id_sucursal 	AS 	"ID",
			nombre			AS 	"Nombre de la sucursal"
        FROM sucursal WHERE nombre LIKE CONCAT('%',nom,'%') LIMIT 5;
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
	IN id		INT,
    IN nom 		VARCHAR(30),
    IN dir 		VARCHAR(500),
    IN des 		VARCHAR(300),
    IN tel 		VARCHAR(12),
    IN fec 		DATE
)
   BEGIN
		INSERT INTO proveedor(
            nombre, 
            direccion, 
            descripcion, 
            telefono, 
            fecha
		) 
		VALUES(
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
	IN id		INT,
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
            descripcion	=	des,  
			telefono	=	tel, 
			fecha		=	fec
		WHERE id_proveedor = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS proveedor_eliminar;
 DELIMITER //
CREATE PROCEDURE proveedor_eliminar(IN id INT)
   BEGIN
		DELETE FROM proveedor WHERE id_proveedor=id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS proveedor_inicio;
 DELIMITER //
CREATE PROCEDURE proveedor_inicio()
   BEGIN
		SELECT 
			id_proveedor 		AS	 'ID',
			nombre 				AS	 'Proveedor',
			direccion 			AS	 'Dirección',
			descripcion 		AS	 'Descripción',
			telefono 			AS	 'Teléfono',
			CAST(fecha AS char) AS	 'Fecha en que se registró'
        FROM  proveedor
        LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS proveedor_final;
 DELIMITER //
CREATE PROCEDURE proveedor_final()
   BEGIN
		SELECT 
			id_proveedor 		AS	 'ID',
			nombre 				AS	 'Proveedor',
			direccion 			AS	 'Dirección',
			descripcion 		AS	 'Descripción',
			telefono 			AS	 'Teléfono',
			CAST(fecha AS char) AS	 'Fecha en que se registró'
        FROM proveedor ORDER BY id_proveedor DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS proveedor_siguiente;
 DELIMITER //
CREATE PROCEDURE proveedor_siguiente(
	IN id INT
)
   BEGIN
		SELECT 
			id_proveedor 		AS	 'ID',
			nombre 				AS	 'Proveedor',
			direccion 			AS	 'Dirección',
			descripcion 		AS	 'Descripción',
			telefono 			AS	 'Teléfono',
			CAST(fecha AS char) AS
	 'Fecha en que se registró'
        FROM proveedor WHERE id_proveedor > id ORDER BY id_proveedor ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS proveedor_atras;
 DELIMITER //
CREATE PROCEDURE proveedor_atras(
	IN id INT
)
   BEGIN
		SELECT 
			id_proveedor 		AS	 'ID',
			nombre 				AS	 'Proveedor',
			direccion 			AS	 'Dirección',
			descripcion 		AS	 'Descripción',
			telefono 			AS	 'Teléfono',
			CAST(fecha AS char) AS	 'Fecha en que se registró'
        FROM proveedor WHERE id_proveedor < id ORDER BY id_proveedor DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS proveedor_filtrar;
 DELIMITER //
CREATE PROCEDURE proveedor_filtrar(
	IN nom VARCHAR(30)
)
   BEGIN
		SELECT 
			id_proveedor 	AS 	"ID",
			nombre			AS 	"Nombre del proveedor"
        FROM proveedor WHERE nombre LIKE CONCAT('%',nom,'%') LIMIT 5;
   END //
DELIMITER ;


#TABLA USUARIO ***********TABLA USUARIO*************TABLA USUARIO************************************************************************************


DROP PROCEDURE IF EXISTS usuario_mostrar;
 DELIMITER //
CREATE PROCEDURE usuario_mostrar()
   BEGIN
		SELECT   
			id_reg          AS	 'Registro',
			id_usuario		AS	 'ID',
			contrasena	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM usuario;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_consultar;
 DELIMITER //
CREATE PROCEDURE usuario_consultar(IN id VARCHAR(15))
   BEGIN
		SELECT 
            id_reg          AS	 'Registro',
			id_usuario		AS	 'ID',
			contrasena	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
		FROM usuario 
        WHERE id_usuario = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_insertar;
 DELIMITER //
CREATE PROCEDURE usuario_insertar(
	IN id   	VARCHAR(15), 
    IN contr 	VARCHAR(15),
    IN nom   	VARCHAR(20),
    IN apell	VARCHAR(30),
	IN sex   	VARCHAR(2),
    IN tip  	INT,
    IN ima 		LONGBLOB,
    IN fec 	DATE
)
   BEGIN
		INSERT INTO usuario(
			id_usuario, 
			contrasena, 
			nombre, 
			apellidos, 
			sexo, 
			tipo, 
			imagen, 
			fecha
            ) 
		VALUES(
			id, 
			contr, 
			nom,
		    apell, 
			sex, 
			tip, 
			ima, 
			fec
            );
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_editar;
 DELIMITER //
CREATE PROCEDURE usuario_editar(
	IN id       VARCHAR(15), 
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
			contrasena      =   contr, 
            nombre      	= 	nom, 
			apellidos   	= 	apell, 
			nivel_critico 	= 	niv_cri,
			sexo        	= 	sex,
			tipo        	= 	tip,
			imagen 			= 	ima, 
			fecha		 	= 	fec
		WHERE id_usurio = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_eliminar;
 DELIMITER //
CREATE PROCEDURE usuario_eliminar(IN id VARCHAR(15))
   BEGIN
		DELETE FROM usuario WHERE id_usuario = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_inicio;
 DELIMITER //
CREATE PROCEDURE usuario_inicio()
   BEGIN
		SELECT 
			id_reg      	AS	 'Registro',
			id_usuario		AS	 'ID',
			contrasena	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
        FROM  usuario
        LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_final;
 DELIMITER //
CREATE PROCEDURE usuario_final()
   BEGIN
		SELECT 
            id_reg      	AS	 'Registro',
	 		id_usuario		AS	 'ID',
			contrasena	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
        FROM usuario ORDER BY id_reg DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_siguiente;
 DELIMITER //
CREATE PROCEDURE usuario_siguiente(
	IN id INT
)
   BEGIN
		SELECT 
			id_reg          AS	 'Registro',
			id_usuario		AS	 'ID',
			contrasena	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
        FROM usuario WHERE id_reg > id ORDER BY id_reg ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_atras;
 DELIMITER //
CREATE PROCEDURE usuario_atras(
	IN id VARCHAR(15)
)
   BEGIN
		SELECT 
            id_reg          AS	 'Registro',
			id_usuario		AS	 'ID',
			contrasena	    AS	 'Contraseña',
			nombre 		    AS	 'Nombre',
			apellidos	    AS	 'Apellidos',
            sexo            AS   'Sexo',
			tipo 		    AS	 'Tipo',
			imagen 			AS	 'Imagen',
			CAST(fecha AS char) 	AS	 'Fecha en que se registró'
        FROM usuario WHERE id_reg < id ORDER BY id_reg DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS usuario_filtrar;
 DELIMITER //
CREATE PROCEDURE usuario_filtrar(
	IN nom VARCHAR(20)
)
   BEGIN
		SELECT 
			id_usuario 	AS 	"ID",
			nombre		AS 	"Nombre del articulo",
            apellidos 	AS 	"Apellidos"
        FROM usuario WHERE nombre LIKE CONCAT('%',nom,'%') LIMIT 5;
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
            id_articulo     AS   'ID',
            id_sucursal     AS   'ID',
			motivo      	AS	 'Motivo de entrada a merma',
			cantidad	    AS	 'Cantidad de articulos',
			hora 			AS	 'Hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
		FROM merma;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_consultar;
 DELIMITER //
CREATE PROCEDURE merma_consultar(IN id INT)
   BEGIN
		SELECT 
			id_merma     	AS	 'ID',
			id_usuario      AS	 'ID',
            id_articulo     AS   'ID',
            id_sucursal     AS   'ID',
			motivo      	AS	 'motivo de entrada a merma',
			cantidad	    AS	 'cantidad de articulos',
			hora 			AS	 'hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
		FROM merma 
        WHERE id_merma = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_insertar;
 DELIMITER //
CREATE PROCEDURE merma_insertar(
	IN id 		INT,
    IN id_usu	VARCHAR(15),
    IN id_art   VARCHAR(20),
    IN id_suc   INT,
    IN mot 		VARCHAR(500),
    IN cant     DECIMAL(10,4),
    IN hor 		VARCHAR(15),
    IN fec    DATE
)
   BEGIN
		INSERT INTO merma(
			id_usuario, 
			id_articulo, 
            id_sucursal,
			motivo, 
			cantidad, 
			fecha,
			hora
        ) 
		VALUES(
            id_usu, 
            id_art,
            id_suc, 
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
	IN id    	INT,
    IN id_usu	VARCHAR(15),
    IN id_art   VARCHAR(20),
    IN id_suc   VARCHAR(20),
    IN mot 		VARCHAR(500),
    IN cant     DECIMAL(10,4),
    IN hor 		VARCHAR(15),
    IN fec 		DATE
)
   BEGIN
		UPDATE merma SET 
			id_usuario		=	id_usu, 
            id_articulo		=	id_art,
            id_sucursal		=	id_suc,
			motivo   		=	mot,
            cantidad 		=	cant,
			hora			=	hor,
            fecha			=	fec
            WHERE id_merma = id;

   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_eliminar;
 DELIMITER //
CREATE PROCEDURE merma_eliminar(IN id INT)
   BEGIN
		DELETE FROM merma WHERE id_merma = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_inicio;
 DELIMITER //
CREATE PROCEDURE merma_inicio()
   BEGIN
		SELECT 
            id_merma     	AS	 'ID',
			id_usuario      AS	 'ID',
            id_articulo     AS	 'ID',
            id_sucursal     AS	 'ID',
			motivo      	AS	 'Motivo de entrada a merma',
			cantidad	    AS	 'Cantidad de articulos',
			hora 			AS	 'Hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
		FROM merma
        LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_final;
 DELIMITER //
CREATE PROCEDURE merma_final()
   BEGIN
		SELECT 
            id_merma     	AS	 'ID',
			id_usuario      AS	 'ID',
            id_articulo     AS	 'ID',
            id_sucursal     AS	 'ID',
			motivo      	AS	 'Motivo de entrada a merma',
			cantidad	    AS	 'Cantidad de articulos',
			hora 			AS	 'Hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
		FROM merma ORDER BY id_merma DESC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_siguiente;
 DELIMITER //
CREATE PROCEDURE merma_siguiente(
	IN id INT
)
   BEGIN
		SELECT 
            id_usuario      AS	 'ID',
            id_articulo     AS	 'ID',
            id_sucursal     AS	 'ID',
			motivo      	AS	 'Motivo de entrada a merma',
			cantidad	    AS	 'Cantidad de articulos',
			hora 			AS	 'Hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
		FROM merma WHERE id_merma > id ORDER BY id_merma ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS merma_atras;
 DELIMITER //
CREATE PROCEDURE merma_atras(
	IN id INT
)
   BEGIN
		SELECT 
            id_usuario      AS	 'ID',
            id_articulo     AS	 'ID',
            id_sucursal     AS	 'ID', 
			motivo      	AS	 'Motivo de entrada a merma',
			cantidad	    AS	 'Cantidad de articulos',
			hora 			AS	 'Hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
		FROM merma WHERE id_merma > id ORDER BY id_merma ASC LIMIT 1;
   END //
DELIMITER ;

DROP PROCEDURE IF EXISTS merma_filtrar;
 DELIMITER //
CREATE PROCEDURE merma_filtrar(
	IN id VARCHAR(20)
)
   BEGIN
		SELECT 
			id_merma     	AS	 'ID',
			id_usuario      AS	 'ID',
            id_articulo     AS	 'ID',
            id_sucursal     AS	 'ID',
			motivo      	AS	 'Motivo de entrada a merma',
			cantidad	    AS	 'Cantidad de articulos',
			hora 			AS	 'Hora de registro',
			CAST(fecha AS char) 	AS	 'Fecha de registro'
FROM merma WHERE id_merma > id ORDER BY id_merma ASC LIMIT 1;  
   END //
DELIMITER ;










# TABLA VENTA ************************************ #TABLA VENTA*****************************************************************


DROP PROCEDURE IF EXISTS venta_mostrar;
 DELIMITER //
CREATE PROCEDURE venta_mostrar()
   BEGIN
		SELECT 
			id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM venta;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_consultar;
 DELIMITER //
CREATE PROCEDURE venta_consultar(IN id INT)
   BEGIN
		SELECT 
			id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha      AS char) 	AS	 'Fecha de la venta'
		FROM venta 
        WHERE id_venta = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_insertar;
 DELIMITER //
CREATE PROCEDURE venta_insertar(
	IN id    	  INT,
    IN id_ven	  VARCHAR(12),
    IN id_usu     VARCHAR(15),
    IN id_art 	  VARCHAR(20),
    IN cant       DECIMAL(10,2),
    IN pre_com    DECIMAL(10,2),
    IN pre_ven    DECIMAL(10,2),
    IN fec 		  DATE,
    IN hor 		  VARCHAR(15)
)
   BEGIN
		INSERT INTO venta(
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
            id_ven, 
            id_usu,
            id_art,
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
	IN id   	  INT,
    IN id_ven	  VARCHAR(12),
    IN id_usu     VARCHAR(15),
    IN id_art 	  VARCHAR(20),
    IN cant       DECIMAL(10,2),
    IN pre_com    DECIMAL(10,2),
    IN pre_ven    DECIMAL(10,2),
    IN fec 		  DATE,
    IN hor 		  VARCHAR(15)
)
   BEGIN
		UPDATE venta SET 
			id_venta		=	id_ven, 
            id_usuario      =   id_usu,
            id_articulo 	=	id_art,
			cantidad 		=	cant,
            precio_compra	=	pre_com,
			precio_venta	=	pre_ven, 
            fecha           =   fec,
			hora			=	hor
		WHERE id_venta = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_eliminar;
 DELIMITER //
CREATE PROCEDURE venta_eliminar(IN id INT)
   BEGIN
		DELETE FROM venta WHERE id_venta = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_inicio;
 DELIMITER //
CREATE PROCEDURE venta_inicio()
   BEGIN 
		SELECT 
            id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'cantidad de articulos vendidos',
            precio_compra   AS   'precio de compra del producto',
            precio_venta    AS   'precio de venta del producto',
			hora 			AS	 'hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM venta
        LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_final;
 DELIMITER //
CREATE PROCEDURE venta_final()
   BEGIN
		SELECT 
            id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM venta WHERE id_venta > id_ven ORDER BY id_venta ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_siguiente;
 DELIMITER //
CREATE PROCEDURE venta_siguiente(
	IN id VARCHAR(12)
)
   BEGIN
		SELECT 
            id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM venta WHERE id_venta > id ORDER BY id_venta ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS venta_atras;
 DELIMITER //
CREATE PROCEDURE venta_atras(
	IN id INT
)
   BEGIN
		SELECT 
            id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM venta WHERE id_venta > id ORDER BY id_venta ASC LIMIT 1;
   END //
DELIMITER ;



#TABLA DEVOLUCIONES***************************************#TABLA DEVOLUCIONES************************************************


DROP PROCEDURE IF EXISTS devolucion_mostrar;
 DELIMITER //
CREATE PROCEDURE devolucion_mostrar()
   BEGIN
		SELECT 
			id_reg          AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			motivo	        AS	 'Causa por la que se hace la devolucion',
            accion          AS   'Forma en la que resuelve el problema',
            descripcion     AS   'Precio de venta del producto',
			cantidad      	AS	 'Cantidad a devolver',
			hora			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM devolucion;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_consultar;
 DELIMITER //
CREATE PROCEDURE devolucion_consultar(IN id INT)
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
			hora			AS	 'hora de la venta',
			CAST(fecha      AS char) 	AS	 'Fecha de la venta'
		FROM devolucion
        WHERE id_devolucion = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_insertar;
 DELIMITER //
CREATE PROCEDURE devolucion_insertar(
	IN id       	INT,
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
		INSERT INTO devolucion(
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
	IN id         INT,
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
		UPDATE devolucion SET 
			id_venta		=	id_ven, 
            id_usuario      =   id_usu,
            id_articulo 	=	id_art,
			motivo		    =	mot,
            accion      	=	acc,
			descripcion	    =	des, 
            cantidad        =   can,
            fecha           =   fec,
			hora			=	hor
		WHERE id_devolucion = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_eliminar;
 DELIMITER //
CREATE PROCEDURE devolucion_eliminar(IN id INT)
   BEGIN
		DELETE FROM devolucion WHERE id_devolucion = id;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_inicio;
 DELIMITER //
CREATE PROCEDURE devolucion_inicio()
   BEGIN 
		SELECT
            id_reg          AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			motivo	        AS	 'Causa por la que se hace la devolucion',
            accion          AS   'Forma en la que resuelve el problema',
            descripcion     AS   'Precio de venta del producto',
			cantidad      	AS	 'Cantidad a devolver',
			hora			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM devolucion
        LIMIT 0,1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_final;
 DELIMITER //
CREATE PROCEDURE devolucion_final()
   BEGIN
		SELECT 
           id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM devolucion WHERE id_devolucion > id_dev ORDER BY id_devolucion ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_siguiente;
 DELIMITER //
CREATE PROCEDURE devolucion_siguiente(
	IN id VARCHAR(12)
)
   BEGIN
		SELECT 
            id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM devolucion WHERE id_devolucion > id ORDER BY id_dev ASC LIMIT 1;
   END //
DELIMITER ;


DROP PROCEDURE IF EXISTS devolucion_atras;
 DELIMITER //
CREATE PROCEDURE devolucion_atras(
	IN id INT
)
   BEGIN
		SELECT 
            id_registro     AS	 'ID',
			id_venta        AS	 'ID',
            id_usuario      AS   'ID',
            id_articulo     AS   'ID',
			cantidad	    AS	 'Cantidad de articulos vendidos',
            precio_compra   AS   'Precio de compra del producto',
            precio_venta    AS   'Precio de venta del producto',
			hora 			AS	 'Hora de la venta',
			CAST(fecha AS char) 	AS	 'Fecha de la venta'
		FROM devolucion WHERE id_devolucion > id ORDER BY id_devolucion ASC LIMIT 1;
   END //
DELIMITER ;