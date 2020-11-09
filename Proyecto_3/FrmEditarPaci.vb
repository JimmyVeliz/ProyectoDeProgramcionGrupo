Public Class FrmEditarPaci
    Private Sub BtnCerrarForm_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Public Sub cargarLista()
        Dim sql As String = "SELECT * FROM Tipo_sangre"
        Dim ejecutar As New OleDb.OleDbCommand
        Dim respuesta As OleDb.OleDbDataReader
        abrirConexion()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        respuesta = ejecutar.ExecuteReader
        While respuesta.Read
            cbmIdTipoSangre.Items.Add(respuesta!id_tipo_sangre)
            cbmTipoSangre.Items.Add(respuesta!tipo_sangre)
        End While
        respuesta.Close()
        cerrarConexion()
    End Sub
    Private Sub FormMantPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLista()
        lbIdU.Text = idUsuario
        lbNombreU.Text = nombreUsuario
        'cbmTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim sql As String = "UPDATE paciente set dpi= " & txtDpi.Text & ", nombre = '" & txtNombre.Text & "', apellido= '" & txtApellido.Text & "', direccion= '" & txtDireccion.Text & "', telefono= " & txtTelefono.Text & ", id_tipo_sangre =" & cbmIdTipoSangre.SelectedIndex & ", estatura = " & txtEstatura.Text & ", peso = " & txtPeso.Text & ", fecha_nacimiento = '" & dtFechaNac.Value.ToShortDateString & "' WHERE id_paciente =" & txtId.Text
        MsgBox(sql)
        Dim respuesta As Byte = MsgBox("Desea actualizar el registro del paciente", vbOKCancel)

        If respuesta = vbOK Then
            abrirConexion()
            Dim ejecutar As New OleDb.OleDbCommand
            ejecutar.CommandType = CommandType.Text
            ejecutar.Connection = conexion
            ejecutar.CommandText = sql
            ejecutar.ExecuteNonQuery()
            cerrarConexion()
        Else
            MsgBox("Registro no actualizado")
        End If
        
        'txtfecha.Text = dtFechaNac.Value.ToShortDateString
    End Sub

    Private Sub cbmIdTipoSangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmIdTipoSangre.SelectedIndexChanged

    End Sub

    Private Sub cbmTipoSangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmTipoSangre.SelectedIndexChanged

        cbmIdTipoSangre.SelectedIndex = cbmTipoSangre.SelectedIndex
    End Sub

    Private Sub cbmTipoSangre_MouseClick(sender As Object, e As MouseEventArgs) Handles cbmTipoSangre.MouseClick
        cbmTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        abrirConexion()
        Dim sql As String = "INSERT INTO PACIENTE(ID_Paciente, ) VALUES(" & txtId.Text & ", dpi= " & txtDpi.Text & ", nombre = '" & txtNombre.Text & "', apellido= '" & txtApellido.Text & "', direccion= '" & txtDireccion.Text & "', telefono= " & txtTelefono.Text & ", id_tipo_sangre =" & cbmIdTipoSangre.SelectedIndex & ", estatura = " & txtEstatura.Text & ", peso = " & txtPeso.Text & ", fecha_nacimiento = '" & dtFechaNac.Value.ToShortDateString & "')"
        Dim eje As New OleDb.OleDbCommand
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql
        eje.ExecuteNonQuery()
        cerrarConexion()
    End Sub
End Class