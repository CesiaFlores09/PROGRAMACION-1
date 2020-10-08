
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
        parametrizacion()
    End Sub

    Private Sub parametrizacion()
        micommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        micommand.Parameters.Add("@idContacto", SqlDbType.Int).Value = 0
        micommand.Parameters.Add("@cod", SqlDbType.Char).Value = ""
        micommand.Parameters.Add("@nom", SqlDbType.Char).Value = ""
        micommand.Parameters.Add("@dir", SqlDbType.Char).Value = ""
        micommand.Parameters.Add("@tel", SqlDbType.Char).Value = ""
        micommand.Parameters.Add("@ema", SqlDbType.Char).Value = ""


    End Sub
    Public Function obtenerDatos()
        ds.Clear()
        micommand.Connection = miconexion
        micommand.CommandText = "Select  clientes.Idclientes, clientes.codigo, clientes.nombre, clientes.direccion, contactos.telefono, contactos.email
                from clientes inner join contactos on(contactos.idPersona=clientes.Idclientes)"

        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "clientes")

        ' micommand.CommandText = "Select * from contactos"

        ' miadapter.SelectCommand = micommand
        'miadapter.Fill(ds, "contactos")
        Return ds
    End Function
    Public Function mantenimientoDatosClientes(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String

        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes(codigo,nombre,direccion)VALUES(@cod,@nom,@dir)"
            Case "modificar"
                sql = "UPDATE clientes set codigo=@cod,nombre=@nom,direccion=@dir WHERE Idclientes=@id"

            Case "eliminar"
                sql = "DELETE FROM clientes WHERE Idclientes= @id"
        End Select
        micommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micommand.Parameters("@cod").Value = datos(1)
            micommand.Parameters("@nom").Value = datos(2)
            micommand.Parameters("@dir").Value = datos(3)
            micommand.Parameters("@tel").Value = datos(4)
            micommand.Parameters("@ema").Value = datos(5)
        Else
            mantenimientoDatosContactos(datos, accion)

        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosContactos(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"

        End If
        Return msg
    End Function
    Private Sub mantenimientoDatosContactos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String

        Select Case accion
            Case "nuevo"
                micommand.Connection = miconexion
                micommand.CommandText = "select MAX(Idclientes) As Idclientes from clientes"
                datos(0) = micommand.ExecuteScalar().ToString()
                sql = "INSERT INTO contactos(IdPersona,telefono, email)VALUES(@id,@tel,@ema)"
            Case "modificar"
                sql = "UPDATE contactos SET telefono=@tel,email=@ema WHERE idPersona=@id"

            Case "eliminar"
                sql = "DELETE FROM contactos WHERE idPersona= @id"
        End Select
        micommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then

            micommand.Parameters("@tel").Value = datos(4)
            micommand.Parameters("@ema").Value = datos(5)

        End If
        executeSql(sql)

    End Sub


    Private Function executeSql(ByVal sql As String)
        micommand.Connection = miconexion
        micommand.CommandText = sql
        Return micommand.ExecuteNonQuery()
    End Function


End Class
