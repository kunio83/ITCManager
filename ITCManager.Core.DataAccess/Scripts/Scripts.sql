USE [ITC_DBPOwer]
GO
CREATE PROCEDURE getJefesVentas
AS
BEGIN
 SELECT 
	re.IdRolEmpleado,
	p.Apellido
 FROM 
	RolEmpleado re
	left join Persona p on re.IdPersona = p.IdPersona
	left join RolVendedor rv on re.IdRolEmpleado = rv.IdRolEmpleado
 where re.IdPuesto in (select IdPuesto from PuestoSet where DetallePuesto like '%gerente%')
	
END
GO
