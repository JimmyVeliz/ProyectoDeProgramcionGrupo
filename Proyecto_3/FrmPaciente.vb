Public Class FrmPaciente

    Private Sub BtCerrarForm_Click(sender As Object, e As EventArgs) Handles BtCerrarForm.Click
        Me.Close()
    End Sub
    Public Sub listaPacientes()
        Dim sql As String = "SELECT Paciente.id_tipo_sangre AS idTipoSangre, * FROM Paciente INNER JOIN Tipo_sangre ON Paciente.id_tipo_sangre = Tipo_sangre.id_tipo_sangre"
        Dim ejecutar As New OleDb.OleDbCommand
        Dim respuesta As OleDb.OleDbDataReader

        abrirConexion()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        respuesta = ejecutar.ExecuteReader
        dgvPacientes.Rows.Clear()
        While (respuesta.Read)
            dgvPacientes.Rows.Add(respuesta!id_paciente, respuesta!DPI, respuesta!apellido, respuesta!nombre, respuesta!Direccion, respuesta!telefono, respuesta!Tipo_sangre, respuesta!Estatura, respuesta!peso, respuesta!Fecha_Nacimiento, respuesta!Edad, respuesta!id_tipo_sangre)
        End While
        respuesta.Close()
        cerrarConexion()

    End Sub

    'Private Sub BtConsulta_Click(sender As Object, e As EventArgs)
    '    Dim sql As String = "SELECT * FROM paciente WHERE ID_Paciente LIKE " & Val(txtIdPaciente.Text)
    '    Dim ejecutar As New OleDb.OleDbCommand
    '    Dim respuesta As OleDb.OleDbDataReader

    '    abrirConexion()
    '    ejecutar.CommandType = CommandType.Text
    '    ejecutar.Connection = conexion
    '    ejecutar.CommandText = sql
    '    'MsgBox(sql)
    '    respuesta = ejecutar.ExecuteReader
    '    While respuesta.Read
    '        If respuesta.HasRows Then
    '            LbApellido.Text = respuesta!apellido
    '            TxtCUI.Text = respuesta!DPI
    '            LbDireccion.Text = respuesta!Direccion
    '            LbNombre.Text = respuesta!Nombre
    '            LbSangre.Text = respuesta!id_tipo_sangre
    '        Else
    '            MsgBox("Paciente no existe")
    '        End If
    '    End While
    '    respuesta.Close()
    '    cerrarConexion()

    'End Sub

    Private Sub FrmPaciente_Load(sender As Object, e As EventArgs) Handles Me.Load
        listaPacientes()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'Aqui se envian los datos al otro formulario con los datos que seleccionamos 
        FrmEditarPaci.txtId.Text = dgvPacientes.CurrentRow.Cells(0).Value.ToString()
        FrmEditarPaci.txtDpi.Text = dgvPacientes.CurrentRow.Cells(1).Value.ToString()
        FrmEditarPaci.txtApellido.Text = dgvPacientes.CurrentRow.Cells(2).Value.ToString()
        FrmEditarPaci.txtNombre.Text = dgvPacientes.CurrentRow.Cells(3).Value.ToString()
        FrmEditarPaci.txtDireccion.Text = dgvPacientes.CurrentRow.Cells(4).Value.ToString()
        FrmEditarPaci.txtTelefono.Text = dgvPacientes.CurrentRow.Cells(5).Value.ToString()
        FrmEditarPaci.cbmTipoSangre.Text = dgvPacientes.CurrentRow.Cells(6).Value.ToString()
        FrmEditarPaci.txtEstatura.Text = dgvPacientes.CurrentRow.Cells(7).Value.ToString()
        FrmEditarPaci.txtPeso.Text = dgvPacientes.CurrentRow.Cells(8).Value.ToString()
        FrmEditarPaci.dtFechaNac.Text = dgvPacientes.CurrentRow.Cells(9).Value.ToString()
        FrmEditarPaci.txtEdad.Text = dgvPacientes.CurrentRow.Cells(10).Value.ToString()
        FrmEditarPaci.cbmIdTipoSangre.Text = dgvPacientes.CurrentRow.Cells(11).Value.ToString()
        FrmEditarPaci.Show()
    End Sub

    Private Sub dgvPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim eliminar As String = dgvPacientes.CurrentRow.Cells(0).Value.ToString()
        Dim sql As String = "DELETE * FROM Paciente WHERE id_paciente =" & eliminar
        MsgBox(sql)
        Dim respuesta As Byte = MsgBox("Desea eliminar el registro", vbOKCancel)

        If respuesta = vbOK Then
            abrirConexion()
            Dim ejecutar As New OleDb.OleDbCommand
            ejecutar.CommandType = CommandType.Text
            ejecutar.Connection = conexion
            ejecutar.CommandText = sql
            ejecutar.ExecuteNonQuery()
            cerrarConexion()
            MsgBox("Registro eliminado con exito")
            listaPacientes()
        End If
    End Sub
End Class