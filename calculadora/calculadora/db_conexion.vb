
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
End Class
