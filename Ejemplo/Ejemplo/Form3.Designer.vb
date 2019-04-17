<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_del_alumnoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Fecha_de_NacimientoLabel As System.Windows.Forms.Label
        Dim GradoLabel As System.Windows.Forms.Label
        Dim MaestroLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorNombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorApellidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorMaestroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPorGradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDataSet = New Ejemplo.datosDataSet()
        Me.EscuelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EscuelaTableAdapter = New Ejemplo.datosDataSetTableAdapters.EscuelaTableAdapter()
        Me.TableAdapterManager = New Ejemplo.datosDataSetTableAdapters.TableAdapterManager()
        Me.EscuelaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_del_alumnoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_NacimientoTextBox = New System.Windows.Forms.TextBox()
        Me.GradoTextBox = New System.Windows.Forms.TextBox()
        Me.MaestroTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Id_del_alumnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Fecha_de_NacimientoLabel = New System.Windows.Forms.Label()
        GradoLabel = New System.Windows.Forms.Label()
        MaestroLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscuelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscuelaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_del_alumnoLabel
        '
        Id_del_alumnoLabel.AutoSize = True
        Id_del_alumnoLabel.Location = New System.Drawing.Point(51, 47)
        Id_del_alumnoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_del_alumnoLabel.Name = "Id_del_alumnoLabel"
        Id_del_alumnoLabel.Size = New System.Drawing.Size(96, 17)
        Id_del_alumnoLabel.TabIndex = 2
        Id_del_alumnoLabel.Text = "Id del alumno:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(85, 78)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(79, 111)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "Apellidos:"
        '
        'Fecha_de_NacimientoLabel
        '
        Fecha_de_NacimientoLabel.AutoSize = True
        Fecha_de_NacimientoLabel.Location = New System.Drawing.Point(7, 138)
        Fecha_de_NacimientoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_de_NacimientoLabel.Name = "Fecha_de_NacimientoLabel"
        Fecha_de_NacimientoLabel.Size = New System.Drawing.Size(145, 17)
        Fecha_de_NacimientoLabel.TabIndex = 8
        Fecha_de_NacimientoLabel.Text = "Fecha de Nacimiento:"
        '
        'GradoLabel
        '
        GradoLabel.AutoSize = True
        GradoLabel.Location = New System.Drawing.Point(96, 167)
        GradoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GradoLabel.Name = "GradoLabel"
        GradoLabel.Size = New System.Drawing.Size(52, 17)
        GradoLabel.TabIndex = 10
        GradoLabel.Text = "Grado:"
        '
        'MaestroLabel
        '
        MaestroLabel.AutoSize = True
        MaestroLabel.Location = New System.Drawing.Point(91, 202)
        MaestroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MaestroLabel.Name = "MaestroLabel"
        MaestroLabel.Size = New System.Drawing.Size(63, 17)
        MaestroLabel.TabIndex = 12
        MaestroLabel.Text = "Maestro:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.AyudaToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(905, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ModificarToolStripMenuItem.Text = "Archivo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(142, 24)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1, Me.BuscarPorNombreToolStripMenuItem, Me.BuscarPorApellidoToolStripMenuItem, Me.BuscarPorMaestroToolStripMenuItem, Me.BuscarPorGradoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AyudaToolStripMenuItem.Text = "Buscar"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(207, 24)
        Me.AyudaToolStripMenuItem1.Text = "Buscar por ID"
        '
        'BuscarPorNombreToolStripMenuItem
        '
        Me.BuscarPorNombreToolStripMenuItem.Name = "BuscarPorNombreToolStripMenuItem"
        Me.BuscarPorNombreToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.BuscarPorNombreToolStripMenuItem.Text = "Buscar por nombre"
        '
        'BuscarPorApellidoToolStripMenuItem
        '
        Me.BuscarPorApellidoToolStripMenuItem.Name = "BuscarPorApellidoToolStripMenuItem"
        Me.BuscarPorApellidoToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.BuscarPorApellidoToolStripMenuItem.Text = "Buscar por apellido"
        '
        'BuscarPorMaestroToolStripMenuItem
        '
        Me.BuscarPorMaestroToolStripMenuItem.Name = "BuscarPorMaestroToolStripMenuItem"
        Me.BuscarPorMaestroToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.BuscarPorMaestroToolStripMenuItem.Text = "Buscar por maestro"
        '
        'BuscarPorGradoToolStripMenuItem
        '
        Me.BuscarPorGradoToolStripMenuItem.Name = "BuscarPorGradoToolStripMenuItem"
        Me.BuscarPorGradoToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.BuscarPorGradoToolStripMenuItem.Text = "Buscar por grado"
        '
        'AyudaToolStripMenuItem2
        '
        Me.AyudaToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem3})
        Me.AyudaToolStripMenuItem2.Name = "AyudaToolStripMenuItem2"
        Me.AyudaToolStripMenuItem2.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem2.Text = "Ayuda"
        '
        'AyudaToolStripMenuItem3
        '
        Me.AyudaToolStripMenuItem3.Name = "AyudaToolStripMenuItem3"
        Me.AyudaToolStripMenuItem3.Size = New System.Drawing.Size(120, 24)
        Me.AyudaToolStripMenuItem3.Text = "Ayuda"
        '
        'DatosDataSet
        '
        Me.DatosDataSet.DataSetName = "datosDataSet"
        Me.DatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EscuelaBindingSource
        '
        Me.EscuelaBindingSource.DataMember = "Escuela"
        Me.EscuelaBindingSource.DataSource = Me.DatosDataSet
        '
        'EscuelaTableAdapter
        '
        Me.EscuelaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EscuelaTableAdapter = Me.EscuelaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Ejemplo.datosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EscuelaDataGridView
        '
        Me.EscuelaDataGridView.AutoGenerateColumns = False
        Me.EscuelaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EscuelaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.EscuelaDataGridView.DataSource = Me.EscuelaBindingSource
        Me.EscuelaDataGridView.Location = New System.Drawing.Point(13, 266)
        Me.EscuelaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.EscuelaDataGridView.Name = "EscuelaDataGridView"
        Me.EscuelaDataGridView.Size = New System.Drawing.Size(856, 271)
        Me.EscuelaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id del alumno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id del alumno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha de Nacimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha de Nacimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Grado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Grado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Maestro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Maestro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Id_del_alumnoTextBox
        '
        Me.Id_del_alumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Id del alumno", True))
        Me.Id_del_alumnoTextBox.Location = New System.Drawing.Point(156, 38)
        Me.Id_del_alumnoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_del_alumnoTextBox.Name = "Id_del_alumnoTextBox"
        Me.Id_del_alumnoTextBox.Size = New System.Drawing.Size(445, 22)
        Me.Id_del_alumnoTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(156, 70)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(445, 22)
        Me.NombreTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(156, 102)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(445, 22)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'Fecha_de_NacimientoTextBox
        '
        Me.Fecha_de_NacimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Fecha de Nacimiento", True))
        Me.Fecha_de_NacimientoTextBox.Location = New System.Drawing.Point(156, 134)
        Me.Fecha_de_NacimientoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Fecha_de_NacimientoTextBox.Name = "Fecha_de_NacimientoTextBox"
        Me.Fecha_de_NacimientoTextBox.Size = New System.Drawing.Size(445, 22)
        Me.Fecha_de_NacimientoTextBox.TabIndex = 9
        '
        'GradoTextBox
        '
        Me.GradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Grado", True))
        Me.GradoTextBox.Location = New System.Drawing.Point(156, 166)
        Me.GradoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GradoTextBox.Name = "GradoTextBox"
        Me.GradoTextBox.Size = New System.Drawing.Size(445, 22)
        Me.GradoTextBox.TabIndex = 11
        '
        'MaestroTextBox
        '
        Me.MaestroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Maestro", True))
        Me.MaestroTextBox.Location = New System.Drawing.Point(157, 198)
        Me.MaestroTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MaestroTextBox.Name = "MaestroTextBox"
        Me.MaestroTextBox.Size = New System.Drawing.Size(445, 22)
        Me.MaestroTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(354, 545)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Exportar a excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(19, 232)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(135, 17)
        Label1.TabIndex = 15
        Label1.Text = "Ciudad De Registro:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Maestro", True))
        Me.TextBox1.Location = New System.Drawing.Point(156, 232)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(445, 22)
        Me.TextBox1.TabIndex = 16
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 586)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MaestroLabel)
        Me.Controls.Add(Me.MaestroTextBox)
        Me.Controls.Add(GradoLabel)
        Me.Controls.Add(Me.GradoTextBox)
        Me.Controls.Add(Fecha_de_NacimientoLabel)
        Me.Controls.Add(Me.Fecha_de_NacimientoTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_del_alumnoLabel)
        Me.Controls.Add(Me.Id_del_alumnoTextBox)
        Me.Controls.Add(Me.EscuelaDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Buscar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscuelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscuelaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosDataSet As Ejemplo.datosDataSet
    Friend WithEvents EscuelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EscuelaTableAdapter As Ejemplo.datosDataSetTableAdapters.EscuelaTableAdapter
    Friend WithEvents TableAdapterManager As Ejemplo.datosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EscuelaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_del_alumnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_de_NacimientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaestroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorNombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorApellidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorMaestroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPorGradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
