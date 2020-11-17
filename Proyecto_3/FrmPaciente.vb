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

    Public Sub buscarApellido()
        Dim sql As String = "SELECT Paciente.id_tipo_sangre AS idTipoSangre, * FROM Paciente INNER JOIN Tipo_sangre ON Paciente.id_tipo_sangre = Tipo_sangre.id_tipo_sangre WHERE apellido like '%" & TxtBuscar.Text & "%'"
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

    Public Sub busarNombre()
        Dim sql As String = "SELECT Paciente.id_tipo_sangre AS idTipoSangre, * FROM Paciente INNER JOIN Tipo_sangre ON Paciente.id_tipo_sangre = Tipo_sangre.id_tipo_sangre WHERE nombre like '%" & TxtBuscar.Text & "%'"
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
    Public Sub buscarDpi()
        Dim sql As String = "SELECT Paciente.id_tipo_sangre AS idTipoSangre, * FROM Paciente INNER JOIN Tipo_sangre ON Paciente.id_tipo_sangre = Tipo_sangre.id_tipo_sangre WHERE DPI like '%" & TxtBuscar.Text & "%'"
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
        'MsgBox(sql)
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
#Region "En esta area se programo todo en relacion con la busqueda de datos"
    Private Sub RbApellido_CheckedChanged(sender As Object, e As EventArgs) Handles RbApellido.CheckedChanged
        'buscar datos por apellido
        If RbApellido.Checked = True Then
            'En esta linea de codigo cambiamos el color de fuente el radio boton utilizando codigo RGB si es selecionando para buscar
            RbApellido.ForeColor = Color.FromArgb(50, 190, 239)
            'En esta linea de codigo colocamos en negrita el radio boton seleccionado para bucar
            RbApellido.Font = New Font(RbApellido.Font, FontStyle.Bold)
            'En las siguientes dos linea de codigo colocamos los otros radio boton sin negrita para no ser confundido con el que temenos seleccionado
            RbNombre.Font = New Font(RbNombre.Font, FontStyle.Regular)
            RbDPI.Font = New Font(RbDPI.Font, FontStyle.Regular)

            'En las proximas cuatro lineas de codigo es donde desactivamos la seleccion de los otros radio boton y regresarlos a color negro 
            RbNombre.Checked = False
            RbNombre.ForeColor = Color.Black
            RbDPI.Checked = False
            RbDPI.ForeColor = Color.Black
            'Activamos el boton de buscar para que la busqueda sea automatica al momento de seleccionar el radio boton
            BtnBuscar_Click(True, Nothing)
        End If
    End Sub
    Private Sub RbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RbNombre.CheckedChanged
        'buscar datos por nombre
        If RbNombre.Checked = True Then
            RbNombre.ForeColor = Color.FromArgb(50, 190, 239)
            RbNombre.Font = New Font(RbNombre.Font, FontStyle.Bold)
            RbApellido.Font = New Font(RbApellido.Font, FontStyle.Regular)
            RbDPI.Font = New Font(RbDPI.Font, FontStyle.Regular)

            RbApellido.Checked = False
            RbApellido.ForeColor = Color.Black
            RbDPI.Checked = False
            RbDPI.ForeColor = Color.Black
            BtnBuscar_Click(True, Nothing)
        End If
    End Sub
    Private Sub RbDPI_CheckedChanged(sender As Object, e As EventArgs) Handles RbDPI.CheckedChanged
        'buscar datos por DPI
        If RbDPI.Checked = True Then
            RbDPI.ForeColor = Color.FromArgb(50, 190, 239)
            RbDPI.Font = New Font(RbDPI.Font, FontStyle.Bold)
            RbApellido.Font = New Font(RbApellido.Font, FontStyle.Regular)
            RbNombre.Font = New Font(RbNombre.Font, FontStyle.Regular)

            RbApellido.Checked = False
            RbApellido.ForeColor = Color.Black
            RbNombre.Checked = False
            RbNombre.ForeColor = Color.Black
            BtnBuscar_Click(True, Nothing)
        End If
    End Sub
    Private Sub ChbBuscar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbBuscar.CheckedChanged
        If ChbBuscar.Checked = True Then
            ChbBuscar.ForeColor = Color.FromArgb(184, 62, 31)
            RbApellido.Checked = True
            RbApellido.Visible = True
            RbNombre.Visible = True
            RbDPI.Visible = True
            TxtBuscar.Visible = True
            LbBuscar.Visible = True
        Else
            ChbBuscar.ForeColor = Color.Black
            RbApellido.Visible = False
            RbNombre.Visible = False
            RbDPI.Visible = False
            TxtBuscar.Visible = False
            LbBuscar.Visible = False
            TxtBuscar.Clear()
            listaPacientes()
        End If
    End Sub
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        BtnBuscar_Click(True, Nothing)
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If RbApellido.Checked = True Then
            buscarApellido()
        ElseIf RbNombre.Checked = True Then
            busarNombre()
        ElseIf RbDPI.Checked = True Then
            buscarDpi()
        End If
    End Sub
#End Region
    Private Sub TxtBuscar_MouseHover(sender As Object, e As EventArgs) Handles TxtBuscar.MouseHover
        TtInformacion.SetToolTip(TxtBuscar, "Ingrese informacion a buscar")
        TtInformacion.ToolTipTitle = "Buscar datos"
        TtInformacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FrmEditarPaci.txtId.ReadOnly = False
        FrmEditarPaci.txtDpi.ReadOnly = False
        FrmEditarPaci.btnNuevo.Visible = False
        FrmEditarPaci.BtnCrear.Visible = True

        FrmEditarPaci.Show()
    End Sub

    Private Sub BtnVistaPrevia_Click(sender As Object, e As EventArgs) Handles BtnVistaPrevia.Click
        'PrintPreviewDialog1.ShowDialog()
    End Sub
End Class