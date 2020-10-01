Public Class FrmAgenda
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs) Handles BtnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
    Public Sub cargarListaCod()
        Dim sqlCita As String = "SELECT * FROM cita"
        Dim sqlDocPaci As String = "SELECT * FROM doc_paci"
        Dim ejecutar As New OleDb.OleDbCommand
        Dim respuesta As OleDb.OleDbDataReader
        Dim cont As Integer = 0
        abrirConexion()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sqlDocPaci
        respuesta = ejecutar.ExecuteReader
        While (respuesta.Read)
            cont = respuesta!id_doc_paci + 1
            lbIdDocPaci.Text = cont
        End While
        respuesta.Close()

        ejecutar.CommandText = sqlCita
        respuesta = ejecutar.ExecuteReader
        While (respuesta.Read)
            cont = respuesta!id_cita + 1
            lbIdCita.Text = cont
        End While
        respuesta.Close()
        cerrarConexion()
    End Sub
    Private Sub FrmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaCod()
        lbIdU.Text = idUsuario
        lbNombreU.Text = nombreUsuario
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim sql As String = "INSERT INTO Doc_paci Values (" & lbIdDocPaci.Text & "," & txtIdDoctor.Text & ", " & txtid.Text & ")"
        MsgBox(sql)
        Dim sql2 As String = "INSERT INTO cita VALUES(" & lbIdCita.Text & "," & lbIdDocPaci.Text & ",'" & txtCita.Text & "','" & dtpFechaCita.Value.ToShortDateString & "')"
        Dim respuesta As Byte = MsgBox("Desea agregar el cita", vbOKCancel)
        If respuesta = vbOK Then
            abrirConexion()
            Dim ejcutarSql As New OleDb.OleDbCommand
            ejcutarSql.CommandType = CommandType.Text
            ejcutarSql.Connection = conexion
            ejcutarSql.CommandText = sql
            ejcutarSql.ExecuteNonQuery()
            Dim ejecutarSql As New OleDb.OleDbCommand
            ejecutarSql.CommandType = CommandType.Text
            ejecutarSql.Connection = conexion
            ejecutarSql.CommandText = sql2
            ejecutarSql.ExecuteNonQuery()
            cerrarConexion()
            MsgBox("Cita ya fue asignada")
        End If
        cargarListaCod()
    End Sub
End Class