create database sistema_venda;
use sistema_venda;

create table produtos (
id int(10) not null primary key,
nome varchar(20) not null,
preco float(10) not null
);

select * from produtos;

 drop table produtos;