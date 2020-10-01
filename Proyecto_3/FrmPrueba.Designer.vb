<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrueba
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTipoSangre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrueba = New System.Windows.Forms.TextBox()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Location = New System.Drawing.Point(875, 57)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(125, 23)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.dpi, Me.apellido, Me.nombre, Me.direccion, Me.telefono, Me.idTipoSangre, Me.estatura, Me.peso, Me.fechaNac})
        Me.dgvPacientes.Location = New System.Drawing.Point(12, 15)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(836, 511)
        Me.dgvPacientes.TabIndex = 2
        '
        'IdPaciente
        '
        Me.IdPaciente.HeaderText = "ID Paciente"
        Me.IdPaciente.Name = "IdPaciente"
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
        'direccion
        '
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        '
        'idTipoSangre
        '
        Me.idTipoSangre.HeaderText = "Tipo de sangre"
        Me.idTipoSangre.Name = "idTipoSangre"
        '
        'estatura
        '
        Me.estatura.HeaderText = "Estatura"
        Me.estatura.Name = "estatura"
        '
        'peso
        '
        Me.peso.HeaderText = "Peso"
        Me.peso.Name = "peso"
        '
        'fechaNac
        '
        Me.fechaNac.HeaderText = "Fecha de nacimiento"
        Me.fechaNac.Name = "fechaNac"
        '
        'txtPrueba
        '
        Me.txtPrueba.Location = New System.Drawing.Point(895, 221)
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.Size = New System.Drawing.Size(100, 20)
        Me.txtPrueba.TabIndex = 4
        '
        'FrmPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 541)
        Me.Controls.Add(Me.txtPrueba)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Name = "FrmPrueba"
        Me.Text = "FrmPrueba"
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents dpi As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents idTipoSangre As DataGridViewTextBoxColumn
    Friend WithEvents estatura As DataGridViewTextBoxColumn
    Friend WithEvents peso As DataGridViewTextBoxColumn
    Friend WithEvents fechaNac As DataGridViewTextBoxColumn
    Public WithEvents txtPrueba As TextBox
End Class
