create procedure insertar_cargo
@cargo varchar (max),
@sueldoPorHora numeric (18,2)
as
if EXISTS (select cargo FROM Cargo where cargo=Cargo)
RAISERROR ('YA EXISTE UN CARGO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into Cargo values (@cargo,@sueldoPorHora)


create procedure editar_cargo
@id int,
@cargo varchar (max),
@sueldoPorHora numeric (18,2)
as
if EXISTS (select cargo FROM Cargo where cargo=Cargo and Id_cargo<>@id)
RAISERROR ('YA EXISTE UN CARGO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
Update Cargo set cargo=@cargo, sueldoPorHora=@sueldoPorHora 
where Id_cargo=@id


create proc buscarCargos
@buscador varchar (50)
as
select Id_cargo,cargo,sueldoPorHora as Sueldo from Cargo
where cargo LIKE '%' + @buscador +'%'