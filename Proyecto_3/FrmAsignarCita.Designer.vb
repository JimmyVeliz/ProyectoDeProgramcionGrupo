<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarCita
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFechaCita = New System.Windows.Forms.DateTimePicker()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.cmbPaciente = New System.Windows.Forms.ComboBox()
        Me.cmbIdEmpleado = New System.Windows.Forms.ComboBox()
        Me.cmbIdDoctor = New System.Windows.Forms.ComboBox()
        Me.btnAsignarCita = New System.Windows.Forms.Button()
        Me.btnNuevaCita = New System.Windows.Forms.Button()
        Me.lbIdDocPaci = New System.Windows.Forms.Label()
        Me.lbIdCita = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCita = New System.Windows.Forms.TextBox()
        Me.lbTipoUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paciente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de la cita:"
        '
        'dtFechaCita
        '
        Me.dtFechaCita.Location = New System.Drawing.Point(163, 112)
        Me.dtFechaCita.Name = "dtFechaCita"
        Me.dtFechaCita.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaCita.TabIndex = 3
        '
        'cmbDoctor
        '
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(163, 45)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(200, 21)
        Me.cmbDoctor.TabIndex = 4
        '
        'cmbPaciente
        '
        Me.cmbPaciente.FormattingEnabled = True
        Me.cmbPaciente.Location = New System.Drawing.Point(163, 79)
        Me.cmbPaciente.Name = "cmbPaciente"
        Me.cmbPaciente.Size = New System.Drawing.Size(200, 21)
        Me.cmbPaciente.TabIndex = 5
        '
        'cmbIdEmpleado
        '
        Me.cmbIdEmpleado.FormattingEnabled = True
        Me.cmbIdEmpleado.Location = New System.Drawing.Point(388, 79)
        Me.cmbIdEmpleado.Name = "cmbIdEmpleado"
        Me.cmbIdEmpleado.Size = New System.Drawing.Size(200, 21)
        Me.cmbIdEmpleado.TabIndex = 7
        '
        'cmbIdDoctor
        '
        Me.cmbIdDoctor.FormattingEnabled = True
        Me.cmbIdDoctor.Location = New System.Drawing.Point(388, 45)
        Me.cmbIdDoctor.Name = "cmbIdDoctor"
        Me.cmbIdDoctor.Size = New System.Drawing.Size(200, 21)
        Me.cmbIdDoctor.TabIndex = 6
        '
        'btnAsignarCita
        '
        Me.btnAsignarCita.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignarCita.Location = New System.Drawing.Point(163, 241)
        Me.btnAsignarCita.Name = "btnAsignarCita"
        Me.btnAsignarCita.Size = New System.Drawing.Size(155, 38)
        Me.btnAsignarCita.TabIndex = 8
        Me.btnAsignarCita.Text = "Asignar Cita"
        Me.btnAsignarCita.UseVisualStyleBackColor = True
        '
        'btnNuevaCita
        '
        Me.btnNuevaCita.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaCita.Location = New System.Drawing.Point(336, 241)
        Me.btnNuevaCita.Name = "btnNuevaCita"
        Me.btnNuevaCita.Size = New System.Drawing.Size(155, 38)
        Me.btnNuevaCita.TabIndex = 9
        Me.btnNuevaCita.Text = "Asignar Cita"
        Me.btnNuevaCita.UseVisualStyleBackColor = True
        '
        'lbIdDocPaci
        '
        Me.lbIdDocPaci.AutoSize = True
        Me.lbIdDocPaci.Location = New System.Drawing.Point(532, 9)
        Me.lbIdDocPaci.Name = "lbIdDocPaci"
        Me.lbIdDocPaci.Size = New System.Drawing.Size(56, 13)
        Me.lbIdDocPaci.TabIndex = 10
        Me.lbIdDocPaci.Text = "idDocPaci"
        '
        'lbIdCita
        '
        Me.lbIdCita.AutoSize = True
        Me.lbIdCita.Location = New System.Drawing.Point(552, 119)
        Me.lbIdCita.Name = "lbIdCita"
        Me.lbIdCita.Size = New System.Drawing.Size(36, 13)
        Me.lbIdCita.TabIndex = 11
        Me.lbIdCita.Text = "id Cita"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cita:"
        '
        'txtCita
        '
        Me.txtCita.Location = New System.Drawing.Point(163, 148)
        Me.txtCita.Multiline = True
        Me.txtCita.Name = "txtCita"
        Me.txtCita.Size = New System.Drawing.Size(425, 74)
        Me.txtCita.TabIndex = 13
        '
        'lbTipoUsuario
        '
        Me.lbTipoUsuario.AutoSize = True
        Me.lbTipoUsuario.Location = New System.Drawing.Point(532, 325)
        Me.lbTipoUsuario.Name = "lbTipoUsuario"
        Me.lbTipoUsuario.Size = New System.Drawing.Size(73, 13)
        Me.lbTipoUsuario.TabIndex = 14
        Me.lbTipoUsuario.Text = "IdTipoUsuario"
        '
        'FrmAsignarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 357)
        Me.Controls.Add(Me.lbTipoUsuario)
        Me.Controls.Add(Me.txtCita)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbIdCita)
        Me.Controls.Add(Me.lbIdDocPaci)
        Me.Controls.Add(Me.btnNuevaCita)
        Me.Controls.Add(Me.btnAsignarCita)
        Me.Controls.Add(Me.cmbIdEmpleado)
        Me.Controls.Add(Me.cmbIdDoctor)
        Me.Controls.Add(Me.cmbPaciente)
        Me.Controls.Add(Me.cmbDoctor)
        Me.Controls.Add(Me.dtFechaCita)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAsignarCita"
        Me.Text = "Citas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtFechaCita As DateTimePicker
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents cmbPaciente As ComboBox
    Friend WithEvents cmbIdEmpleado As ComboBox
    Friend WithEvents cmbIdDoctor As ComboBox
    Friend WithEvents btnAsignarCita As Button
    Friend WithEvents btnNuevaCita As Button
    Friend WithEvents lbIdDocPaci As Label
    Friend WithEvents lbIdCita As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCita As TextBox
    Friend WithEvents lbTipoUsuario As Label
End Class
