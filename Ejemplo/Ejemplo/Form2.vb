Public Class Form2

    Private Sub EscuelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EscuelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatosDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.Escuela' Puede moverla o quitarla según sea necesario.
        Me.EscuelaTableAdapter.Fill(Me.DatosDataSet.Escuela)
        Id_del_alumnoTextBox.Enabled = False
        NombreTextBox.Enabled = False
        ApellidosTextBox.Enabled = False
        Fecha_de_NacimientoTextBox.Enabled = False
        GradoTextBox.Enabled = False
        MaestroTextBox.Enabled = False

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        EscuelaBindingSource.AddNew()
        Id_del_alumnoTextBox.Enabled = False
        NombreTextBox.Enabled = True
        ApellidosTextBox.Enabled = True
        Fecha_de_NacimientoTextBox.Enabled = True
        GradoTextBox.Enabled = True
        MaestroTextBox.Enabled = True
        ImprimirToolStripMenuItem.Enabled = False
        BuscarToolStripMenuItem.Enabled = False
        NuevoToolStripMenuItem.Enabled = False
        GuardarToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        MenuStrip1.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        MenuStrip1.Visible = True
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        On Error GoTo saveErr
        EscuelaBindingSource.EndEdit()
        EscuelaTableAdapter.Update(DatosDataSet.Escuela)
        MsgBox("Registro guardado correctamente", vbInformation, "Guardar")
saveErr:
        Id_del_alumnoTextBox.Enabled = False
        NombreTextBox.Enabled = False
        ApellidosTextBox.Enabled = False
        Fecha_de_NacimientoTextBox.Enabled = False
        GradoTextBox.Enabled = False
        MaestroTextBox.Enabled = False
        ImprimirToolStripMenuItem.Enabled = True
        BuscarToolStripMenuItem.Enabled = True
        NuevoToolStripMenuItem.Enabled = True
        GuardarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        form3.show()
    End Sub

    Private Sub AyudaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem1.Click
        MsgBox("Para Actualisacione o Soporte tecnico Debe Constatar a Ing Ricardo David")
    End Sub

End Class