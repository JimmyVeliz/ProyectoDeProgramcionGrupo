<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoctor
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
        Me.TcEmpleados = New System.Windows.Forms.TabControl()
        Me.TpConDoc = New System.Windows.Forms.TabPage()
        Me.btnAgendarCita = New System.Windows.Forms.Button()
        Me.dgvDoctores = New System.Windows.Forms.DataGridView()
        Me.idDoctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEspec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpActDoc = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtActDoc = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.BtCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TcEmpleados.SuspendLayout()
        Me.TpConDoc.SuspendLayout()
        CType(Me.dgvDoctores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpActDoc.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtCerrarForm
        '
        Me.BtCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCerrarForm.Image = Global.Proyecto_3.My.Resources.Resources.cancel
        Me.BtCerrarForm.Location = New System.Drawing.Point(4, 12)
        Me.BtCerrarForm.Name = "BtCerrarForm"
        Me.BtCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.BtCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtCerrarForm.TabIndex = 7
        Me.BtCerrarForm.TabStop = False
        '
        'TcEmpleados
        '
        Me.TcEmpleados.Controls.Add(Me.TpConDoc)
        Me.TcEmpleados.Controls.Add(Me.TpActDoc)
        Me.TcEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.TcEmpleados.Name = "TcEmpleados"
        Me.TcEmpleados.SelectedIndex = 0
        Me.TcEmpleados.Size = New System.Drawing.Size(959, 380)
        Me.TcEmpleados.TabIndex = 8
        '
        'TpConDoc
        '
        Me.TpConDoc.Controls.Add(Me.btnAgendarCita)
        Me.TpConDoc.Controls.Add(Me.dgvDoctores)
        Me.TpConDoc.Location = New System.Drawing.Point(4, 22)
        Me.TpConDoc.Name = "TpConDoc"
        Me.TpConDoc.Padding = New System.Windows.Forms.Padding(3)
        Me.TpConDoc.Size = New System.Drawing.Size(951, 354)
        Me.TpConDoc.TabIndex = 0
        Me.TpConDoc.Text = "Doctores"
        Me.TpConDoc.UseVisualStyleBackColor = True
        '
        'btnAgendarCita
        '
        Me.btnAgendarCita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgendarCita.Location = New System.Drawing.Point(846, 6)
        Me.btnAgendarCita.Name = "btnAgendarCita"
        Me.btnAgendarCita.Size = New System.Drawing.Size(75, 23)
        Me.btnAgendarCita.TabIndex = 1
        Me.btnAgendarCita.Text = "Agendar cita"
        Me.btnAgendarCita.UseVisualStyleBackColor = True
        '
        'dgvDoctores
        '
        Me.dgvDoctores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDoctor, Me.dpi, Me.apellido, Me.nombre, Me.edad, Me.especialidad, Me.telefono, Me.idEspec})
        Me.dgvDoctores.Location = New System.Drawing.Point(6, 6)
        Me.dgvDoctores.Name = "dgvDoctores"
        Me.dgvDoctores.RowHeadersVisible = False
        Me.dgvDoctores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDoctores.Size = New System.Drawing.Size(836, 342)
        Me.dgvDoctores.TabIndex = 0
        '
        'idDoctor
        '
        Me.idDoctor.HeaderText = "Id Doctor"
        Me.idDoctor.Name = "idDoctor"
        '
        'dpi
        '
        Me.dpi.HeaderText = "DPI"
        Me.dpi.Name = "dpi"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'edad
        '
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        '
        'especialidad
        '
        Me.especialidad.HeaderText = "Especialidad"
        Me.especialidad.Name = "especialidad"
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        '
        'idEspec
        '
        Me.idEspec.HeaderText = "Id especialidad"
        Me.idEspec.Name = "idEspec"
        '
        'TpActDoc
        '
        Me.TpActDoc.Controls.Add(Me.Label8)
        Me.TpActDoc.Controls.Add(Me.Label9)
        Me.TpActDoc.Controls.Add(Me.Label10)
        Me.TpActDoc.Controls.Add(Me.Label11)
        Me.TpActDoc.Controls.Add(Me.Label12)
        Me.TpActDoc.Controls.Add(Me.Label13)
        Me.TpActDoc.Controls.Add(Me.BtActDoc)
        Me.TpActDoc.Controls.Add(Me.TextBox6)
        Me.TpActDoc.Controls.Add(Me.TextBox5)
        Me.TpActDoc.Controls.Add(Me.TextBox4)
        Me.TpActDoc.Controls.Add(Me.TextBox3)
        Me.TpActDoc.Controls.Add(Me.TextBox2)
        Me.TpActDoc.Controls.Add(Me.TextBox1)
        Me.TpActDoc.Controls.Add(Me.Label6)
        Me.TpActDoc.Location = New System.Drawing.Point(4, 22)
        Me.TpActDoc.Name = "TpActDoc"
        Me.TpActDoc.Padding = New System.Windows.Forms.Padding(3)
        Me.TpActDoc.Size = New System.Drawing.Size(951, 354)
        Me.TpActDoc.TabIndex = 1
        Me.TpActDoc.Text = "Mis doctores"
        Me.TpActDoc.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Numero de Clinica"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 23)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Horario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Especialidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 23)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 23)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Apellido"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 23)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "CUI"
        '
        'BtActDoc
        '
        Me.BtActDoc.Location = New System.Drawing.Point(669, 73)
        Me.BtActDoc.Name = "BtActDoc"
        Me.BtActDoc.Size = New System.Drawing.Size(75, 23)
        Me.BtActDoc.TabIndex = 2
        Me.BtActDoc.Text = "Actualizar"
        Me.BtActDoc.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(221, 219)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(347, 20)
        Me.TextBox6.TabIndex = 1
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(221, 176)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(347, 20)
        Me.TextBox5.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(221, 136)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(347, 20)
        Me.TextBox4.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(221, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(347, 20)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(347, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(347, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 23)
        Me.Label6.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(927, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 380)
        Me.Panel1.TabIndex = 9
        '
        'FrmDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 380)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TcEmpleados)
        Me.Name = "FrmDoctor"
        Me.Text = "Form2"
        CType(Me.BtCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TcEmpleados.ResumeLayout(False)
        Me.TpConDoc.ResumeLayout(False)
        CType(Me.dgvDoctores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpActDoc.ResumeLayout(False)
        Me.TpActDoc.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtCerrarForm As PictureBox
    Friend WithEvents TcEmpleados As TabControl
    Friend WithEvents TpConDoc As TabPage
    Friend WithEvents TpActDoc As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtActDoc As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents dgvDoctores As DataGridView
    Friend WithEvents idDoctor As DataGridViewTextBoxColumn
    Friend WithEvents btnAgendarCita As Button
    Friend WithEvents dpi As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents especialidad As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents idEspec As DataGridViewTextBoxColumn
End Class
