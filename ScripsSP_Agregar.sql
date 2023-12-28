create proc InsertarPersonal
@Nombres varchar(max),
@Identificacion varchar(max),
@Pais varchar(max),
@id_cargo int,
@SueldoPorHora numeric (18,2)

as
declare @Estado varchar (max)
declare @Codigo varchar (max)
declare @Ide_Personal int
set @Estado='ACTIVO'
set @Codigo = '-'

if exists (select Identificacion from Personal where Identificacion=@Identificacion)
Raiserror ('Ya existe un registro con esa Identificacion',16,1)
else


Insert into Personal Values (@Nombres,@Identificacion,@Pais,@id_cargo,@SueldoPorHora,@Estado,@codigo)


select @Ide_Personal=SCOPE_IDENTITY()

update Personal set codigo=@Ide_Personal
