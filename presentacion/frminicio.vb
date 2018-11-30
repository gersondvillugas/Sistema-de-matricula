﻿Imports System.Windows.Forms

Public Class frminicio

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smdiregistromatriculas.Click
        frmMatricula.MdiParent = Me
        frmMatricula.Show()



    End Sub



    Private Sub RegistrosDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smdiregistroalumno.Click
        frmAlumnos.MdiParent = Me
        frmAlumnos.Show()




    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smdimaterias.Click
        frmmateriass.MdiParent = Me
        frmmateriass.Show()



    End Sub


    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        End

    End Sub



    Private Sub RegistroDeDocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeDocenteToolStripMenuItem.Click
        frmAsistencia_A.MdiParent = Me
        frmAsistencia_A.Show()
    End Sub

    Private Sub RegistroDeAsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles smdiregistrodocentes.Click
        frmDocentes.MdiParent = Me
        frmDocentes.Show()
    End Sub

    Private Sub AsistenciaDeDocenteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MatriculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriculasToolStripMenuItem.Click
        login.Show()
        Hide()
        login.txtusuario.Clear()

        login.txtp.Clear()
    End Sub

    Private Sub DetalleDeClasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDeClasesToolStripMenuItem.Click
        frmclases.MdiParent = Me
        frmclases.Show()




    End Sub

    Private Sub frminicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdiasistencias.Enabled = True
        mdiclases.Enabled = True
        mdimatriculas.Enabled = True
        mdiusuarios.Enabled = False

        smdimaterias.Enabled = True
        smdiregistrodocentes.Enabled = True






    End Sub
End Class
