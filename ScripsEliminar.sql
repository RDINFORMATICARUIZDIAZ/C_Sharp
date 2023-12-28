create proc eliminarPersonal

@Id_Personal int
as
update Personal set Estado = 'Eliminado'
where Id_personal= @Id_Personal