<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatricula
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
        Me.btnbuscar_materia = New System.Windows.Forms.Button()
        Me.txtnombre_alumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidmatricula = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbtipo_documento = New System.Windows.Forms.TextBox()
        Me.txtpago_matricula = New System.Windows.Forms.TextBox()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnalumno = New System.Windows.Forms.Button()
        Me.txtnombre_instrumento = New System.Windows.Forms.TextBox()
        Me.txtidinstrumento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dlg = New System.Windows.Forms.GroupBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlg.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbuscar_materia
        '
        Me.btnbuscar_materia.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbuscar_materia.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnbuscar_materia.Location = New System.Drawing.Point(318, 191)
        Me.btnbuscar_materia.Name = "btnbuscar_materia"
        Me.btnbuscar_materia.Size = New System.Drawing.Size(33, 27)
        Me.btnbuscar_materia.TabIndex = 34
        Me.btnbuscar_materia.Text = "..."
        Me.btnbuscar_materia.UseVisualStyleBackColor = False
        '
        'txtnombre_alumno
        '
        Me.txtnombre_alumno.Location = New System.Drawing.Point(217, 60)
        Me.txtnombre_alumno.Name = "txtnombre_alumno"
        Me.txtnombre_alumno.Size = New System.Drawing.Size(95, 22)
        Me.txtnombre_alumno.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Alumno"
        '
        'txtidalumno
        '
        Me.txtidalumno.Location = New System.Drawing.Point(172, 60)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.Size = New System.Drawing.Size(39, 22)
        Me.txtidalumno.TabIndex = 31
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(3, 18)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 294)
        Me.Splitter1.TabIndex = 28
        Me.Splitter1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Pago de Matricula"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(99, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(191, 57)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Registro de"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha de Matricula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IdMatricula"
        '
        'txtidmatricula
        '
        Me.txtidmatricula.Enabled = False
        Me.txtidmatricula.Location = New System.Drawing.Point(172, 29)
        Me.txtidmatricula.Name = "txtidmatricula"
        Me.txtidmatricula.Size = New System.Drawing.Size(168, 22)
        Me.txtidmatricula.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(191, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 57)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Matriculas"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnguardar.Location = New System.Drawing.Point(201, 265)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(145, 29)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Agregar Matricula"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Numero Documento"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbtipo_documento)
        Me.GroupBox1.Controls.Add(Me.txtpago_matricula)
        Me.GroupBox1.Controls.Add(Me.txtnum_documento)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.btnalumno)
        Me.GroupBox1.Controls.Add(Me.txtnombre_instrumento)
        Me.GroupBox1.Controls.Add(Me.txtidinstrumento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_materia)
        Me.GroupBox1.Controls.Add(Me.txtnombre_alumno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Controls.Add(Me.Splitter1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidmatricula)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(7, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 315)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.Location = New System.Drawing.Point(172, 129)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(168, 22)
        Me.cbtipo_documento.TabIndex = 43
        Me.cbtipo_documento.Text = "DNI"
        '
        'txtpago_matricula
        '
        Me.txtpago_matricula.Location = New System.Drawing.Point(174, 230)
        Me.txtpago_matricula.Name = "txtpago_matricula"
        Me.txtpago_matricula.Size = New System.Drawing.Size(172, 22)
        Me.txtpago_matricula.TabIndex = 42
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(172, 160)
        Me.txtnum_documento.MaxLength = 8
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(168, 22)
        Me.txtnum_documento.TabIndex = 41
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(172, 96)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(168, 22)
        Me.txtfecha.TabIndex = 40
        '
        'btnalumno
        '
        Me.btnalumno.BackColor = System.Drawing.Color.SeaGreen
        Me.btnalumno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnalumno.Location = New System.Drawing.Point(318, 58)
        Me.btnalumno.Name = "btnalumno"
        Me.btnalumno.Size = New System.Drawing.Size(33, 27)
        Me.btnalumno.TabIndex = 38
        Me.btnalumno.Text = "..."
        Me.btnalumno.UseVisualStyleBackColor = False
        '
        'txtnombre_instrumento
        '
        Me.txtnombre_instrumento.Location = New System.Drawing.Point(217, 193)
        Me.txtnombre_instrumento.Name = "txtnombre_instrumento"
        Me.txtnombre_instrumento.Size = New System.Drawing.Size(95, 22)
        Me.txtnombre_instrumento.TabIndex = 37
        '
        'txtidinstrumento
        '
        Me.txtidinstrumento.Location = New System.Drawing.Point(172, 193)
        Me.txtidinstrumento.Name = "txtidinstrumento"
        Me.txtidinstrumento.Size = New System.Drawing.Size(39, 22)
        Me.txtidinstrumento.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Instrumento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo Documento"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Location = New System.Drawing.Point(236, 434)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(578, 50)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "*****Detalle de Clase*****"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Castellar", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(169, -5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(410, 58)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "BIENVENIDOS "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.sisventas.My.Resources.Resources.images
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 97)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'dlg
        '
        Me.dlg.BackColor = System.Drawing.Color.Transparent
        Me.dlg.Controls.Add(Me.cbeliminar)
        Me.dlg.Controls.Add(Me.Button1)
        Me.dlg.Controls.Add(Me.inexistente)
        Me.dlg.Controls.Add(Me.txtbuscar)
        Me.dlg.Controls.Add(Me.cbocampo)
        Me.dlg.Controls.Add(Me.datalistado)
        Me.dlg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlg.ForeColor = System.Drawing.SystemColors.Highlight
        Me.dlg.Location = New System.Drawing.Point(393, 20)
        Me.dlg.Name = "dlg"
        Me.dlg.Size = New System.Drawing.Size(690, 408)
        Me.dlg.TabIndex = 32
        Me.dlg.TabStop = False
        Me.dlg.Text = "LISTADO DE PRODUCTOS"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(27, 63)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(69, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(486, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.Color.Black
        Me.inexistente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.inexistente.Location = New System.Drawing.Point(245, 239)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(112, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(182, 36)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(142, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"numero_documento"})
        Me.cbocampo.Location = New System.Drawing.Point(19, 35)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(146, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "numero_documento"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.datalistado.Location = New System.Drawing.Point(19, 85)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(650, 302)
        Me.datalistado.TabIndex = 0
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'frmMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 496)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dlg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMatricula"
        Me.Text = "frmMatricula"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlg.ResumeLayout(False)
        Me.dlg.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbuscar_materia As Button
    Friend WithEvents txtnombre_alumno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidalumno As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label9 As Label
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidmatricula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnombre_instrumento As TextBox
    Friend WithEvents txtidinstrumento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpago_matricula As TextBox
    Friend WithEvents txtnum_documento As TextBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents cbtipo_documento As TextBox
    Friend WithEvents dlg As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents btnalumno As Button
End Class
