<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim GradoLabel As System.Windows.Forms.Label
        Dim MaestroLabel As System.Windows.Forms.Label
        Dim Fecha_de_NacimientoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Id_del_alumnoTextBox = New System.Windows.Forms.TextBox()
        Me.EscuelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSet = New Ejemplo.datosDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.GradoTextBox = New System.Windows.Forms.TextBox()
        Me.MaestroTextBox = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EscuelaTableAdapter = New Ejemplo.datosDataSetTableAdapters.EscuelaTableAdapter()
        Me.TableAdapterManager = New Ejemplo.datosDataSetTableAdapters.TableAdapterManager()
        Me.Fecha_de_NacimientoTextBox = New System.Windows.Forms.TextBox()
        Id_del_alumnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        GradoLabel = New System.Windows.Forms.Label()
        MaestroLabel = New System.Windows.Forms.Label()
        Fecha_de_NacimientoLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EscuelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_del_alumnoLabel
        '
        Id_del_alumnoLabel.AutoSize = True
        Id_del_alumnoLabel.Location = New System.Drawing.Point(16, 80)
        Id_del_alumnoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_del_alumnoLabel.Name = "Id_del_alumnoLabel"
        Id_del_alumnoLabel.Size = New System.Drawing.Size(96, 17)
        Id_del_alumnoLabel.TabIndex = 4
        Id_del_alumnoLabel.Text = "Id del alumno:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(51, 110)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(44, 140)
        ApellidosLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 8
        ApellidosLabel.Text = "Apellidos:"
        '
        'GradoLabel
        '
        GradoLabel.AutoSize = True
        GradoLabel.Location = New System.Drawing.Point(61, 201)
        GradoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GradoLabel.Name = "GradoLabel"
        GradoLabel.Size = New System.Drawing.Size(52, 17)
        GradoLabel.TabIndex = 12
        GradoLabel.Text = "Grado:"
        '
        'MaestroLabel
        '
        MaestroLabel.AutoSize = True
        MaestroLabel.Location = New System.Drawing.Point(49, 234)
        MaestroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MaestroLabel.Name = "MaestroLabel"
        MaestroLabel.Size = New System.Drawing.Size(63, 17)
        MaestroLabel.TabIndex = 14
        MaestroLabel.Text = "Maestro:"
        '
        'Fecha_de_NacimientoLabel
        '
        Fecha_de_NacimientoLabel.AutoSize = True
        Fecha_de_NacimientoLabel.Location = New System.Drawing.Point(13, 172)
        Fecha_de_NacimientoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_de_NacimientoLabel.Name = "Fecha_de_NacimientoLabel"
        Fecha_de_NacimientoLabel.Size = New System.Drawing.Size(98, 17)
        Fecha_de_NacimientoLabel.TabIndex = 15
        Fecha_de_NacimientoLabel.Text = "F. Nacimiento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro De Educacion"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(120, 24)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'Id_del_alumnoTextBox
        '
        Me.Id_del_alumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Id del alumno", True))
        Me.Id_del_alumnoTextBox.Location = New System.Drawing.Point(121, 76)
        Me.Id_del_alumnoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_del_alumnoTextBox.Name = "Id_del_alumnoTextBox"
        Me.Id_del_alumnoTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Id_del_alumnoTextBox.TabIndex = 5
        '
        'EscuelaBindingSource
        '
        Me.EscuelaBindingSource.DataMember = "Escuela"
        Me.EscuelaBindingSource.DataSource = Me.DatosDataSet
        '
        'DatosDataSet
        '
        Me.DatosDataSet.DataSetName = "datosDataSet"
        Me.DatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(121, 106)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(261, 22)
        Me.NombreTextBox.TabIndex = 7
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(121, 137)
        Me.ApellidosTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(261, 22)
        Me.ApellidosTextBox.TabIndex = 9
        '
        'GradoTextBox
        '
        Me.GradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Grado", True))
        Me.GradoTextBox.Location = New System.Drawing.Point(121, 201)
        Me.GradoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GradoTextBox.Name = "GradoTextBox"
        Me.GradoTextBox.Size = New System.Drawing.Size(261, 22)
        Me.GradoTextBox.TabIndex = 13
        '
        'MaestroTextBox
        '
        Me.MaestroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Maestro", True))
        Me.MaestroTextBox.Location = New System.Drawing.Point(121, 230)
        Me.MaestroTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MaestroTextBox.Name = "MaestroTextBox"
        Me.MaestroTextBox.Size = New System.Drawing.Size(261, 22)
        Me.MaestroTextBox.TabIndex = 15
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ejemplo.My.Resources.Resources.nino
        Me.PictureBox1.Location = New System.Drawing.Point(392, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'Fecha_de_NacimientoTextBox
        '
        Me.Fecha_de_NacimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EscuelaBindingSource, "Fecha de Nacimiento", True))
        Me.Fecha_de_NacimientoTextBox.Location = New System.Drawing.Point(121, 169)
        Me.Fecha_de_NacimientoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Fecha_de_NacimientoTextBox.Name = "Fecha_de_NacimientoTextBox"
        Me.Fecha_de_NacimientoTextBox.Size = New System.Drawing.Size(261, 22)
        Me.Fecha_de_NacimientoTextBox.TabIndex = 16
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 279)
        Me.Controls.Add(Fecha_de_NacimientoLabel)
        Me.Controls.Add(Me.Fecha_de_NacimientoTextBox)
        Me.Controls.Add(MaestroLabel)
        Me.Controls.Add(Me.MaestroTextBox)
        Me.Controls.Add(GradoLabel)
        Me.Controls.Add(Me.GradoTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_del_alumnoLabel)
        Me.Controls.Add(Me.Id_del_alumnoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Escuela"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EscuelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosDataSet As Ejemplo.datosDataSet
    Friend WithEvents EscuelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EscuelaTableAdapter As Ejemplo.datosDataSetTableAdapters.EscuelaTableAdapter
    Friend WithEvents TableAdapterManager As Ejemplo.datosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_del_alumnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaestroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Fecha_de_NacimientoTextBox As System.Windows.Forms.TextBox
End Class
