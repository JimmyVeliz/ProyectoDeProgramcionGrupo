<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditarPaci
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarPaci))
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbTipoSangre = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbFechaNac = New System.Windows.Forms.Label()
        Me.lbPeso = New System.Windows.Forms.Label()
        Me.lbEstatura = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtEstatura = New System.Windows.Forms.TextBox()
        Me.dtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lbDpi = New System.Windows.Forms.Label()
        Me.txtDpi = New System.Windows.Forms.TextBox()
        Me.cbmTipoSangre = New System.Windows.Forms.ComboBox()
        Me.cbmIdTipoSangre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbIdU = New System.Windows.Forms.Label()
        Me.lbNombreU = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(25, 22)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(21, 17)
        Me.label5.TabIndex = 27
        Me.label5.Text = "ID"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(171, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(244, 23)
        Me.txtId.TabIndex = 26
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(25, 167)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 17)
        Me.label4.TabIndex = 23
        Me.label4.Text = "Teléfono:"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(25, 138)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 17)
        Me.label3.TabIndex = 22
        Me.label3.Text = "Direccion:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(25, 109)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(69, 17)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Apellidos:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(25, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(69, 17)
        Me.label2.TabIndex = 20
        Me.label2.Text = "Nombres:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(171, 164)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(244, 23)
        Me.txtTelefono.TabIndex = 19
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(171, 135)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(244, 23)
        Me.txtDireccion.TabIndex = 18
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(171, 106)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(244, 23)
        Me.txtApellido.TabIndex = 17
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(171, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(244, 23)
        Me.txtNombre.TabIndex = 16
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(186, 357)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 30)
        Me.btnNuevo.TabIndex = 30
        Me.btnNuevo.Text = "Guardar"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(304, 357)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 30)
        Me.btnEditar.TabIndex = 29
        Me.btnEditar.Text = "Cancelar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(448, 77)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(144, 157)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 28
        Me.pictureBox1.TabStop = False
        '
        'lbTipoSangre
        '
        Me.lbTipoSangre.AutoSize = True
        Me.lbTipoSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoSangre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbTipoSangre.Location = New System.Drawing.Point(25, 196)
        Me.lbTipoSangre.Name = "lbTipoSangre"
        Me.lbTipoSangre.Size = New System.Drawing.Size(108, 17)
        Me.lbTipoSangre.TabIndex = 40
        Me.lbTipoSangre.Text = "Tipo de sangre:"
        Me.lbTipoSangre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEdad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbEdad.Location = New System.Drawing.Point(25, 310)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(45, 17)
        Me.lbEdad.TabIndex = 38
        Me.lbEdad.Text = "Edad:"
        Me.lbEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFechaNac
        '
        Me.lbFechaNac.AutoSize = True
        Me.lbFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbFechaNac.Location = New System.Drawing.Point(25, 281)
        Me.lbFechaNac.Name = "lbFechaNac"
        Me.lbFechaNac.Size = New System.Drawing.Size(143, 17)
        Me.lbFechaNac.TabIndex = 37
        Me.lbFechaNac.Text = "Fecha de nacimiento:"
        Me.lbFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPeso
        '
        Me.lbPeso.AutoSize = True
        Me.lbPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbPeso.Location = New System.Drawing.Point(25, 252)
        Me.lbPeso.Name = "lbPeso"
        Me.lbPeso.Size = New System.Drawing.Size(44, 17)
        Me.lbPeso.TabIndex = 36
        Me.lbPeso.Text = "Peso:"
        Me.lbPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbEstatura
        '
        Me.lbEstatura.AutoSize = True
        Me.lbEstatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbEstatura.Location = New System.Drawing.Point(25, 223)
        Me.lbEstatura.Name = "lbEstatura"
        Me.lbEstatura.Size = New System.Drawing.Size(65, 17)
        Me.lbEstatura.TabIndex = 35
        Me.lbEstatura.Text = "Estatura:"
        Me.lbEstatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(171, 307)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(244, 23)
        Me.txtEdad.TabIndex = 34
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(171, 249)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(244, 23)
        Me.txtPeso.TabIndex = 32
        '
        'txtEstatura
        '
        Me.txtEstatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstatura.Location = New System.Drawing.Point(171, 220)
        Me.txtEstatura.Name = "txtEstatura"
        Me.txtEstatura.Size = New System.Drawing.Size(244, 23)
        Me.txtEstatura.TabIndex = 31
        '
        'dtFechaNac
        '
        Me.dtFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaNac.Location = New System.Drawing.Point(171, 276)
        Me.dtFechaNac.Name = "dtFechaNac"
        Me.dtFechaNac.Size = New System.Drawing.Size(244, 22)
        Me.dtFechaNac.TabIndex = 42
        '
        'lbDpi
        '
        Me.lbDpi.AutoSize = True
        Me.lbDpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDpi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbDpi.Location = New System.Drawing.Point(25, 51)
        Me.lbDpi.Name = "lbDpi"
        Me.lbDpi.Size = New System.Drawing.Size(30, 17)
        Me.lbDpi.TabIndex = 44
        Me.lbDpi.Text = "DPI"
        Me.lbDpi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDpi
        '
        Me.txtDpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpi.Location = New System.Drawing.Point(171, 48)
        Me.txtDpi.Name = "txtDpi"
        Me.txtDpi.ReadOnly = True
        Me.txtDpi.Size = New System.Drawing.Size(244, 23)
        Me.txtDpi.TabIndex = 43
        '
        'cbmTipoSangre
        '
        Me.cbmTipoSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmTipoSangre.FormattingEnabled = True
        Me.cbmTipoSangre.Location = New System.Drawing.Point(171, 191)
        Me.cbmTipoSangre.Name = "cbmTipoSangre"
        Me.cbmTipoSangre.Size = New System.Drawing.Size(244, 24)
        Me.cbmTipoSangre.TabIndex = 46
        '
        'cbmIdTipoSangre
        '
        Me.cbmIdTipoSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmIdTipoSangre.FormattingEnabled = True
        Me.cbmIdTipoSangre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbmIdTipoSangre.Location = New System.Drawing.Point(457, 252)
        Me.cbmIdTipoSangre.Name = "cbmIdTipoSangre"
        Me.cbmIdTipoSangre.Size = New System.Drawing.Size(161, 24)
        Me.cbmIdTipoSangre.TabIndex = 47
        Me.cbmIdTipoSangre.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(423, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 23)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Id Usuario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(421, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 23)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Nombre:"
        '
        'lbIdU
        '
        Me.lbIdU.AutoSize = True
        Me.lbIdU.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdU.ForeColor = System.Drawing.Color.Black
        Me.lbIdU.Location = New System.Drawing.Point(521, 44)
        Me.lbIdU.Name = "lbIdU"
        Me.lbIdU.Size = New System.Drawing.Size(94, 23)
        Me.lbIdU.TabIndex = 57
        Me.lbIdU.Text = "Id Usuario:"
        '
        'lbNombreU
        '
        Me.lbNombreU.AutoSize = True
        Me.lbNombreU.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombreU.ForeColor = System.Drawing.Color.Black
        Me.lbNombreU.Location = New System.Drawing.Point(519, 9)
        Me.lbNombreU.Name = "lbNombreU"
        Me.lbNombreU.Size = New System.Drawing.Size(73, 23)
        Me.lbNombreU.TabIndex = 56
        Me.lbNombreU.Text = "Nombre:"
        '
        'FrmEditarPaci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(645, 402)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbIdU)
        Me.Controls.Add(Me.lbNombreU)
        Me.Controls.Add(Me.cbmIdTipoSangre)
        Me.Controls.Add(Me.cbmTipoSangre)
        Me.Controls.Add(Me.lbDpi)
        Me.Controls.Add(Me.txtDpi)
        Me.Controls.Add(Me.dtFechaNac)
        Me.Controls.Add(Me.lbTipoSangre)
        Me.Controls.Add(Me.lbEdad)
        Me.Controls.Add(Me.lbFechaNac)
        Me.Controls.Add(Me.lbPeso)
        Me.Controls.Add(Me.lbEstatura)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtEstatura)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmEditarPaci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formulario Mantenimiento Paciente"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents btnNuevo As Button
    Private WithEvents btnEditar As Button
    Public WithEvents txtId As TextBox
    Public WithEvents txtTelefono As TextBox
    Public WithEvents txtDireccion As TextBox
    Public WithEvents txtApellido As TextBox
    Public WithEvents txtNombre As TextBox
    Private WithEvents lbTipoSangre As Label
    Private WithEvents lbEdad As Label
    Private WithEvents lbFechaNac As Label
    Private WithEvents lbPeso As Label
    Private WithEvents lbEstatura As Label
    Public WithEvents txtEdad As TextBox
    Public WithEvents txtPeso As TextBox
    Public WithEvents txtEstatura As TextBox
    Private WithEvents lbDpi As Label
    Public WithEvents txtDpi As TextBox
    Public WithEvents dtFechaNac As DateTimePicker
    Public WithEvents cbmTipoSangre As ComboBox
    Public WithEvents cbmIdTipoSangre As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbIdU As Label
    Friend WithEvents lbNombreU As Label
End Class
