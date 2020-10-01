<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPaciente
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
        Me.TcPacientes = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dpi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSangre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTipoSangre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtCerrarForm = New System.Windows.Forms.PictureBox()
        Me.TcPacientes.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BtCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TcPacientes
        '
        Me.TcPacientes.Controls.Add(Me.TabPage1)
        Me.TcPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcPacientes.Location = New System.Drawing.Point(0, 0)
        Me.TcPacientes.Name = "TcPacientes"
        Me.TcPacientes.SelectedIndex = 0
        Me.TcPacientes.Size = New System.Drawing.Size(1037, 600)
        Me.TcPacientes.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.btnEditar)
        Me.TabPage1.Controls.Add(Me.dgvPacientes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1029, 574)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "MIs pacientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Location = New System.Drawing.Point(916, 86)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Location = New System.Drawing.Point(916, 45)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.dpi, Me.apellido, Me.nombre, Me.direccion, Me.telefono, Me.TipoSangre, Me.estatura, Me.peso, Me.fechaNac, Me.edad, Me.idTipoSangre})
        Me.dgvPacientes.Location = New System.Drawing.Point(8, 3)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(907, 511)
        Me.dgvPacientes.TabIndex = 0
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
        'TipoSangre
        '
        Me.TipoSangre.HeaderText = "Tipo de sangre"
        Me.TipoSangre.Name = "TipoSangre"
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
        'edad
        '
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        Me.edad.Visible = False
        '
        'idTipoSangre
        '
        Me.idTipoSangre.HeaderText = "Id tipo de sangre"
        Me.idTipoSangre.Name = "idTipoSangre"
        Me.idTipoSangre.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtCerrarForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1001, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(36, 600)
        Me.Panel1.TabIndex = 9
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
        Me.BtCerrarForm.TabIndex = 6
        Me.BtCerrarForm.TabStop = False
        '
        'FrmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TcPacientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPaciente"
        Me.Opacity = 0.8R
        Me.Text = "Form1"
        Me.TcPacientes.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtCerrarForm As PictureBox
    Friend WithEvents TcPacientes As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents dpi As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents TipoSangre As DataGridViewTextBoxColumn
    Friend WithEvents estatura As DataGridViewTextBoxColumn
    Friend WithEvents peso As DataGridViewTextBoxColumn
    Friend WithEvents fechaNac As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents idTipoSangre As DataGridViewTextBoxColumn
End Class
