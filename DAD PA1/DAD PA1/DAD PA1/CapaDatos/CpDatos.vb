Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class CpDatos
    Private conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("AppClinica").ConnectionString)

    Public Function Login(obj As CpEntidad) As DataTable

        Dim cmd As New SqlCommand("[SP_Logearse]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@usuario", obj.Usuario)
        cmd.Parameters.AddWithValue("@password", obj.Password)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Function obtenerDatosPersonaPorID(id As Integer) As DataTable
        Dim cmd As New SqlCommand("[sp_obtenerDatosPersonaPorID]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_persona", id)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    'sp_listarCitasPorDniCliente
    Public Function listarCitasPorDniCliente(dni As Integer) As DataTable
        Dim cmd As New SqlCommand("[sp_listarCitasPorDniCliente]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dni_cliente", dni)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function


    Public Function obtenerTotalClientes() As DataTable
        Dim cmd As New SqlCommand("[SP_ObtenerTotalClientes]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function


    Public Function obtenerServicioClinico(idServicioClinico As Integer) As DataTable
        Dim cmd As New SqlCommand("[sp_obtenerServicioClinico]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_servicio_clinico", idServicioClinico)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
    Public Function buscarEmpleadoPorDNI(dni As Integer) As DataTable
        Dim cmd As New SqlCommand("[sp_buscarEmpleadoPorDNI]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dniEmpleado", dni)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function buscarClientePorDNI(dni As Integer) As DataTable
        Dim cmd As New SqlCommand("[sp_buscarClientePorDNI]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@dniCliente", dni)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function


    Public Function obtenerTotalTablaCita() As DataTable
        Dim cmd As New SqlCommand("[sp_obtenerTotalTablaCita]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function obtenerTotalTablaEmpleado() As DataTable
        Dim cmd As New SqlCommand("[SP_ObtenerTotalEmpleado]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function mostrarEmpleadoPorID(id_empleado As Integer) As DataTable
        Dim cmd As New SqlCommand("[sp_mostrarEmpleadoPorID]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_empleado", id_empleado)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
    Public Function listarClientes() As DataTable
        Dim cmd As New SqlCommand("[sp_listarClientes]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function listarEmpleadosUsuarios() As DataTable
        Dim cmd As New SqlCommand("[sp_listarEmpleadosUsuarios]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function listarClientesUsuarios() As DataTable
        Dim cmd As New SqlCommand("[sp_listarClientesUsuarios]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function listarEmpleados() As DataTable
        Dim cmd As New SqlCommand("[sp_listarEmpleados]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function

    Public Function listarServiciosClinicos() As DataTable
        Dim cmd As New SqlCommand("[sp_listarServiciosClinicos]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function
    'sp_listarTipoUsuario
    Public Function ListarTipoUsuario() As DataTable
        Dim cmd As New SqlCommand("[sp_listarTipoUsuario]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Function ListarAreas() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarAreas]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt

    End Function

    Public Function ListarTipoEmpleados() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarATipoEmpleados]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function


    Public Function ListarTipoServicioClinico() As DataTable
        Dim cmd As New SqlCommand("[sp_ListarTipoServicioClinico]", conexion)
        conexion.Open()
        cmd.CommandType = CommandType.StoredProcedure
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        conexion.Close()
        Return dt
    End Function


    'REGISTRAR sp_RegistrarUsuario

    Public Function registrarUsuario(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_RegistrarUsuario]", conexion)
        Dim respuesta As Integer

        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_persona", obj.id_persona)
            cmd.Parameters.AddWithValue("@id_tipo_usuario", obj.id_tipo_usuario)
            cmd.Parameters.AddWithValue("@usuario", obj.Usuario)
            cmd.Parameters.AddWithValue("@contraseña", obj.Password)
            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta

    End Function

    Public Function anularCitaMedica(idCita As Integer) As Integer
        Dim respuesta As Integer
        Dim cmd As New SqlCommand("[sp_anularCitaMedica]", conexion)
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cita", idCita)

            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta

    End Function

    Public Function eliminarUsuario(id_usuario As Integer) As Integer
        Dim respuesta As Integer
        Dim cmd As New SqlCommand("[sp_eliminarUsuario]", conexion)
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)

            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta

    End Function

    Public Function actualizarServicioClinico(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_actualizarServicioCLinico]", conexion)
        Dim respuesta As Integer

        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_servicio_clinico", obj.id_servicio_clinico)
            cmd.Parameters.AddWithValue("@id_tipo_servicio", obj.id_tipo_servicio)
            cmd.Parameters.AddWithValue("@fecha_servicio", obj.fecha_servicio)
            cmd.Parameters.AddWithValue("@estado_pago_servicio", obj.estado_pago_servicio)
            cmd.Parameters.AddWithValue("@estado_servicio", obj.estado_servicio)
            cmd.Parameters.AddWithValue("@precio", obj.precio)
            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try
        Return respuesta

    End Function

    Public Function actualizarUsuario(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_actualizarUsuario]", conexion)
        Dim respuesta As Integer

        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            '@id_usuario
            cmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario)
            cmd.Parameters.AddWithValue("@id_persona", obj.id_persona)
            cmd.Parameters.AddWithValue("@id_tipo_usuario", obj.id_tipo_usuario)
            cmd.Parameters.AddWithValue("@usuario", obj.Usuario)
            cmd.Parameters.AddWithValue("@contraseña", obj.Password)
            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta

    End Function



    'sp_RegistrarCita
    Public Function registrarCita(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_RegistrarCita]", conexion)
        Dim respuesta As Integer
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_cita", obj.id_cita)
            cmd.Parameters.AddWithValue("@id_empleado", obj.id_empleado)
            cmd.Parameters.AddWithValue("@id_cliente", obj.id_cliente)
            cmd.Parameters.AddWithValue("@id_tipo_area", obj.id_tipo_area)
            cmd.Parameters.AddWithValue("@fecha_atencion", obj.fecha_atencion)
            cmd.Parameters.AddWithValue("@detalle_cita", obj.detalle_cita)
            cmd.Parameters.AddWithValue("@id_servicio_clinico", obj.id_servicio_clinico)

            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta
    End Function

    Public Function registrarUsuarioCliente(obj As CpEntidad) As Integer
        'sp_RegistrarUsuarioCliente
        Dim cmd As New SqlCommand("[sp_RegistrarUsuarioCliente]", conexion)
        Dim respuesta As Integer

        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_paciente", obj.id_paciente)
            cmd.Parameters.AddWithValue("@detalle", obj.detalle)
            cmd.Parameters.AddWithValue("@nombre", obj.nombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", obj.apellido_paterno)
            cmd.Parameters.AddWithValue("@apellido_materno", obj.apellido_materno)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", obj.fecha_nacimiento)
            cmd.Parameters.AddWithValue("@dni", obj.dni)
            cmd.Parameters.AddWithValue("@celular", obj.celular)
            cmd.Parameters.AddWithValue("@correo", obj.correo)
            cmd.Parameters.AddWithValue("@sexo", obj.sexo)
            cmd.Parameters.AddWithValue("@direccion", obj.direccion)

            cmd.Parameters.AddWithValue("@id_tipo_usuario", obj.id_tipo_usuario)
            cmd.Parameters.AddWithValue("@usuario", obj.Usuario)
            cmd.Parameters.AddWithValue("@contraseña", obj.Password)


            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception

        End Try
        Return respuesta
    End Function
    Public Function registrarPaciente(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_RegistrarPaciente]", conexion)
        Dim respuesta As Integer
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_paciente", obj.id_paciente)
            cmd.Parameters.AddWithValue("@detalle", obj.detalle)
            cmd.Parameters.AddWithValue("@nombre", obj.nombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", obj.apellido_paterno)
            cmd.Parameters.AddWithValue("@apellido_materno", obj.apellido_materno)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", obj.fecha_nacimiento)
            cmd.Parameters.AddWithValue("@dni", obj.dni)
            cmd.Parameters.AddWithValue("@celular", obj.celular)
            cmd.Parameters.AddWithValue("@correo", obj.correo)
            cmd.Parameters.AddWithValue("@sexo", obj.sexo)
            cmd.Parameters.AddWithValue("@direccion", obj.direccion)
            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta
    End Function

    Public Function actualizarEmpleado(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_actualizarEmpleado]", conexion)
        Dim respuesta As Integer
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_persona", obj.id_persona)
            cmd.Parameters.AddWithValue("@id_empleado", obj.id_empleado)
            cmd.Parameters.AddWithValue("@id_area", obj.id_area)
            cmd.Parameters.AddWithValue("@detalle", obj.detalle)
            cmd.Parameters.AddWithValue("@id_tipo_empleado", obj.id_tipo_empleado)
            cmd.Parameters.AddWithValue("@nombre", obj.nombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", obj.apellido_paterno)
            cmd.Parameters.AddWithValue("@apellido_materno", obj.apellido_materno)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", obj.fecha_nacimiento)
            cmd.Parameters.AddWithValue("@dni", obj.dni)
            cmd.Parameters.AddWithValue("@celular", obj.celular)
            cmd.Parameters.AddWithValue("@correo", obj.correo)
            cmd.Parameters.AddWithValue("@sexo", obj.sexo)
            cmd.Parameters.AddWithValue("@direccion", obj.direccion)
            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta
    End Function

    Public Function registrarEmpleado(obj As CpEntidad) As Integer
        Dim cmd As New SqlCommand("[sp_RegistrarEmpleado]", conexion)
        Dim respuesta As Integer
        Try
            conexion.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_empleado", obj.id_empleado)
            cmd.Parameters.AddWithValue("@id_area", obj.id_area)
            cmd.Parameters.AddWithValue("@detalle", obj.detalle)
            cmd.Parameters.AddWithValue("@id_tipo_empleado", obj.id_tipo_empleado)
            cmd.Parameters.AddWithValue("@nombre", obj.nombre)
            cmd.Parameters.AddWithValue("@apellido_paterno", obj.apellido_paterno)
            cmd.Parameters.AddWithValue("@apellido_materno", obj.apellido_materno)
            cmd.Parameters.AddWithValue("@fecha_nacimiento", obj.fecha_nacimiento)
            cmd.Parameters.AddWithValue("@dni", obj.dni)
            cmd.Parameters.AddWithValue("@celular", obj.celular)
            cmd.Parameters.AddWithValue("@correo", obj.correo)
            cmd.Parameters.AddWithValue("@sexo", obj.sexo)
            cmd.Parameters.AddWithValue("@direccion", obj.direccion)
            respuesta = cmd.ExecuteNonQuery()

            conexion.Close()

        Catch ex As Exception

        End Try

        Return respuesta
    End Function

    'Public Function registrarSuministra(obj As CpEntidad) As Integer

    '    Dim cmd As New SqlCommand("[SP_RegistraSuministra]", conexion)
    '    Dim respuesta As Integer

    '    Try
    '        conexion.Open()
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.AddWithValue("@codSuministra", "RS")
    '        cmd.Parameters.AddWithValue("@codProveedor", obj.idProveedor)
    '        cmd.Parameters.AddWithValue("@codProducto", obj.idProducto)
    '        cmd.Parameters.AddWithValue("@idUbicacion", obj.idUbicacion)
    '        cmd.Parameters.AddWithValue("@lote", obj.lote)
    '        cmd.Parameters.AddWithValue("@cantidad", obj.cantidad)
    '        cmd.Parameters.AddWithValue("@numFactura", obj.numFactura)
    '        cmd.Parameters.AddWithValue("@paisOrigen", obj.paisOrigen)
    '        cmd.Parameters.AddWithValue("@precio_compra", obj.precio_compra)
    '        cmd.Parameters.AddWithValue("@caducidad", obj.caducidad)
    '        cmd.Parameters.AddWithValue("@FechaCreacion", obj.FechaCreacion)

    '        respuesta = cmd.ExecuteNonQuery()

    '        conexion.Close()
    '    Catch ex As Exception

    '        Console.WriteLine(ex.Message)

    '    End Try

    '    Return respuesta

    'End Function

    Public MustInherit Class ConnectionSQL
        Protected Function GetConnection() As SqlConnection
            Return New SqlConnection("Server=(local); DataBase=CLÍNICA_ALFONSO_UGARTE; integrated security=true")
        End Function
    End Class

End Class
