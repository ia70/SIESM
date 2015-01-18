#DROP DATABASE IF EXISTS SIESM;
create database if not exists siesm;
use siesm;

create table if not exists articulo (
	id_articulo varchar(20) not null,
    nombre_corto varchar(15) not null,
    nombre_largo varchar(30) not null,
    descripcion varchar(120),
    imagen mediumblob,
    fecha_registro date,
    primary key (id_articulo)
);

create table if not exists inventario (
	id_registro int not null auto_increment,
    id_sucursal int not null,
    id_proveedor int not null,
    id_articulo varchar(20),
    unidad_medida varchar(10),
    existencia decimal(5,2),
    nivel_critico int,
    precio_compra decimal(5,2),
    precio_venta decimal(5,2),
    fecha_surtido date,
    primary key (id_registro)
);

create table if not exists sucursal (
	id_sucursal int not null auto_increment,
	nombre varchar(30) not null,
    direccion varchar(250),
    descripcion varchar(250),
    telefono varchar(12),
    imagen mediumblob,
    fecha_registro date,
    primary key (id_sucursal)
);

create table if not exists proveedor (
	id_proveedor int not null auto_increment,
	nombre varchar(30) not null,
    direccion varchar(250),
    descripcion varchar(250),
    telefono varchar(12),
    fecha_registro date,
    primary key (id_proveedor)
);