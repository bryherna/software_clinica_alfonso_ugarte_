Public Class CpEntidad
	'cita
	Public Property id_cita As Integer
	Public Property id_cliente As Integer

	Public Property id_tipo_area As Integer
	Public Property fecha_atencion As DateTime
	Public Property detalle_cita As String
	Public Property id_servicio_clinico As Integer


	' logeo 
	Public Property Usuario As String
	Public Property Password As String
	'paciente
	Public Property id_paciente As Integer

	'trabajador
	Public Property id_persona As Integer
	Public Property id_empleado As Integer
	Public Property id_area As Integer
	Public Property detalle As String
	Public Property id_tipo_empleado As Integer
	Public Property nombre As String
	Public Property apellido_paterno As String
	Public Property apellido_materno As String
	Public Property fecha_nacimiento As DateTime
	Public Property dni As Integer
	Public Property celular As Integer
	Public Property correo As String
	Public Property sexo As Integer
	Public Property direccion As String


	'Usuario
	Public Property id_usuario As Integer
	Public Property id_tipo_usuario As Integer

	'servicio clinico
	Public Property id_tipo_servicio As Integer
	Public Property fecha_servicio As DateTime
	Public Property estado_pago_servicio As Integer
	Public Property estado_servicio As Integer

	Public Property precio As Double




	''Referencias para el reporte
	'Public Property descripcion As String
	'Public Property Total As Double
	'Public Property FechaCreacion As DateTime

End Class
