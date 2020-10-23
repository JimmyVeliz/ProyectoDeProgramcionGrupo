<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnfermera
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
        Me.BtCerrarForm = New System.Windows.Forms.PictureBox()
        Me.TcEnfermera = New System.Windows.Forms.TabControl()
        Me.TpConEnfe = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbIdEspec = New System.Windows.Forms.ComboBox()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lbIdUsuario = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtEstatura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbIdTipoUsu = New System.Windows.Forms.ComboBox()
        Me.cmbTipoUsu = New System.Windows.Forms.ComboBox()
        Me.cmbIdTipoSangre = New System.Windows.Forms.ComboBox()
        Me.cmbTipoSangre = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.dtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtConEnfe = New System.Windows.Forms.Button()
        Me.txtDpi = New System.Windows.Forms.TextBox()
        Me.LbClinEnfe = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbHoraEnfe = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbNomEnfe = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbApeEnfe = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TpActDoc = New System.Windows.Forms.TabPage()
        Me.BtActEnfe = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtCuiEnfe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MTxtEstatura = New System.Windows.Forms.MaskedTextBox()
        CType(Me.BtCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TcEnfermera.SuspendLayout()
        Me.TpConEnfe.SuspendLayout()
        Me.TpActDoc.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtCerrarForm
        '
        Me.BtCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCerrarForm.Image = Global.Proyecto_3.My.Resources.Resources.cancel
        Me.BtCerrarForm.Location = New System.Drawing.Point(8, 12)
        Me.BtCerrarForm.Name = "BtCerrarForm"
        Me.BtCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtCerrarForm.TabIndex = 7
        Me.BtCerrarForm.TabStop = False
        '
        'TcEnfermera
        '
        Me.TcEnfermera.Controls.Add(Me.TpConEnfe)
        Me.TcEnfermera.Controls.Add(Me.TpActDoc)
        Me.TcEnfermera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TcEnfermera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcEnfermera.Location = New System.Drawing.Point(0, 0)
        Me.TcEnfermera.Name = "TcEnfermera"
        Me.TcEnfermera.SelectedIndex = 0
        Me.TcEnfermera.Size = New System.Drawing.Size(966, 530)
        Me.TcEnfermera.TabIndex = 8
        '
        'TpConEnfe
        '
        Me.TpConEnfe.Controls.Add(Me.MTxtEstatura)
        Me.TpConEnfe.Controls.Add(Me.Label21)
        Me.TpConEnfe.Controls.Add(Me.cmbIdEspec)
        Me.TpConEnfe.Controls.Add(Me.cmbEspecialidad)
        Me.TpConEnfe.Controls.Add(Me.lbIdUsuario)
        Me.TpConEnfe.Controls.Add(Me.TxtPassword)
        Me.TpConEnfe.Controls.Add(Me.txtCorreo)
        Me.TpConEnfe.Controls.Add(Me.Label19)
        Me.TpConEnfe.Controls.Add(Me.Label20)
        Me.TpConEnfe.Controls.Add(Me.Label17)
        Me.TpConEnfe.Controls.Add(Me.Label18)
        Me.TpConEnfe.Controls.Add(Me.txtPeso)
        Me.TpConEnfe.Controls.Add(Me.txtEstatura)
        Me.TpConEnfe.Controls.Add(Me.Label15)
        Me.TpConEnfe.Controls.Add(Me.Label16)
        Me.TpConEnfe.Controls.Add(Me.cmbIdTipoUsu)
        Me.TpConEnfe.Controls.Add(Me.cmbTipoUsu)
        Me.TpConEnfe.Controls.Add(Me.cmbIdTipoSangre)
        Me.TpConEnfe.Controls.Add(Me.cmbTipoSangre)
        Me.TpConEnfe.Controls.Add(Me.txtTelefono)
        Me.TpConEnfe.Controls.Add(Me.txtDireccion)
        Me.TpConEnfe.Controls.Add(Me.txtNombre)
        Me.TpConEnfe.Controls.Add(Me.txtApellido)
        Me.TpConEnfe.Controls.Add(Me.dtFechaNac)
        Me.TpConEnfe.Controls.Add(Me.Label3)
        Me.TpConEnfe.Controls.Add(Me.Label9)
        Me.TpConEnfe.Controls.Add(Me.Label13)
        Me.TpConEnfe.Controls.Add(Me.Label14)
        Me.TpConEnfe.Controls.Add(Me.BtConEnfe)
        Me.TpConEnfe.Controls.Add(Me.txtDpi)
        Me.TpConEnfe.Controls.Add(Me.LbClinEnfe)
        Me.TpConEnfe.Controls.Add(Me.Label1)
        Me.TpConEnfe.Controls.Add(Me.LbHoraEnfe)
        Me.TpConEnfe.Controls.Add(Me.Label2)
        Me.TpConEnfe.Controls.Add(Me.LbNomEnfe)
        Me.TpConEnfe.Controls.Add(Me.Label4)
        Me.TpConEnfe.Controls.Add(Me.LbApeEnfe)
        Me.TpConEnfe.Controls.Add(Me.Label5)
        Me.TpConEnfe.Controls.Add(Me.Label7)
        Me.TpConEnfe.Location = New System.Drawing.Point(4, 22)
        Me.TpConEnfe.Name = "TpConEnfe"
        Me.TpConEnfe.Padding = New System.Windows.Forms.Padding(3)
        Me.TpConEnfe.Size = New System.Drawing.Size(958, 504)
        Me.TpConEnfe.TabIndex = 0
        Me.TpConEnfe.Text = "Consulta"
        Me.TpConEnfe.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(421, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 23)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Especialidad"
        '
        'cmbIdEspec
        '
        Me.cmbIdEspec.FormattingEnabled = True
        Me.cmbIdEspec.Location = New System.Drawing.Point(578, 6)
        Me.cmbIdEspec.Name = "cmbIdEspec"
        Me.cmbIdEspec.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdEspec.TabIndex = 40
        Me.cmbIdEspec.Visible = False
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecialidad.Enabled = False
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(578, 63)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbEspecialidad.TabIndex = 39
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.AutoSize = True
        Me.lbIdUsuario.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdUsuario.Location = New System.Drawing.Point(221, 27)
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.Size = New System.Drawing.Size(101, 23)
        Me.lbIdUsuario.TabIndex = 38
        Me.lbIdUsuario.Text = "ID Usuario"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(221, 463)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(347, 20)
        Me.TxtPassword.TabIndex = 37
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(221, 426)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(347, 20)
        Me.txtCorreo.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 460)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 23)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Contraseña"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 422)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 23)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Correo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(328, 383)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 19)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Lbs."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(328, 345)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 19)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Cm."
        '
        'txtPeso
        '
        Me.txtPeso.Enabled = False
        Me.txtPeso.Location = New System.Drawing.Point(221, 382)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(101, 20)
        Me.txtPeso.TabIndex = 31
        '
        'txtEstatura
        '
        Me.txtEstatura.Enabled = False
        Me.txtEstatura.Location = New System.Drawing.Point(221, 345)
        Me.txtEstatura.Name = "txtEstatura"
        Me.txtEstatura.Size = New System.Drawing.Size(101, 20)
        Me.txtEstatura.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 23)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Peso"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 341)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 23)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Estatura"
        '
        'cmbIdTipoUsu
        '
        Me.cmbIdTipoUsu.FormattingEnabled = True
        Me.cmbIdTipoUsu.Location = New System.Drawing.Point(221, 6)
        Me.cmbIdTipoUsu.Name = "cmbIdTipoUsu"
        Me.cmbIdTipoUsu.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdTipoUsu.TabIndex = 27
        Me.cmbIdTipoUsu.Visible = False
        '
        'cmbTipoUsu
        '
        Me.cmbTipoUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoUsu.FormattingEnabled = True
        Me.cmbTipoUsu.Location = New System.Drawing.Point(221, 63)
        Me.cmbTipoUsu.Name = "cmbTipoUsu"
        Me.cmbTipoUsu.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoUsu.TabIndex = 26
        '
        'cmbIdTipoSangre
        '
        Me.cmbIdTipoSangre.FormattingEnabled = True
        Me.cmbIdTipoSangre.Location = New System.Drawing.Point(407, 308)
        Me.cmbIdTipoSangre.Name = "cmbIdTipoSangre"
        Me.cmbIdTipoSangre.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdTipoSangre.TabIndex = 25
        Me.cmbIdTipoSangre.Visible = False
        '
        'cmbTipoSangre
        '
        Me.cmbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoSangre.FormattingEnabled = True
        Me.cmbTipoSangre.Location = New System.Drawing.Point(221, 308)
        Me.cmbTipoSangre.Name = "cmbTipoSangre"
        Me.cmbTipoSangre.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoSangre.TabIndex = 24
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(221, 270)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(347, 20)
        Me.txtTelefono.TabIndex = 23
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(221, 207)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(347, 20)
        Me.txtDireccion.TabIndex = 22
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(221, 170)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(347, 20)
        Me.txtNombre.TabIndex = 21
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(221, 134)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(347, 20)
        Me.txtApellido.TabIndex = 20
        '
        'dtFechaNac
        '
        Me.dtFechaNac.CustomFormat = "dd/mm/yyyy"
        Me.dtFechaNac.Location = New System.Drawing.Point(221, 240)
        Me.dtFechaNac.Name = "dtFechaNac"
        Me.dtFechaNac.Size = New System.Drawing.Size(209, 20)
        Me.dtFechaNac.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tipo de sangre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Telefono"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Tipo de usuario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "ID Usuario"
        '
        'BtConEnfe
        '
        Me.BtConEnfe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtConEnfe.Location = New System.Drawing.Point(648, 172)
        Me.BtConEnfe.Name = "BtConEnfe"
        Me.BtConEnfe.Size = New System.Drawing.Size(75, 23)
        Me.BtConEnfe.TabIndex = 14
        Me.BtConEnfe.Text = "Guardar"
        Me.BtConEnfe.UseVisualStyleBackColor = True
        '
        'txtDpi
        '
        Me.txtDpi.Location = New System.Drawing.Point(221, 97)
        Me.txtDpi.Name = "txtDpi"
        Me.txtDpi.Size = New System.Drawing.Size(347, 20)
        Me.txtDpi.TabIndex = 13
        '
        'LbClinEnfe
        '
        Me.LbClinEnfe.AutoSize = True
        Me.LbClinEnfe.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClinEnfe.Location = New System.Drawing.Point(866, 293)
        Me.LbClinEnfe.Name = "LbClinEnfe"
        Me.LbClinEnfe.Size = New System.Drawing.Size(0, 23)
        Me.LbClinEnfe.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha de Nacimiento"
        '
        'LbHoraEnfe
        '
        Me.LbHoraEnfe.AutoSize = True
        Me.LbHoraEnfe.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHoraEnfe.Location = New System.Drawing.Point(866, 260)
        Me.LbHoraEnfe.Name = "LbHoraEnfe"
        Me.LbHoraEnfe.Size = New System.Drawing.Size(0, 23)
        Me.LbHoraEnfe.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Direccion"
        '
        'LbNomEnfe
        '
        Me.LbNomEnfe.AutoSize = True
        Me.LbNomEnfe.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEnfe.Location = New System.Drawing.Point(866, 226)
        Me.LbNomEnfe.Name = "LbNomEnfe"
        Me.LbNomEnfe.Size = New System.Drawing.Size(0, 23)
        Me.LbNomEnfe.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre"
        '
        'LbApeEnfe
        '
        Me.LbApeEnfe.AutoSize = True
        Me.LbApeEnfe.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbApeEnfe.Location = New System.Drawing.Point(866, 190)
        Me.LbApeEnfe.Name = "LbApeEnfe"
        Me.LbApeEnfe.Size = New System.Drawing.Size(0, 23)
        Me.LbApeEnfe.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "DPI"
        '
        'TpActDoc
        '
        Me.TpActDoc.Controls.Add(Me.BtActEnfe)
        Me.TpActDoc.Controls.Add(Me.TextBox5)
        Me.TpActDoc.Controls.Add(Me.TextBox4)
        Me.TpActDoc.Controls.Add(Me.TextBox3)
        Me.TpActDoc.Controls.Add(Me.TextBox2)
        Me.TpActDoc.Controls.Add(Me.TxtCuiEnfe)
        Me.TpActDoc.Controls.Add(Me.Label6)
        Me.TpActDoc.Controls.Add(Me.Label8)
        Me.TpActDoc.Controls.Add(Me.Label10)
        Me.TpActDoc.Controls.Add(Me.Label11)
        Me.TpActDoc.Controls.Add(Me.Label12)
        Me.TpActDoc.Location = New System.Drawing.Point(4, 22)
        Me.TpActDoc.Name = "TpActDoc"
        Me.TpActDoc.Padding = New System.Windows.Forms.Padding(3)
        Me.TpActDoc.Size = New System.Drawing.Size(958, 504)
        Me.TpActDoc.TabIndex = 1
        Me.TpActDoc.Text = "Actualizar"
        Me.TpActDoc.UseVisualStyleBackColor = True
        '
        'BtActEnfe
        '
        Me.BtActEnfe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtActEnfe.Location = New System.Drawing.Point(669, 73)
        Me.BtActEnfe.Name = "BtActEnfe"
        Me.BtActEnfe.Size = New System.Drawing.Size(75, 23)
        Me.BtActEnfe.TabIndex = 14
        Me.BtActEnfe.Text = "Atualizar"
        Me.BtActEnfe.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(209, 164)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(347, 20)
        Me.TextBox5.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(209, 131)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(347, 20)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(209, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(347, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(209, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(347, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TxtCuiEnfe
        '
        Me.TxtCuiEnfe.Location = New System.Drawing.Point(209, 24)
        Me.TxtCuiEnfe.Name = "TxtCuiEnfe"
        Me.TxtCuiEnfe.Size = New System.Drawing.Size(347, 20)
        Me.TxtCuiEnfe.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Numero de Clinica"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Horario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 23)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 23)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "CUI"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(930, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(36, 530)
        Me.Panel1.TabIndex = 9
        '
        'MTxtEstatura
        '
        Me.MTxtEstatura.Location = New System.Drawing.Point(407, 345)
        Me.MTxtEstatura.Mask = "000"
        Me.MTxtEstatura.Name = "MTxtEstatura"
        Me.MTxtEstatura.Size = New System.Drawing.Size(56, 20)
        Me.MTxtEstatura.TabIndex = 42
        '
        'FrmEnfermera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 530)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TcEnfermera)
        Me.Name = "FrmEnfermera"
        Me.Text = "Form3"
        CType(Me.BtCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TcEnfermera.ResumeLayout(False)
        Me.TpConEnfe.ResumeLayout(False)
        Me.TpConEnfe.PerformLayout()
        Me.TpActDoc.ResumeLayout(False)
        Me.TpActDoc.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtCerrarForm As PictureBox
    Friend WithEvents TcEnfermera As TabControl
    Friend WithEvents TpConEnfe As TabPage
    Friend WithEvents TpActDoc As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtConEnfe As Button
    Friend WithEvents txtDpi As TextBox
    Friend WithEvents LbClinEnfe As Label
    Friend WithEvents LbHoraEnfe As Label
    Friend WithEvents LbNomEnfe As Label
    Friend WithEvents LbApeEnfe As Label
    Friend WithEvents BtActEnfe As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TxtCuiEnfe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dtFechaNac As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtEstatura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbIdTipoUsu As ComboBox
    Friend WithEvents cmbTipoUsu As ComboBox
    Friend WithEvents cmbIdTipoSangre As ComboBox
    Friend WithEvents cmbTipoSangre As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbIdUsuario As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbIdEspec As ComboBox
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents MTxtEstatura As MaskedTextBox
End Class
