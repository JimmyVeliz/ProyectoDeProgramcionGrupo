Imports System.Runtime.InteropServices
Public Class FrmLogin

#Region "Codigo de los botones de cerrar y minimizar"
    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles BtCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtMinimizar_Click(sender As Object, e As EventArgs) Handles BtMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Codigo para mover el formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FrmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbCorreo.Click

    End Sub

#End Region

#Region "Modificacion de las cajas de texto"
    Private Sub PersonalizarControles()
        'Modificar caja de texto ususario
        txtEmail.AutoSize = False
        txtEmail.Size = New Size(341, 30)
        'Modificar caja de contraseña
        txtContra.AutoSize = False
        txtContra.Size = New Size(341, 30)
        txtContra.UseSystemPasswordChar = True
    End Sub


#End Region

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        PersonalizarControles()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbVerContra.CheckedChanged
        If chbVerContra.Checked = False Then
            txtContra.UseSystemPasswordChar = True
        Else
            txtContra.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnSesion_Paint(sender As Object, e As PaintEventArgs) Handles btnSesion.Paint
        Dim btnPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim miRectangulo As Rectangle = btnSesion.ClientRectangle
        miRectangulo.Inflate(0, 25)
        btnPath.AddEllipse(miRectangulo)
        btnSesion.Region = New Region(btnPath)
    End Sub

    Private Sub btnSesion_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        Dim sqlBuscarUsuario As String = "SELECT * FROM Usuario WHERE Email ='" & txtEmail.Text & "' AND Contraseña = '" & txtContra.Text & "'"
        Dim ejecutar As New OleDb.OleDbCommand
        Dim respuesta As OleDb.OleDbDataReader
        abrirConexion()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sqlBuscarUsuario
        respuesta = ejecutar.ExecuteReader

        While (respuesta.Read)
            If respuesta.HasRows Then
                Me.Hide()
                nombreUsuario = respuesta!Apellido & ", " & respuesta!Nombre
                emailUsuario = respuesta!Email
                idUsuario = respuesta!id_usuario
                tipoUsuario = respuesta!id_tipo
                'MsgBox(respuesta!Apellido & ", " & respuesta!Nombre)
                FrmBienvenida.ShowDialog()
                'FormPrincipal.Show()
                AddHandler FormPrincipal.FormClosed, AddressOf Me.cerrarSesion

            Else
                MsgBox("Datos incorrectos, intente nuevamente")
                txtContra.Clear()
                txtContra.Focus()
            End If
        End While
        respuesta.Close()
        cerrarConexion()
    End Sub

    Private Sub cerrarSesion(sender As Object, e As FormClosedEventArgs)
        txtContra.Clear()
        txtEmail.Clear()
        Me.Show()
        txtEmail.Focus()
    End Sub
    Private Sub txtContra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContra.KeyDown
        If e.KeyCode = Keys.Enter Then

            btnSesion_Click(True, Nothing)

        End If
    End Sub
End Class
