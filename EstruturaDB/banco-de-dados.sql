create database dbagenda;

use dbagenda;

select * from tbusuarios;

create table tbusuarios(
nome VARCHAR(80) NOT NULL,
usuario VARCHAR(20) NOT NULL primary key,
senha VARCHAR(20) NOT NULL);

create table tbcategorias(
	categorias VARCHAR(40) NOT NULL,
	cod_categoria INT AUTO_INCREMENT primary key
    );