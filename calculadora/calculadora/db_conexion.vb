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



        micommand.CommandText = "Select * from usuario"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "usuario")

        micommand.CommandText = "Select * from proveedores"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "proveedores")

        micommand.CommandText = "Select * from cliente"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "cliente")

        micommand.CommandText = "Select * from categoria"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "categoria")

        micommand.CommandText = "
       Select producto.idproducto,producto.idcategoria,producto.codigo,producto.nombre,producto.marca,
       producto.medidas,categoria.categoria
        from producto
       inner join categoria on (categoria.idcategoria=producto.idcategoria)"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "producto")

        micommand.CommandText = "Select * from puesto"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "puesto")

        micommand.CommandText = "
       Select empleados.idempleados,empleados.idpuestolaboral,empleados.codigo,empleados.nombre,empleados.direccion,
       empleados.telefono,empleados.email,puesto.puesto
        from empleados
       inner join puesto on (puesto.idpuestolaboral=empleados.idpuestolaboral)"
        miadapter.SelectCommand = micommand
        miadapter.Fill(ds, "empleados")


        Return ds
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
    Public Function mantenimientoDatosClientes(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO cliente (codigo,nombre,direccion,telefono,email) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE cliente  SET codigo='" + datos(1) + "',nombre='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "',email='" + datos(5) + "'WHERE idcliente='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM cliente WHERE idcliente='" + datos(0) + "'"
        End Select
        If (excecuteSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosProductos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO producto (idcategoria,codigo,nombre,marca,medidas) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "')"
            Case "modificar"
                sql = "UPDATE producto  SET idcategoria='" + datos(1) + "',codigo='" + datos(2) + "',nombre='" + datos(3) + "',marca='" + datos(4) + "',medidas='" + datos(5) + "'WHERE idproducto='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM producto WHERE idproducto='" + datos(0) + "'"
        End Select
        If excecuteSql(sql) > 0 Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosCategoria(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO categoria (categoria) VALUES('" + datos(1) + "')"
            Case "modificar"
                sql = "UPDATE categoria  SET categoria='" + datos(1) + "'WHERE idcategoria='" + datos(0) + "'"
            Case "eliminar"
                If excecuteSql("select * from producto where idcategoria='" + datos(0) + "'") <= 0 Then
                    sql = "DELETE FROM categoria WHERE idcategoria='" + datos(0) + "'"
                End If
        End Select

        If excecuteSql(sql) > 0 Then
            msg = "Exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosEmpleados(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO empleados (idpuestolaboral,codigo,nombre,direccion,telefono,email) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE empleados  SET idpuestolaboral='" + datos(1) + "',codigo='" + datos(2) + "',nombre='" + datos(3) + "',direccion='" + datos(4) + "',telefono='" + datos(5) + "',email='" + datos(6) + "'WHERE idempleados='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM empleados WHERE idempleados='" + datos(0) + "'"
        End Select
        If excecuteSql(sql) > 0 Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, por favor intentelo de nuevo"
        End If
        Return msg
    End Function
    Public Function mantenimientoDatosPuesto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO puesto (puesto) VALUES('" + datos(1) + "')"
            Case "modificar"
                sql = "UPDATE puesto  SET puesto='" + datos(1) + "'WHERE idpuestolaboral='" + datos(0) + "'"
            Case "eliminar"
                If excecuteSql("select * from empleados where idpuestolaboral='" + datos(0) + "'") <= 0 Then
                    sql = "DELETE FROM puesto WHERE idpuestolaboral='" + datos(0) + "'"
                End If
        End Select

        If excecuteSql(sql) > 0 Then
            msg = "Exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Function excecuteSql(ByVal sql As String)
        Try
            micommand.Connection = miconexion
            micommand.CommandText = sql
            Return micommand.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

    End Function

End Class
