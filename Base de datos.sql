CREATE DATABASE PRESTAMOS

USE PRESTAMOS 

create table Usuarios
(
Id varchar (10) primary key,
Nombre_completo varchar (100),
Rol varchar (50),
Usuario varchar (20),
Contraseña varchar (50),
);

create table Clientes
(
Id int Primary key Identity(1,1),
Nombre_completo varchar (100),
Cedula varchar (13),
FechaNacimiento datetime,
Sexo varchar(15),
);

create table Prestamos
(
Id int Primary key Identity(1,1),
ClienteId int,
CantidadSolicitada decimal (9,2),
Tasa decimal(9,2),
CantidadMeses int,
Estado varchar(1),
);


create proc CrearPrestamo
@id int,
@ClienteId int,
@CantidadSolicitada decimal (9,2),
@Tasa decimal (9,2),
@CantidadMeses int,
@Estado varchar (1)
as
Insert into Prestamos (Id,ClienteId,CantidadSolicitada,CantidadMeses,Estado)
values (@id,@ClienteId,@CantidadSolicitada, @CantidadMeses,@Estado);


ALTER proc [dbo].[CrearUsuario]
@id varchar(10),
@nombre_completo varchar(50),
@usuario varchar (20),
@rol varchar (20),
@clave varchar (50)
as
Insert into Usuarios (Id,Nombre_completo,Rol,Usuario,Contraseña )
values (@id,@nombre_completo,@rol, @usuario,@clave);



ALTER proc [dbo].[Logeo]
@usuario varchar (20),
@rol varchar (20),
@clave varchar (50)
as
select id,nombre_completo,rol,Usuario,Contraseña from usuarios
where Usuario=@usuario and Rol = @rol and Contraseña=@clave