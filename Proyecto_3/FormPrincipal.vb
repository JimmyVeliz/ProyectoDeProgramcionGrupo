Imports System.Runtime.InteropServices

Public Class FormPrincipal
#Region "Funciones del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PnContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PnTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PnTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles BtCerrar.Click
        Application.Exit()
    End Sub
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub BtMinimizar_Click(sender As Object, e As EventArgs) Handles BtMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BtMaximizar_Click(sender As Object, e As EventArgs) Handles BtMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        BtMaximizar.Visible = False
        BtRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub BtRestaurar_Click(sender As Object, e As EventArgs) Handles BtRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        BtRestaurar.Visible = False
        BtMaximizar.Visible = True

    End Sub

    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles BtMenu.Click
        If PnMenu.Width = 210 Then
            TmOcultarMenu.Enabled = True
        ElseIf PnMenu.Width <= 55 Then
            TmMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub TmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TmOcultarMenu.Tick
        If PnMenu.Width <= 55 Then
            Me.TmOcultarMenu.Enabled = False
        Else
            Me.PnMenu.Width = PnMenu.Width - 20
        End If
    End Sub

    Private Sub TmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TmMostrarMenu.Tick
        If PnMenu.Width >= 210 Then
            Me.TmMostrarMenu.Enabled = False
        Else
            Me.PnMenu.Width = PnMenu.Width + 20
        End If
    End Sub
#End Region


    Private Sub AbrirFormEnPanel(Of MiForm As {Form, New})()
        Dim formulario As Form
        formulario = PnFormularios.Controls.OfType(Of MiForm)().FirstOrDefault() 'busca el formulario en la coleccion
        'si el formulario no fue encontrado no existe
        If formulario Is Nothing Then
            formulario = New MiForm()
            formulario.TopLevel = False

            formulario.FormBorderStyle = FormBorderStyle.None 'Quitamos el borde del formulario
            formulario.Dock = DockStyle.Fill 'Acoplamos el formulario al area
            formulario.Opacity = Opacity.Equals(10)

            PnFormularios.Controls.Add(formulario)
            PnFormularios.Tag = formulario
            AddHandler formulario.FormClosed, AddressOf Me.CerrarFormulairo

            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
            formulario.Opacity = Opacity.Equals(50)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        AbrirFormEnPanel(Of FrmPaciente)()
        btnPacientes.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        AbrirFormEnPanel(Of FrmDoctor)()
        btnDoctor.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub PnTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PnTitulo.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MessageBox.Show("Esta seguro de cerrar sesion", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lbEmail_Click(sender As Object, e As EventArgs) Handles lbEmail.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEnfermera.Click
        AbrirFormEnPanel(Of FrmEnfermera)()
        btnEnfermera.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    'Metodo cerrar formularios
    Private Sub CerrarFormulairo(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'condicion si el form esta abierto
        If (Application.OpenForms("Form1") Is Nothing) Then
            btnPacientes.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form2") Is Nothing) Then
            btnDoctor.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            btnEnfermera.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbEmail.Text = emailUsuario
        lbNombre.Text = nombreUsuario
        lbIdTipo.Text = tipoUsuario
        If tipoUsuario = 2 Then
            btnPacientes.Visible = False
            btnEnfermera.Visible = False
        End If
        If tipoUsuario = 1 Then
            btnDoctor.Visible = False
            btnEnfermera.Visible = False
        End If
    End Sub
End Class
