Public Class FrmPrueba
    Public Sub listaPacientes()
        Dim sql As String = "SELECT * FROM Paciente as p inner Join Tipo_sangre as ts on p.id_tipo_sangre = Ts.id_tipo_sangre"
        Dim ejecutar As New OleDb.OleDbCommand
        Dim respuesta As OleDb.OleDbDataReader

        abrirConexion()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        respuesta = ejecutar.ExecuteReader
        dgvPacientes.Rows.Clear()
        While (respuesta.Read)


            dgvPacientes.Rows.Add(respuesta!id_paciente, respuesta!DPI, respuesta!apellido, respuesta!nombre, respuesta!Direccion, respuesta!telefono, respuesta!Tipo_sangre, respuesta!Estatura, respuesta!peso, respuesta!Fecha_Nacimiento, respuesta!Edad)
        End While
        respuesta.Close()
        cerrarConexion()

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim frm As New FrmEditarPaci
        frm.txtId.Text = dgvPacientes.CurrentRow.Cells(0).Value.ToString()
        MsgBox(dgvPacientes.CurrentRow.Cells(2).Value.ToString())
        'frm.txtApellido.Text = dgvPacientes.CurrentRow.Cells(2).Value.ToString()
        'frm.txtPrueba.Text = dgvPacientes.CurrentRow.Cells(0).Value.ToString()
        FrmEditarPaci.ShowDialog()
    End Sub

    Private Sub FrmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'listaPacientes()
    End Sub
End Class