Imports System.Data.OleDb
Public Class Form3

    Private Property Panel As Integer

    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo 
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)

        'exportamos los caracteres de las columnas
        For c As Integer = 0 To EscuelaDataGridView.Columns.Count - 1
            xlWS.cells(1, c + 1).value = EscuelaDataGridView.Columns(c).HeaderText
        Next

        'exportamos las cabeceras de columnas
        For r As Integer = 0 To EscuelaDataGridView.RowCount - 1
            For c As Integer = 0 To EscuelaDataGridView.Columns.Count - 1
                xlWS.cells(r + 2, c + 1).value = EscuelaDataGridView.Item(c, r).Value
            Next
        Next

        'guardamos la hoja de calculo en la ruta especificada 
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing

    End Sub
    Private Sub EscuelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EscuelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatosDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.Escuela' Puede moverla o quitarla según sea necesario.
        Me.EscuelaTableAdapter.Fill(Me.DatosDataSet.Escuela)
        Id_del_alumnoTextBox.Enabled = False
        NombreTextBox.Enabled = False
        ApellidosTextBox.Enabled = False
        Fecha_de_NacimientoTextBox.Enabled = False
        GradoTextBox.Enabled = False
        MaestroTextBox.Enabled = False
        EscuelaDataGridView.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
        GuardarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        Dim a As String
        a = MsgBox("Esta seguro que desea modificar", vbQuestion + vbYesNo, "Actualizar")
        If a = vbYes Then
            EscuelaBindingSource.EndEdit()
            EscuelaTableAdapter.Update(DatosDataSet.Escuela)
            MsgBox("Registro actualizado", vbInformation, "actualizar")
        Else
            MsgBox("Cancelado", vbInformation, "actualizar")
            Me.EscuelaTableAdapter.Fill(Me.DatosDataSet.Escuela)
        End If
        Id_del_alumnoTextBox.Enabled = False
        NombreTextBox.Enabled = True
        ApellidosTextBox.Enabled = True
        Fecha_de_NacimientoTextBox.Enabled = True
        GradoTextBox.Enabled = True
        MaestroTextBox.Enabled = True
        EscuelaDataGridView.Enabled = True
        EliminarToolStripMenuItem.Enabled = True
        GuardarToolStripMenuItem.Enabled = True

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim a As String
        a = MsgBox("¿desea eliminar el registro?", vbQuestion + vbYesNo, "eliminar")
        If a = vbYes Then
            EscuelaBindingSource.RemoveCurrent()
            EscuelaTableAdapter.Update(DatosDataSet.Escuela)
            Id_del_alumnoTextBox.Enabled = False
            NombreTextBox.Enabled = False
            ApellidosTextBox.Enabled = False
            Fecha_de_NacimientoTextBox.Enabled = False
            GradoTextBox.Enabled = False
            MaestroTextBox.Enabled = False
            EscuelaDataGridView.Enabled = False
            EliminarToolStripMenuItem.Enabled = False
        End If
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
        EscuelaDataGridView.Enabled = False
        EliminarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AyudaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem1.Click
        Dim a As String
        a = InputBox("Ingrese ID", "Buscar")
        Me.EscuelaTableAdapter.idbuscar(Me.DatosDataSet.Escuela, a)
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

    End Sub

    Private Sub AyudaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem3.Click
        MsgBox("Para Actualisacione o Soporte tecnico Debe Constatar a Ing Ricardo David")
    End Sub

    Private Sub BuscarPorNombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorNombreToolStripMenuItem.Click
        Dim a As String
        a = InputBox("Ingrese Nombre", "Buscar")
        Me.EscuelaTableAdapter.nombrebuscar(Me.DatosDataSet.Escuela, a)
    End Sub

    Private Sub BuscarPorApellidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorApellidoToolStripMenuItem.Click
        Dim a As String
        a = InputBox("Ingrese apellido", "Buscar")
        Me.EscuelaTableAdapter.apellidobuscar(Me.DatosDataSet.Escuela, a)
    End Sub

    Private Sub BuscarPorMaestroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorMaestroToolStripMenuItem.Click
        Dim a As String
        a = InputBox("Ingrese maestro", "Buscar")
        Me.EscuelaTableAdapter.maestrobuscar(Me.DatosDataSet.Escuela, a)
    End Sub

    Private Sub BuscarPorGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPorGradoToolStripMenuItem.Click
        Dim a As String
        a = InputBox("Ingrese ID", "Buscar")
        Me.EscuelaTableAdapter.gradobuscarr(Me.DatosDataSet.Escuela, a)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exportar_Excel(EscuelaDataGridView, save.FileName)
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Deseas salir?", vbQuestion + vbYesNo, "Registro De Educacion") = vbNo Then
            Panel = 1
        Else
            End
        End If
    End Sub
End Class