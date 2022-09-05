Imports CapaDatos
Imports CapaEntidad
Public Class CpNegocio
    Property objDatos As New CpDatos

    Public Function Neg_Login(obj As CpEntidad) As DataTable
        Return objDatos.Login(obj)

    End Function

    Public Function Neg_obtenerDatosPersonaPorID(id As Integer) As DataTable
        Return objDatos.obtenerDatosPersonaPorID(id)
    End Function

    Public Function Neg_ListarArea() As DataTable
        Return objDatos.ListarAreas()
    End Function

    Public Function Neg_listarClientesUsuarios() As DataTable
        Return objDatos.listarClientesUsuarios()
    End Function

    Public Function Neg_listarEmpleadosUsuarios() As DataTable
        Return objDatos.listarEmpleadosUsuarios()
    End Function


    'ListarTipoUsuario
    Public Function Neg_ListarTipoUsuario() As DataTable
        Return objDatos.ListarTipoUsuario()
    End Function
    Public Function Neg_listarServiciosClinicos() As DataTable
        Return objDatos.listarServiciosClinicos()
    End Function

    Public Function Neg_listarClientes() As DataTable
        Return objDatos.listarClientes()
    End Function

    Public Function Neg_listarEmpleados() As DataTable
        Return objDatos.listarEmpleados()
    End Function

    Public Function Neg_ListarTipoServicioClinico() As DataTable
        Return objDatos.ListarTipoServicioClinico()
    End Function

    Public Function Neg_ListarTipoTrabajador() As DataTable
        Return objDatos.ListarTipoEmpleados()
    End Function

    Public Function Neg_obtenerTotalTablaEmpleado() As DataTable
        Return objDatos.obtenerTotalTablaEmpleado()
    End Function

    Public Function Neg_obtenerTotalTablaCita() As DataTable
        Return objDatos.obtenerTotalTablaCita()
    End Function

    Public Function Neg_obtenerTotalClientes() As DataTable
        Return objDatos.obtenerTotalClientes()
    End Function

    'actualizarEmpleado
    Public Function Neg_actualizarEmpleado(obj As CpEntidad) As Integer
        Return objDatos.actualizarEmpleado(obj)
    End Function

    'actualizarServicioClinico
    Public Function Neg_actualizarServicioClinico(obj As CpEntidad) As Integer
        Return objDatos.actualizarServicioClinico(obj)
    End Function
    Public Function Neg_RegistrarEmpleado(obj As CpEntidad) As Integer
        Return objDatos.registrarEmpleado(obj)
    End Function

    Public Function Neg_RegistrarUsuario(obj As CpEntidad) As Integer
        Return objDatos.registrarUsuario(obj)
    End Function

    Public Function Neg_ActualizarUsuario(obj As CpEntidad) As Integer
        Return objDatos.actualizarUsuario(obj)
    End Function

    Public Function Neg_EliminarUsuario(id_usuario As Integer) As Integer
        Return objDatos.eliminarUsuario(id_usuario)
    End Function

    'anularCitaMedica
    Public Function Neg_anularCitaMedica(idcita As Integer) As Integer
        Return objDatos.anularCitaMedica(idcita)
    End Function


    'listarCitasPorDniCliente
    Public Function Neg_listarCitasPorDniCliente(dni As Integer) As DataTable
        Return objDatos.listarCitasPorDniCliente(dni)
    End Function

    'mostrarEmpleadoPorID
    Public Function Neg_mostrarEmpleadoPorID(id_empleado As Integer) As DataTable
        Return objDatos.mostrarEmpleadoPorID(id_empleado)
    End Function
    Public Function Neg_RegistrarCita(obj As CpEntidad) As Integer
        Return objDatos.registrarCita(obj)
    End Function


    Public Function Neg_buscarEmpleadoDNI(dni As Integer) As DataTable
        Return objDatos.buscarEmpleadoPorDNI(dni)
    End Function

    Public Function Neg_obtenerServicioClinico(idServicioClinico As Integer) As DataTable
        Return objDatos.obtenerServicioClinico(idServicioClinico)
    End Function

    Public Function Neg_buscarClienteDNI(dni As Integer) As DataTable
        Return objDatos.buscarClientePorDNI(dni)
    End Function

    Public Function Neg_RegistrarPaciente(obj As CpEntidad) As Integer
        Return objDatos.registrarPaciente(obj)
    End Function

    Public Function Neg_registrarUsuarioCliente(obj As CpEntidad) As Integer
        Return objDatos.registrarUsuarioCliente(obj)
    End Function

    'Public Function Neg_ListarProve() As DataTable
    '    Return objDatos.ListarProveedor()

    'End Function

    'Public Function Neg_ListarPais() As DataTable
    '    Return objDatos.ListarPais()

    'End Function

    'Public Function Neg_ListarUbicacion() As DataTable
    '    Return objDatos.ListarUbicacion()

    'End Function

    'Public Function Neg_RegistrarSuministra(obj As CpEntidad) As Integer

    '    Return objDatos.registrarSuministra(obj)


    'End Function

End Class
