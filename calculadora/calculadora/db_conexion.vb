Imports System.Data
Imports System.Data.SqlClient

Public Class db_conexion
    Dim miconexion As New SqlConnection
    Dim miadapter As New SqlDataAdapter
    Dim micommand As New SqlCommand
    Dim ds As New DataSet

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bd_empresa.mdf;Integrated Security=True"
        miconexion.ConnectionString = cadenaConexion
        miconexion.Open()
    End Sub
    Public Function obtenerDatos()
        ds.Clear()
        micommand.Connection = miconexion

        micommand.CommandText = "Select * from empleados"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "empleados")

        micommand.CommandText = "Select * from usuario"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "usuario")

        micommand.CommandText = "Select * from proveedores"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "proveedores")

        Return ds
    End Function
    Public Function mantenimientoDatosEmpleados(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO empleados (codigo,nombre,puestolaboral,direccion,telefono,email) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE empleados  SET codigo='" + datos(1) + "',nombre='" + datos(2) + "',puestolaboral='" + datos(3) + "',direccion='" + datos(4) + "',telefono='" + datos(5) + "',email='" + datos(6) + "'WHERE idempleados='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM empleados WHERE idempleados='" + datos(0) + "'"
        End Select
        If (excecuteSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"
        End If
        Return msg
    End Function

    Public Function mantenimientoDatosUsuarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO usuario (nombres,apellidos,clave,email,direccion,telefono,privilegio) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "')"
            Case "modificar"
                sql = "UPDATE usuario  SET nombres='" + datos(1) + "',apellidos='" + datos(2) + "',clave='" + datos(3) + "',email='" + datos(4) + "',direccion='" + datos(5) + "',telefono='" + datos(6) + "',privilegio='" + datos(7) + "'WHERE idusuario='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM usuario WHERE idusuario='" + datos(0) + "'"
        End Select
        If (excecuteSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosProveedores(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO proveedores (codigo,nombre,nombre_empresa,nombre_propietario,direccion,telefono,email) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "')"
            Case "modificar"
                sql = "UPDATE proveedores  SET codigo='" + datos(1) + "',nombre='" + datos(2) + "',nombre_empresa='" + datos(3) + "',nombre_propietario='" + datos(4) + "',direccion='" + datos(5) + "',telefono='" + datos(6) + "',email='" + datos(7) + "'WHERE idproveedores='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM proveedores WHERE idproveedores='" + datos(0) + "'"
        End Select
        If (excecuteSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"
        End If
        Return msg
    End Function
    Private Function excecuteSql(ByVal sql As String)
        micommand.Connection = miconexion
        micommand.CommandText = sql
        Return micommand.ExecuteNonQuery()
    End Function

End Class

