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
	set new.usuario = USER();
end;tbusuarios

$$

delimiter ;

delimiter $$
create trigger trlogcategoriadelete
	after
	delete
	on tbcategorias
	for each row
begin 
	insert into tblog
		(usuario,
        ultima_alteracao,
        descricao)
        
	values
    (USER(),
    CURRENT_TIMESTAMP(),
    CONCAT('A categoria ', OLD.categorias, ' foi deletada'));
    
end;

$$

delimiter ;

delimiter $$
create trigger trinsertcategoria
	before
	insert
	on tbcategoria
	for each row
begin 
	set new.usuario = CURRENT_USER();
end;tbusuarios

$$

delimiter ;

-- trigger de update
delimiter $$
create trigger trlogcategoriauupdate
	after
	update
	on tbcategorias
	for each row
begin 
	insert into tblog
		(usuario,
        ultima_alteracao,
        descricao)
        
	values
    (USER(),
    CURRENT_TIMESTAMP(),
    CONCAT('A categoria ', OLD.categorias, ' foi alterada'));
    
end;

$$

delimiter ;

-- tabela do log

create table tblog(
	cod_log INT AUTO_INCREMENT primary key,
	usuario VARCHAR(80) NOT NULL,
    ultima_alteracao DATETIME,
    descricao VARCHAR(300) NOT NULL
    );

-- trigger para inserir categorias
delimiter $$
create trigger trlogcategoriainsert
	after
	insert
	on tbcategorias
	for each row
begin 
	insert into tblog
		(usuario,
        ultima_alteracao,
        descricao)
        
	values
    (USER(),
    CURRENT_TIMESTAMP(),
    CONCAT('A categoria ', NEW.categorias, ' foi inserida'));
    
end;

$$

delimiter ;


select * from tblog;

select * from tbusuarios;

select * from mySql.user;

select cod_categoria AS 'Código', categorias AS 'Categoria'
from tbcategorias;