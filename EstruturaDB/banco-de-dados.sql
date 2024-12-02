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
	on tbcategorias
	for each row
begin 
	set new.usuario = CURRENT_USER();
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
	on tbcategorias
	for each row
begin 
	set new.usuario = USER();
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

create table tbcontatos(
	cod_contato INT AUTO_INCREMENT primary key,
	nome VARCHAR(80) NOT NULL,
    categoria VARCHAR(100) NOT NULL
    );

-- trigger pra add contato

delimiter $$
create trigger trlogaddcontato
	after
	update
	on tbcontatos
	for each row
begin 
	insert into tblog
		(usuario,
        ultima_alteracao,
        descricao)
        
	values
    (USER(),
    CURRENT_TIMESTAMP(),
    CONCAT('O contato ', NEW.nome, ' foi adicionado'));
    
end;

$$

delimiter ;

-- trigger para alterar contato

delimiter $$
create trigger trlogcontatoupdate
	after
	update
	on tbcontatos
	for each row
begin 
	insert into tblog
		(usuario,
        ultima_alteracao,
        descricao)
        
	values
    (USER(),
    CURRENT_TIMESTAMP(),
    CONCAT('O contato ', OLD.nome, ' foi alterado para ', NEW.nome));
    
end;

$$

delimiter ;

-- trigger para excluir contato

delimiter $$
create trigger trlogcontatodelete
	after
	update
	on tbcontatos
	for each row
begin 
	insert into tblog
		(usuario,
        ultima_alteracao,
        descricao)
        
	values
    (USER(),
    CURRENT_TIMESTAMP(),
    CONCAT('O contato ', OLD.nome, ' foi deletado'));
    
end;

$$

delimiter ;

select * from tblog;

select * from tbcontatos;

UPDATE `dbagenda`.`tbcontatos` 
SET `nome` = 'smt', `categoria` = 'socoror' WHERE (`cod_contato` = '2');

select * from mySql.user;

select cod_categoria AS 'Código', categorias AS 'Categoria'
from tbcategorias;