
Imports System.Data
Imports System.Data.SqlClient

Public Class db_conexion
    Dim miconexion As New SqlConnection
    Dim miadapter As New SqlDataAdapter
    Dim micommand As New SqlCommand
    Dim ds As New DataSet

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sis.mdf;Integrated Security=True "
        miconexion.ConnectionString = cadenaConexion
        miconexion.Open()

    End Sub
    Public Function obtenerDatos()
        ds.Clear()
        micommand.Connection = miconexion
        micommand.CommandText = "Select * from clientes"

        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "clientes")
        Return ds
    End Function
    Public Function mantenimientoDatosClientes(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String

        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes(codigo,nombre,direccion,telefono,email)VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE clientes set codigo='" + datos(1) + "',nombre='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "',email='" + datos(5) + "' WHERE idclientes='" + datos(0) + "'"

            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idclientes='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "Accion relizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"

        End If
        Return msg
    End Function

    Private Function executeSql(ByVal sql As String)
        micommand.Connection = miconexion
        micommand.CommandText = sql
        Return micommand.ExecuteNonQuery()
    End Function


End Class
