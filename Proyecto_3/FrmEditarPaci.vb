Public Class FrmEditarPaci
    Dim hoy As String = Now.Date.ToString("dd/MM/yyyy")
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim sql As String = "UPDATE paciente set dpi= " & txtDpi.Text & ", nombre = '" & txtNombre.Text & "', apellido= '" & txtApellido.Text & "', direccion= '" & txtDireccion.Text & "', telefono= " & txtTelefono.Text & ", id_tipo_sangre =" & cbmIdTipoSangre.SelectedItem & ", estatura = " & txtEstatura.Text & ", peso = " & txtPeso.Text & ", fecha_nacimiento = '" & dtFechaNac.Value.ToShortDateString & "' WHERE id_paciente =" & txtId.Text
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
            MsgBox("Datos actulizados")
            Me.Close()
        Else
            MsgBox("Registro no actualizado")
        End If

        'txtfecha.Text = dtFechaNac.Value.ToShortDateString
    End Sub

    Private Sub cbmTipoSangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmTipoSangre.SelectedIndexChanged

        cbmIdTipoSangre.SelectedIndex = cbmTipoSangre.SelectedIndex

    End Sub

    Private Sub cbmTipoSangre_MouseClick(sender As Object, e As MouseEventArgs) Handles cbmTipoSangre.MouseClick
        cbmTipoSangre.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Dim sql As String = "INSERT INTO PACIENTE(ID_Paciente, dpi, nombre, apellido, direccion, telefono, id_tipo_sangre, estatura, peso, fecha_nacimiento) VALUES(" & txtId.Text & "," & txtDpi.Text & ",'" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "'," & txtTelefono.Text & "," & cbmIdTipoSangre.SelectedItem & ", " & txtEstatura.Text & "," & txtPeso.Text & ", '" & dtFechaNac.Value.ToShortDateString & "')"
        'MsgBox(sql)
        If (txtDpi.Text = "") Or (txtId.Text = "") Or (txtApellido.Text = "") Or (txtNombre.Text = "") Then
            MsgBox("Por favor llenar todos los campos", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)
        Else
            Dim respuesta As Byte = MsgBox("Desea ingresar un nuevo registro de paciente", MsgBoxStyle.Information + vbOKCancel)
            If respuesta = vbOK Then
                abrirConexion()
                Dim eje As New OleDb.OleDbCommand
                eje.CommandType = CommandType.Text
                eje.Connection = conexion
                eje.CommandText = sql
                eje.ExecuteNonQuery()
                cerrarConexion()

                txtId.Clear()
                txtDpi.Clear()
                txtApellido.Clear()
                txtNombre.Clear()
                txtEdad.Clear()
                txtEstatura.Clear()
                txtPeso.Clear()
                txtTelefono.Clear()
                txtDireccion.Clear()
                MsgBox("Datos ingresados")
                Me.Close()
            Else
                MsgBox("Registro no ingresado")
            End If
        End If


    End Sub

    Private Sub dtFechaNac_CloseUp(sender As Object, e As EventArgs) Handles dtFechaNac.CloseUp
        txtEdad.Text = CDate(hoy).Date.Year - dtFechaNac.Value.Year
    End Sub

End Class