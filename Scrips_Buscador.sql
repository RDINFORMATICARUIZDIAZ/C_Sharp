create proc BuscarPersonal


@Desde int,
@Hasta int,
@Buscardor varchar(50)
as
set nocount on;
Select
Id_Personal,
Nombres,
Identificacion,
Cargo,
Id_Cargo,
Estado,
Codigo

From

(select Id_personal,Nombres,Identificacion,Personal.SueldoPorHora,Cargo.Cargo,Personal.Id_cargo, Estado, Codigo,
Row_Number() Over(Order By Id_personal) 'Numero_de_Fila'
from Personal
inner join Cargo on Cargo.Id_cargo=Personal.Id_cargo) As Paginado

where (Paginado.Numero_de_Fila >=@Desde) and (Paginado.Numero_de_Fila <=@Hasta)
and (Nombres + Identificacion Like '%' + @Buscardor + '%')