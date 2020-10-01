<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PnContenedor = New System.Windows.Forms.Panel()
        Me.PnFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnMenu = New System.Windows.Forms.Panel()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtMenu = New System.Windows.Forms.PictureBox()
        Me.btnEnfermera = New System.Windows.Forms.Button()
        Me.btnDoctor = New System.Windows.Forms.Button()
        Me.btnPacientes = New System.Windows.Forms.Button()
        Me.PnTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtRestaurar = New System.Windows.Forms.PictureBox()
        Me.BtMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtCerrar = New System.Windows.Forms.PictureBox()
        Me.TmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.lbIdTipo = New System.Windows.Forms.Label()
        Me.PnContenedor.SuspendLayout()
        Me.PnFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnTitulo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnContenedor
        '
        Me.PnContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PnContenedor.Controls.Add(Me.PnFormularios)
        Me.PnContenedor.Controls.Add(Me.PnMenu)
        Me.PnContenedor.Controls.Add(Me.PnTitulo)
        Me.PnContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PnContenedor.Name = "PnContenedor"
        Me.PnContenedor.Size = New System.Drawing.Size(1000, 700)
        Me.PnContenedor.TabIndex = 0
        '
        'PnFormularios
        '
        Me.PnFormularios.BackColor = System.Drawing.Color.White
        Me.PnFormularios.Controls.Add(Me.PictureBox1)
        Me.PnFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnFormularios.Location = New System.Drawing.Point(210, 40)
        Me.PnFormularios.Name = "PnFormularios"
        Me.PnFormularios.Size = New System.Drawing.Size(790, 660)
        Me.PnFormularios.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Proyecto_3.My.Resources.Resources.Logo_usac
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(790, 660)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PnMenu
        '
        Me.PnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PnMenu.Controls.Add(Me.lbIdTipo)
        Me.PnMenu.Controls.Add(Me.lbEmail)
        Me.PnMenu.Controls.Add(Me.lbNombre)
        Me.PnMenu.Controls.Add(Me.PictureBox2)
        Me.PnMenu.Controls.Add(Me.BtMenu)
        Me.PnMenu.Controls.Add(Me.btnEnfermera)
        Me.PnMenu.Controls.Add(Me.btnDoctor)
        Me.PnMenu.Controls.Add(Me.btnPacientes)
        Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnMenu.Location = New System.Drawing.Point(0, 40)
        Me.PnMenu.Name = "PnMenu"
        Me.PnMenu.Size = New System.Drawing.Size(210, 660)
        Me.PnMenu.TabIndex = 1
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbEmail.Location = New System.Drawing.Point(5, 287)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(49, 23)
        Me.lbEmail.TabIndex = 4
        Me.lbEmail.Text = "Email"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbNombre.Location = New System.Drawing.Point(3, 252)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(68, 23)
        Me.lbNombre.TabIndex = 3
        Me.lbNombre.Text = "Nombre"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto_3.My.Resources.Resources.cerrar_sesion2
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 605)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'BtMenu
        '
        Me.BtMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMenu.Image = Global.Proyecto_3.My.Resources.Resources.menu2
        Me.BtMenu.Location = New System.Drawing.Point(172, 6)
        Me.BtMenu.Name = "BtMenu"
        Me.BtMenu.Size = New System.Drawing.Size(32, 32)
        Me.BtMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtMenu.TabIndex = 1
        Me.BtMenu.TabStop = False
        '
        'btnEnfermera
        '
        Me.btnEnfermera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnfermera.FlatAppearance.BorderSize = 0
        Me.btnEnfermera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEnfermera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEnfermera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnfermera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnfermera.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEnfermera.Image = Global.Proyecto_3.My.Resources.Resources.Enfermera2
        Me.btnEnfermera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnfermera.Location = New System.Drawing.Point(3, 168)
        Me.btnEnfermera.Name = "btnEnfermera"
        Me.btnEnfermera.Size = New System.Drawing.Size(207, 50)
        Me.btnEnfermera.TabIndex = 0
        Me.btnEnfermera.Text = "Enfermeras"
        Me.btnEnfermera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnfermera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnfermera.UseVisualStyleBackColor = True
        '
        'btnDoctor
        '
        Me.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoctor.FlatAppearance.BorderSize = 0
        Me.btnDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctor.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDoctor.Image = Global.Proyecto_3.My.Resources.Resources.Doctor_blue_icon3
        Me.btnDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDoctor.Location = New System.Drawing.Point(3, 112)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.Size = New System.Drawing.Size(207, 50)
        Me.btnDoctor.TabIndex = 0
        Me.btnDoctor.Text = "Doctores"
        Me.btnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDoctor.UseVisualStyleBackColor = True
        '
        'btnPacientes
        '
        Me.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacientes.FlatAppearance.BorderSize = 0
        Me.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPacientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPacientes.Image = Global.Proyecto_3.My.Resources.Resources.medico_2
        Me.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPacientes.Location = New System.Drawing.Point(3, 56)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(207, 50)
        Me.btnPacientes.TabIndex = 0
        Me.btnPacientes.Text = "Pacientes"
        Me.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPacientes.UseVisualStyleBackColor = True
        '
        'PnTitulo
        '
        Me.PnTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PnTitulo.Controls.Add(Me.PictureBox3)
        Me.PnTitulo.Controls.Add(Me.BtRestaurar)
        Me.PnTitulo.Controls.Add(Me.BtMinimizar)
        Me.PnTitulo.Controls.Add(Me.BtMaximizar)
        Me.PnTitulo.Controls.Add(Me.BtCerrar)
        Me.PnTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PnTitulo.Name = "PnTitulo"
        Me.PnTitulo.Size = New System.Drawing.Size(1000, 40)
        Me.PnTitulo.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto_3.My.Resources.Resources.medicine_2_icon_icons_com_66043
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'BtRestaurar
        '
        Me.BtRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtRestaurar.Image = Global.Proyecto_3.My.Resources.Resources.Normal
        Me.BtRestaurar.Location = New System.Drawing.Point(950, 12)
        Me.BtRestaurar.Name = "BtRestaurar"
        Me.BtRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.BtRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtRestaurar.TabIndex = 0
        Me.BtRestaurar.TabStop = False
        Me.BtRestaurar.Visible = False
        '
        'BtMinimizar
        '
        Me.BtMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMinimizar.Image = Global.Proyecto_3.My.Resources.Resources.Minimize
        Me.BtMinimizar.Location = New System.Drawing.Point(928, 12)
        Me.BtMinimizar.Name = "BtMinimizar"
        Me.BtMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.BtMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtMinimizar.TabIndex = 0
        Me.BtMinimizar.TabStop = False
        '
        'BtMaximizar
        '
        Me.BtMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMaximizar.Image = Global.Proyecto_3.My.Resources.Resources.maximize3
        Me.BtMaximizar.Location = New System.Drawing.Point(950, 12)
        Me.BtMaximizar.Name = "BtMaximizar"
        Me.BtMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.BtMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtMaximizar.TabIndex = 0
        Me.BtMaximizar.TabStop = False
        '
        'BtCerrar
        '
        Me.BtCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCerrar.Image = Global.Proyecto_3.My.Resources.Resources.Close
        Me.BtCerrar.Location = New System.Drawing.Point(972, 12)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(16, 16)
        Me.BtCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtCerrar.TabIndex = 0
        Me.BtCerrar.TabStop = False
        '
        'TmOcultarMenu
        '
        '
        'TmMostrarMenu
        '
        '
        'lbIdTipo
        '
        Me.lbIdTipo.AutoSize = True
        Me.lbIdTipo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbIdTipo.Location = New System.Drawing.Point(6, 342)
        Me.lbIdTipo.Name = "lbIdTipo"
        Me.lbIdTipo.Size = New System.Drawing.Size(76, 13)
        Me.lbIdTipo.TabIndex = 1
        Me.lbIdTipo.Text = "tipo de usuario"
        Me.lbIdTipo.Visible = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(550, 400)
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.PnContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "FormPrincipal"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnContenedor.ResumeLayout(False)
        Me.PnFormularios.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnMenu.ResumeLayout(False)
        Me.PnMenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnTitulo.ResumeLayout(False)
        Me.PnTitulo.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnContenedor As Panel
    Friend WithEvents PnTitulo As Panel
    Friend WithEvents PnFormularios As Panel
    Friend WithEvents PnMenu As Panel
    Friend WithEvents BtCerrar As PictureBox
    Friend WithEvents BtRestaurar As PictureBox
    Friend WithEvents BtMinimizar As PictureBox
    Friend WithEvents BtMaximizar As PictureBox
    Friend WithEvents btnEnfermera As Button
    Friend WithEvents btnDoctor As Button
    Friend WithEvents btnPacientes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtMenu As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TmOcultarMenu As Timer
    Friend WithEvents TmMostrarMenu As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbIdTipo As Label
End Class
