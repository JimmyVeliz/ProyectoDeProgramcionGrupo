Public Class FrmEnfermera
    Private Sub BtCerrarForm_Click(sender As Object, e As EventArgs) Handles BtCerrarForm.Click
        Me.Close()
    End Sub
    Public Sub cargarLista()
        Dim sql As String = "SELECT * FROM Tipo_sangre"
        Dim sql2 As String = "SELECT * FROM tipo_usuario"
        Dim sql3 As String = "SELECT * FROM Especialidad"
        Dim ejecutar As New OleDb.OleDbCommand
        Dim respuesta As OleDb.OleDbDataReader
        abrirConexion()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        respuesta = ejecutar.ExecuteReader
        While respuesta.Read
            cmbIdTipoSangre.Items.Add(respuesta!id_tipo_sangre)
            cmbTipoSangre.Items.Add(respuesta!tipo_sangre)
        End While
        respuesta.Close()
        ejecutar.CommandText = sql2
        respuesta = ejecutar.ExecuteReader
        While respuesta.Read
            cmbTipoUsu.Items.Add(respuesta!nombre)
            cmbIdTipoUsu.Items.Add(respuesta!id_tipo)
        End While
        respuesta.Close()
        ejecutar.CommandText = sql3
        respuesta = ejecutar.ExecuteReader
        While respuesta.Read
            cmbEspecialidad.Items.Add(respuesta!Especialidad)
            cmbIdEspec.Items.Add(respuesta!id_espec)
        End While
        respuesta.Close()
        cerrarConexion()
    End Sub

    Public Sub cargarIdUsuario()
        Dim sql As String = "SELECT * FROM Usuario "
        Dim sql2 As String = "SELECT * FROM tipo_usuario"
        Dim eje As New OleDb.OleDbCommand
        Dim res As OleDb.OleDbDataReader
        abrirConexion()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql
        res = eje.ExecuteReader
        Dim cont As Integer = 0
        While (res.Read)
            cont = res!id_Usuario + 1
            lbIdUsuario.Text = cont
        End While
        res.Close()
        eje.CommandText = sql2
        res = eje.ExecuteReader
        While (res.Read)

        End While
        res.Close()
        cerrarConexion()
    End Sub
    Private Sub TpConEnfe_Click(sender As Object, e As EventArgs) Handles TpConEnfe.Click

    End Sub

    Private Sub FrmEnfermera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLista()
        cargarIdUsuario()
    End Sub

    Private Sub cmbIdTipoSangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdTipoSangre.SelectedIndexChanged

    End Sub

    Private Sub cmbTipoSangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoSangre.SelectedIndexChanged
        cmbIdTipoSangre.SelectedIndex = cmbTipoSangre.SelectedIndex
    End Sub

    Private Sub cmbTipoUsu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoUsu.SelectedIndexChanged
        cmbIdTipoUsu.SelectedIndex = cmbTipoUsu.SelectedIndex

        If Val(cmbIdTipoUsu.SelectedIndex) = 2 Then
            txtEstatura.Enabled = True
            txtPeso.Enabled = True
        Else
            txtEstatura.Enabled = False
            txtPeso.Enabled = False
            txtPeso.Clear()
            txtEstatura.Clear()
        End If
        If Val(cmbIdTipoUsu.SelectedIndex) = 1 Then
            cmbEspecialidad.Enabled = True
        Else
            cmbEspecialidad.Enabled = False
            cmbEspecialidad.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbIdTipoUsu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdTipoUsu.SelectedIndexChanged

    End Sub

    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged
        cmbIdEspec.SelectedIndex = cmbEspecialidad.SelectedIndex
    End Sub

    Private Sub BtConEnfe_Click(sender As Object, e As EventArgs) Handles BtConEnfe.Click
        Dim sql As String = "INSERT INTO usuario VALUES (id_usuario=" & lbIdUsuario.Text & ", id_tipo= " & cmbIdTipoUsu.SelectedIndex & ", nombre ='" & txtNombre.Text & "', apellido='" & txtApellido.Text & "', email='" & txtCorreo.Text & "', contraseña ='" & TxtPassword.Text & "')"
        Dim respuesta As Byte = MsgBox("Desea agregar el registro", vbOKCancel)
        If respuesta = vbOK Then
            If cmbIdTipoUsu.SelectedIndex = 1 Then
                MsgBox(sql)
                abrirConexion()
                Dim eje As New OleDb.OleDbCommand
                Dim sql2 As String = "INSERT INTO doctor VALUES (id_doctor=" & lbIdUsuario.Text & ", dpi= , apellido='" & txtApellido.Text & "',nombre ='" & txtNombre.Text & "'fecha_nacimiento = '" & dtFechaNac.Value.ToShortDateString & "' direccion= '" & txtDireccion.Text & "', telefono= " & txtTelefono.Text & ", id_tipo_sangre =" & cmbIdTipoSangre.SelectedIndex & ", id_espec = '" & cmbIdEspec.SelectedIndex & "')"
                'Dim res As OleDb.OleDbDataReader
                eje.CommandType = CommandType.Text
                eje.Connection = conexion
                eje.CommandText = sql
                eje.ExecuteNonQuery()
                eje.CommandText = sql2
                eje.ExecuteNonQuery()
                cerrarConexion()
            End If
        End If

    End Sub
End Class