create database dbagenda;

use dbagenda;

create table tbusuarios(
nome VARCHAR(80) NOT NULL,
usuario VARCHAR(20) NOT NULL primary key,
senha VARCHAR(20) NOT NULL);


create table tbcategorias(
	categorias VARCHAR(40) NOT NULL,
	cod_categoria INT AUTO_INCREMENT primary key,
    usuario varchar (20) 
    );

delimiter $$
create trigger trinsertcategoria
	before
	insert
	on tbcategoria
	for each row
begin 
	set new.usuario = CURRENT_USER();
end;

$$

delimiter ;

select * from tbusuarios;

select * from mySql.user;

select cod_categoria AS 'Código', categorias AS 'Categoria'
from tbcategorias;