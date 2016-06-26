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

CREATE PROCEDURE getPersonal
AS
BEGIN
 SELECT 
	re.IdRolEmpleado,
	p.Apellido + ' ' + p.Nombres
 FROM 
	RolEmpleado re
	left join Persona p on re.IdPersona = p.IdPersona
	left join RolVendedor rv on re.IdRolEmpleado = rv.IdRolEmpleado	
END
GO

/****** Script for SelectTopNRows command from SSMS  ******/
CREATE PROCEDURE [dbo].getDetallePLan
@IdPlanBase int
AS
BEGIN
	SELECT 
		DetallePlanBase
	FROM 
		[ITC_DBPOwer].[dbo].[PlanBaseSet]
	WHERE
		IdPlanBase = @IdPlanBase
END