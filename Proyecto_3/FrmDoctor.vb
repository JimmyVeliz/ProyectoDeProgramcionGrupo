Public Class FrmDoctor
    Private Sub BtCerrarForm_Click(sender As Object, e As EventArgs) Handles BtCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub listaDoctor()
        Dim sql As String = "SELECT *, Doctor.id_espec as idEspec FROM Especialidad INNER JOIN Doctor on Especialidad.id_espec = Doctor.id_espec"
        Dim eje As New OleDb.OleDbCommand
        Dim res As OleDb.OleDbDataReader

        abrirConexion()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        res = eje.ExecuteReader
        dgvDoctores.Rows.Clear()
        While (res.Read)
            dgvDoctores.Rows.Add(res!id_doctor, res!dpi, res!apellido, res!nombre, res!edad, res!especialidad, res!Telefono, res!id_espec)
        End While
        res.Close()
        cerrarConexion()
    End Sub
    Private Sub TpConDoc_Click(sender As Object, e As EventArgs) Handles TpConDoc.Click

    End Sub

    Private Sub FrmDoctor_Load(sender As Object, e As EventArgs) Handles Me.Load
        listaDoctor()
    End Sub

    Private Sub btnAgendarCita_Click(sender As Object, e As EventArgs) Handles btnAgendarCita.Click
        FrmAgenda.txtIdDoctor.Text = dgvDoctores.CurrentRow.Cells(0).Value.ToString()
        FrmAgenda.txtNombreDoc.Text = dgvDoctores.CurrentRow.Cells(3).Value.ToString() & ", " & dgvDoctores.CurrentRow.Cells(2).Value.ToString()
        FrmAgenda.txtid.Text = idUsuario
        FrmAgenda.txtnombre.Text = nombreUsuario
        FrmAgenda.ShowDialog()
    End Sub
End Class