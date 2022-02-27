create database DBReniec4
go

use DBReniec4

create table datos(
	dni int primary key,
	nombres varchar(50) not null,
	apellidoPaterno varchar(50) not null,
	apellidoMaterno varchar(50) not null,
)
go





insert into datos values(74587458,'pepito','perez','pablito')
insert into datos values(85698569,'ramiro','perez','pablito')
insert into datos values(41254125,'jose','perez','pablito')