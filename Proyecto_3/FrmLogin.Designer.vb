<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.BtMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbContra = New System.Windows.Forms.Label()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.btnSesion = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.liLbRecuperar = New System.Windows.Forms.LinkLabel()
        Me.chbVerContra = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.BtMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.BtMinimizar)
        Me.BarraTitulo.Controls.Add(Me.BtCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(447, 40)
        Me.BarraTitulo.TabIndex = 0
        '
        'BtMinimizar
        '
        Me.BtMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtMinimizar.Image = Global.Proyecto_3.My.Resources.Resources.Minimize
        Me.BtMinimizar.Location = New System.Drawing.Point(400, 12)
        Me.BtMinimizar.Name = "BtMinimizar"
        Me.BtMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.BtMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtMinimizar.TabIndex = 2
        Me.BtMinimizar.TabStop = False
        '
        'BtCerrar
        '
        Me.BtCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCerrar.Image = Global.Proyecto_3.My.Resources.Resources.Close
        Me.BtCerrar.Location = New System.Drawing.Point(422, 12)
        Me.BtCerrar.Name = "BtCerrar"
        Me.BtCerrar.Size = New System.Drawing.Size(16, 16)
        Me.BtCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtCerrar.TabIndex = 3
        Me.BtCerrar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 685)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 15)
        Me.Panel1.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Silver
        Me.txtEmail.Location = New System.Drawing.Point(64, 338)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(341, 23)
        Me.txtEmail.TabIndex = 2
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCorreo.ForeColor = System.Drawing.Color.Silver
        Me.lbCorreo.Location = New System.Drawing.Point(60, 312)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(61, 23)
        Me.lbCorreo.TabIndex = 4
        Me.lbCorreo.Text = "Correo"
        '
        'lbContra
        '
        Me.lbContra.AutoSize = True
        Me.lbContra.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContra.ForeColor = System.Drawing.Color.Silver
        Me.lbContra.Location = New System.Drawing.Point(60, 372)
        Me.lbContra.Name = "lbContra"
        Me.lbContra.Size = New System.Drawing.Size(95, 23)
        Me.lbContra.TabIndex = 6
        Me.lbContra.Text = "Contraseña"
        '
        'txtContra
        '
        Me.txtContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContra.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.ForeColor = System.Drawing.Color.Silver
        Me.txtContra.Location = New System.Drawing.Point(64, 398)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(341, 23)
        Me.txtContra.TabIndex = 5
        '
        'btnSesion
        '
        Me.btnSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnSesion.FlatAppearance.BorderSize = 0
        Me.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSesion.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSesion.ForeColor = System.Drawing.Color.White
        Me.btnSesion.Location = New System.Drawing.Point(99, 520)
        Me.btnSesion.Name = "btnSesion"
        Me.btnSesion.Size = New System.Drawing.Size(239, 35)
        Me.btnSesion.TabIndex = 7
        Me.btnSesion.Text = "Iniciar Sesion"
        Me.btnSesion.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(447, 700)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DarkGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 64
        Me.LineShape1.X2 = 373
        Me.LineShape1.Y1 = 633
        Me.LineShape1.Y2 = 633
        '
        'liLbRecuperar
        '
        Me.liLbRecuperar.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.liLbRecuperar.AutoSize = True
        Me.liLbRecuperar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liLbRecuperar.LinkColor = System.Drawing.Color.Silver
        Me.liLbRecuperar.Location = New System.Drawing.Point(156, 642)
        Me.liLbRecuperar.Name = "liLbRecuperar"
        Me.liLbRecuperar.Size = New System.Drawing.Size(122, 19)
        Me.liLbRecuperar.TabIndex = 9
        Me.liLbRecuperar.TabStop = True
        Me.liLbRecuperar.Text = "Olvido Contraseña"
        '
        'chbVerContra
        '
        Me.chbVerContra.AutoSize = True
        Me.chbVerContra.ForeColor = System.Drawing.Color.Silver
        Me.chbVerContra.Location = New System.Drawing.Point(324, 442)
        Me.chbVerContra.Name = "chbVerContra"
        Me.chbVerContra.Size = New System.Drawing.Size(99, 17)
        Me.chbVerContra.TabIndex = 10
        Me.chbVerContra.Text = "Ver Contraseña"
        Me.chbVerContra.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(64, 442)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Recordarme"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_3.My.Resources.Resources.Usuario2
        Me.PictureBox1.Location = New System.Drawing.Point(160, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(447, 700)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chbVerContra)
        Me.Controls.Add(Me.liLbRecuperar)
        Me.Controls.Add(Me.btnSesion)
        Me.Controls.Add(Me.lbContra)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.lbCorreo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.BtMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtMinimizar As PictureBox
    Friend WithEvents BtCerrar As PictureBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbContra As Label
    Friend WithEvents txtContra As TextBox
    Friend WithEvents btnSesion As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents liLbRecuperar As LinkLabel
    Friend WithEvents chbVerContra As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
