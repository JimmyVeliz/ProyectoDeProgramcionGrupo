Module MdConexion
    Public conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CentroMedico.accdb")
    Public nombreUsuario As String
    Public emailUsuario As String
    Public idUsuario As String
    Public tipoUsuario As String
    Public Sub abrirConexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al Conectar")
        End Try

    End Sub
    Public Sub cerrarConexion()
        Try
            conexion.Close()
        Catch ex As Exception

        End Try

    End Sub
End Module
