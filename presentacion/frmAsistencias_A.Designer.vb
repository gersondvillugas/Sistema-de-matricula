<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistencia_A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsistencia_A))
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbuscar_Aistencia = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.txtid_alumno = New System.Windows.Forms.TextBox()
        Me.txtid_asistencia = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.txtnum_asistencia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.ComboBox()
        Me.txtnombre_materia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid_materia = New System.Windows.Forms.TextBox()
        Me.txtfecha_asistencia = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscar_alumno = New System.Windows.Forms.Button()
        Me.txtnombre_alumno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnguardar.Location = New System.Drawing.Point(152, 203)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(87, 29)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.SeaGreen
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btncancelar.Location = New System.Drawing.Point(245, 203)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(87, 29)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnnuevo.Location = New System.Drawing.Point(59, 203)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(87, 29)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha de Asistencia"
        '
        'txtbuscar_Aistencia
        '
        Me.txtbuscar_Aistencia.Location = New System.Drawing.Point(154, 35)
        Me.txtbuscar_Aistencia.Name = "txtbuscar_Aistencia"
        Me.txtbuscar_Aistencia.Size = New System.Drawing.Size(332, 20)
        Me.txtbuscar_Aistencia.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombre_materia", "nombre_alumno", "numero_asistencia"})
        Me.cbocampo.Location = New System.Drawing.Point(19, 35)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(129, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "nombre_materia"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.datalistado.Location = New System.Drawing.Point(19, 87)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(545, 166)
        Me.datalistado.TabIndex = 0
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Alumno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "id_Asistencia"
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.BackColor = System.Drawing.Color.Black
        Me.inexistente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.inexistente.Location = New System.Drawing.Point(232, 165)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(112, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar_Aistencia)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(412, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 313)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTADO DE ASISTENCIA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "ELIMINAR"
        Me.Button1.UseVisualStyleBackColor = True
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
        'txtid_alumno
        '
        Me.txtid_alumno.Location = New System.Drawing.Point(177, 56)
        Me.txtid_alumno.Name = "txtid_alumno"
        Me.txtid_alumno.Size = New System.Drawing.Size(39, 22)
        Me.txtid_alumno.TabIndex = 1
        '
        'txtid_asistencia
        '
        Me.txtid_asistencia.Enabled = False
        Me.txtid_asistencia.Location = New System.Drawing.Point(177, 175)
        Me.txtid_asistencia.Multiline = True
        Me.txtid_asistencia.Name = "txtid_asistencia"
        Me.txtid_asistencia.Size = New System.Drawing.Size(168, 22)
        Me.txtid_asistencia.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(895, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 29)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.txtnum_asistencia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtestado)
        Me.GroupBox1.Controls.Add(Me.txtnombre_materia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtid_asistencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtid_materia)
        Me.GroupBox1.Controls.Add(Me.txtfecha_asistencia)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_alumno)
        Me.GroupBox1.Controls.Add(Me.txtnombre_alumno)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtid_alumno)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(19, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 268)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ASISTENCIA DE ALUMNOS"
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.DarkGreen
        Me.btneditar.ForeColor = System.Drawing.SystemColors.Control
        Me.btneditar.Location = New System.Drawing.Point(152, 239)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(87, 23)
        Me.btneditar.TabIndex = 18
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'txtnum_asistencia
        '
        Me.txtnum_asistencia.FormattingEnabled = True
        Me.txtnum_asistencia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.txtnum_asistencia.Location = New System.Drawing.Point(177, 25)
        Me.txtnum_asistencia.Name = "txtnum_asistencia"
        Me.txtnum_asistencia.Size = New System.Drawing.Size(140, 24)
        Me.txtnum_asistencia.TabIndex = 26
        Me.txtnum_asistencia.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Numero Asistencia"
        '
        'txtestado
        '
        Me.txtestado.FormattingEnabled = True
        Me.txtestado.Items.AddRange(New Object() {"Falto", "Asistio"})
        Me.txtestado.Location = New System.Drawing.Point(177, 148)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(168, 24)
        Me.txtestado.TabIndex = 24
        Me.txtestado.Text = "Falto"
        '
        'txtnombre_materia
        '
        Me.txtnombre_materia.Location = New System.Drawing.Point(222, 89)
        Me.txtnombre_materia.Name = "txtnombre_materia"
        Me.txtnombre_materia.Size = New System.Drawing.Size(95, 22)
        Me.txtnombre_materia.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Instrumento"
        '
        'txtid_materia
        '
        Me.txtid_materia.Location = New System.Drawing.Point(177, 89)
        Me.txtid_materia.Name = "txtid_materia"
        Me.txtid_materia.Size = New System.Drawing.Size(39, 22)
        Me.txtid_materia.TabIndex = 20
        '
        'txtfecha_asistencia
        '
        Me.txtfecha_asistencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_asistencia.Location = New System.Drawing.Point(177, 120)
        Me.txtfecha_asistencia.Name = "txtfecha_asistencia"
        Me.txtfecha_asistencia.Size = New System.Drawing.Size(168, 22)
        Me.txtfecha_asistencia.TabIndex = 18
        '
        'btnbuscar_alumno
        '
        Me.btnbuscar_alumno.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbuscar_alumno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnbuscar_alumno.Location = New System.Drawing.Point(319, 54)
        Me.btnbuscar_alumno.Name = "btnbuscar_alumno"
        Me.btnbuscar_alumno.Size = New System.Drawing.Size(33, 27)
        Me.btnbuscar_alumno.TabIndex = 17
        Me.btnbuscar_alumno.Text = "..."
        Me.btnbuscar_alumno.UseVisualStyleBackColor = False
        '
        'txtnombre_alumno
        '
        Me.txtnombre_alumno.Location = New System.Drawing.Point(222, 56)
        Me.txtnombre_alumno.Name = "txtnombre_alumno"
        Me.txtnombre_alumno.Size = New System.Drawing.Size(95, 22)
        Me.txtnombre_alumno.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(224, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 57)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Alumnos"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 68)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(102, -5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(227, 57)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Asistencia de"
        '
        'frmAsistencia_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 418)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAsistencia_A"
        Me.Text = ".:.LISTADO DE VENTAS .:."
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbuscar_Aistencia As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtid_alumno As TextBox
    Friend WithEvents txtid_asistencia As TextBox
    Friend WithEvents txtnombre_alumno As TextBox
    Friend WithEvents txtfecha_asistencia As DateTimePicker
    Friend WithEvents btnbuscar_alumno As Button
    Friend WithEvents txtnombre_materia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtid_materia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtestado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnum_asistencia As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
End Class
