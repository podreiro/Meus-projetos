drop schema if exists lojainformatica;

create database lojainformatica;

use lojainformatica;

create table clientes
(
idclientes int primary key auto_increment,
nome varchar(100) not null,
cpf char(14) not null,
email varchar (100) not null,
endereco varchar(200) not null
);

create table vendas
(
idvendas int primary key auto_increment,
fk_idaclfkclientePRIMARYientes int not null,
fk_idprodutos int not null,
quantidade int not null,
precounitario decimal(8,2),
total decimal(8,2) 
);

alter table vendas add constraint fkcliente
foreign key (fk_idaclientes) references clientes(idclientes);

alter table vendas add constraint fkproduto
foreign key (fk_idprodutos) references produtos(idprodutos);

create table produtos
(
idprodutos int primary key auto_increment,
descricao varchar (100) not null,
categoria varchar (50) not null,
precocompa decimal(8,2) not null,
precovenda decimal(8,2) not null,
qtdeestoque int not null
);