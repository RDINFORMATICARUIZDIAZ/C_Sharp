
create proc editarPersonal

@Id_Personal int,
@Nombres as varchar (Max),
@Identificacion as varchar (Max),
@Pais as varchar (Max),
@Id_cargo int,
@SueldoPorHora numeric (18,2)
as

if Exists(Select Identificacion from Personal where Identificacion=@Identificacion and Id_personal<>@Id_Personal)
Raiserror ('Ya existe un registro con esa Identificacion',16,1)
else
update Personal set

Nombres=@Nombres,
Identificacion=@Identificacion,
Pais=@Pais,
Id_cargo=@Id_cargo,
SueldoPorHora=@SueldoPorHora
where Id_personal=@Identificacion

