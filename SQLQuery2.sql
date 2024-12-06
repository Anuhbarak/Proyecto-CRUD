create database Persona;
use Persona;
create table persona(
id_persona int identity(1,1),
nombre varchar(50) not null,
edad int not null,
celular varchar(10)
constraint PK_persona primary key(id_persona));

select * from Persona;
exec sp_rename 'Persona.id_persona', 'id';