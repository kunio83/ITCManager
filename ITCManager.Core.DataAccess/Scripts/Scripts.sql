USE [ITC_DBPOwer]
GO
CREATE PROCEDURE getJefesVentas
AS
BEGIN
	SELECT 
		re.idRolEmpleado,
		p.Apellido
	FROM
		RolEmpleado RE
		LEFT JOIN RolVendedor RV ON RE.IdRolEmpleado = RV.IdRolEmpleado
		LEFT JOIN PERSONA P ON P.IDPERSONA = RE.IdPersona
	
END
GO
