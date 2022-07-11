Imports System.Data.SqlClient

Public Class TotalesProducto
    Public Function ConsultaTotales(Centro, Bodega, Deposito, Cliente, Presentacion, CodProducto) As SqlDataReader

        Dim comando As New SqlClient.SqlCommand("sp_TotalesProducto", Conn)
        comando.CommandType = CommandType.StoredProcedure
        If Conn.State = ConnectionState.Closed Then Conn.Open()

        comando.Parameters.Add("@CENTRO", SqlDbType.NChar).Value = Centro
        comando.Parameters.Add("@BODEGA", SqlDbType.NChar).Value = Bodega
        comando.Parameters.Add("@CLIENTE", SqlDbType.NChar).Value = Cliente
        comando.Parameters.Add("@DEPOSITO", SqlDbType.NChar).Value = Deposito
        comando.Parameters.Add("@PRESENTACION", SqlDbType.NChar).Value = Presentacion
        comando.Parameters.Add("@CODPRODUCTO", SqlDbType.NChar).Value = CodProducto

        '------ Variable que recibe el Resultado ----------
        comando.Parameters.Add("@Resultado", SqlDbType.VarChar, 100)
        comando.Parameters("@Resultado").Direction = ParameterDirection.Output
        '-------------------------------------------------
        Dim Consulta As SqlDataReader

        Consulta = comando.ExecuteReader
        Return Consulta
        Conn.Close()

    End Function
End Class
