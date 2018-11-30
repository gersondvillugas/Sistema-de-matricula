<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnos))
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.listado = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.fecha_vencimiento1 = New System.Windows.Forms.DateTimePicker()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnbuscar_categoria = New System.Windows.Forms.Button()
        Me.txtnombre_docente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtiddocente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtidalumno = New System.Windows.Forms.TextBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dlg = New System.Windows.Forms.GroupBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dlgs = New System.Windows.Forms.OpenFileDialog()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.txtfecha_vencimiento = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dlg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnguardar.Location = New System.Drawing.Point(155, 418)
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
        Me.btncancelar.Location = New System.Drawing.Point(248, 418)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(87, 29)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.SeaGreen
        Me.btneditar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btneditar.Location = New System.Drawing.Point(155, 418)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(87, 29)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnnuevo.Location = New System.Drawing.Point(62, 418)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(87, 29)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nivel"
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombres", "apellidos", "dni"})
        Me.cbocampo.Location = New System.Drawing.Point(19, 35)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(129, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "nombres"
        '
        'listado
        '
        Me.listado.AllowUserToAddRows = False
        Me.listado.AllowUserToDeleteRows = False
        Me.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar})
        Me.listado.Location = New System.Drawing.Point(19, 85)
        Me.listado.Name = "listado"
        Me.listado.ReadOnly = True
        Me.listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listado.Size = New System.Drawing.Size(682, 302)
        Me.listado.TabIndex = 0
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(1013, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 29)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.fecha_vencimiento1)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_categoria)
        Me.GroupBox1.Controls.Add(Me.txtnombre_docente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtiddocente)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnivel)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtidalumno)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.erroricono.SetIconAlignment(Me.GroupBox1, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 453)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Dni"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txttelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txttelefono.Location = New System.Drawing.Point(174, 146)
        Me.txttelefono.MaxLength = 9
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(158, 22)
        Me.txttelefono.TabIndex = 32
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(174, 115)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(158, 22)
        Me.txtdni.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Apellido"
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(174, 87)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(158, 22)
        Me.txtapellido.TabIndex = 29
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImage = Global.sisventas.My.Resources.Resources.descarga1
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(78, 356)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(56, 43)
        Me.btnlimpiar.TabIndex = 26
        Me.btnlimpiar.TabStop = False
        '
        'fecha_vencimiento1
        '
        Me.fecha_vencimiento1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_vencimiento1.Location = New System.Drawing.Point(202, 241)
        Me.fecha_vencimiento1.Name = "fecha_vencimiento1"
        Me.fecha_vencimiento1.Size = New System.Drawing.Size(130, 22)
        Me.fecha_vencimiento1.TabIndex = 28
        '
        'btncargar
        '
        Me.btncargar.BackColor = System.Drawing.Color.Transparent
        Me.btncargar.BackgroundImage = Global.sisventas.My.Resources.Resources._8460418_Upload_folder_icon_Stock_Photo_file
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Location = New System.Drawing.Point(77, 286)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(57, 44)
        Me.btncargar.TabIndex = 25
        Me.btncargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImage = Global.sisventas.My.Resources.Resources.descarga2
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Location = New System.Drawing.Point(174, 267)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(161, 145)
        Me.imagen.TabIndex = 24
        Me.imagen.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Imagen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fecha de Matricula"
        '
        'btnbuscar_categoria
        '
        Me.btnbuscar_categoria.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbuscar_categoria.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnbuscar_categoria.Location = New System.Drawing.Point(339, 172)
        Me.btnbuscar_categoria.Name = "btnbuscar_categoria"
        Me.btnbuscar_categoria.Size = New System.Drawing.Size(36, 29)
        Me.btnbuscar_categoria.TabIndex = 19
        Me.btnbuscar_categoria.Text = "..."
        Me.btnbuscar_categoria.UseVisualStyleBackColor = False
        '
        'txtnombre_docente
        '
        Me.txtnombre_docente.Location = New System.Drawing.Point(229, 175)
        Me.txtnombre_docente.Name = "txtnombre_docente"
        Me.txtnombre_docente.Size = New System.Drawing.Size(103, 22)
        Me.txtnombre_docente.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Docente"
        '
        'txtiddocente
        '
        Me.txtiddocente.Location = New System.Drawing.Point(174, 175)
        Me.txtiddocente.Name = "txtiddocente"
        Me.txtiddocente.Size = New System.Drawing.Size(49, 22)
        Me.txtiddocente.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "IdAlumno"
        '
        'txtnivel
        '
        Me.txtnivel.Location = New System.Drawing.Point(174, 203)
        Me.txtnivel.Multiline = True
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtnivel.Size = New System.Drawing.Size(158, 32)
        Me.txtnivel.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(174, 57)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(158, 22)
        Me.txtnombre.TabIndex = 1
        '
        'txtidalumno
        '
        Me.txtidalumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidalumno.Enabled = False
        Me.txtidalumno.Location = New System.Drawing.Point(174, 29)
        Me.txtidalumno.Name = "txtidalumno"
        Me.txtidalumno.Size = New System.Drawing.Size(158, 22)
        Me.txtidalumno.TabIndex = 0
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(154, 35)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(142, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'dlg
        '
        Me.dlg.BackColor = System.Drawing.Color.Transparent
        Me.dlg.Controls.Add(Me.cbeliminar)
        Me.dlg.Controls.Add(Me.Button1)
        Me.dlg.Controls.Add(Me.inexistente)
        Me.dlg.Controls.Add(Me.txtbuscar)
        Me.dlg.Controls.Add(Me.cbocampo)
        Me.dlg.Controls.Add(Me.listado)
        Me.dlg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlg.ForeColor = System.Drawing.SystemColors.Highlight
        Me.dlg.Location = New System.Drawing.Point(399, 21)
        Me.dlg.Name = "dlg"
        Me.dlg.Size = New System.Drawing.Size(716, 445)
        Me.dlg.TabIndex = 18
        Me.dlg.TabStop = False
        Me.dlg.Text = "LISTADO DE ALUMNOS"
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
        Me.Button1.Location = New System.Drawing.Point(19, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dlgs
        '
        Me.dlgs.FileName = "OpenFileDialog1"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(280, 119)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(67, 20)
        Me.txtflag.TabIndex = 20
        Me.txtflag.Text = "0"
        Me.txtflag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtflag.Visible = False
        '
        'txtfecha_vencimiento
        '
        Me.txtfecha_vencimiento.Location = New System.Drawing.Point(12, 106)
        Me.txtfecha_vencimiento.Mask = "00/00/0000"
        Me.txtfecha_vencimiento.Name = "txtfecha_vencimiento"
        Me.txtfecha_vencimiento.Size = New System.Drawing.Size(124, 20)
        Me.txtfecha_vencimiento.TabIndex = 27
        Me.txtfecha_vencimiento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtfecha_vencimiento.ValidatingType = GetType(Date)
        Me.txtfecha_vencimiento.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(91, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(246, 57)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "REGISTRO  DE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(212, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 57)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "ALUMNOS"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Location = New System.Drawing.Point(399, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 55)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "REALIZAR MATRICULA "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sisventas.My.Resources.Resources.descarga
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1127, 610)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtfecha_vencimiento)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dlg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlumnos"
        Me.Text = ".:.REGISTRO DE ALUMNOS.:."
        CType(Me.listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dlg.ResumeLayout(False)
        Me.dlg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents listado As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents dlg As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnivel As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtidalumno As TextBox
    Friend WithEvents btnbuscar_categoria As Button
    Friend WithEvents txtnombre_docente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtiddocente As TextBox
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btncargar As PictureBox
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents dlgs As OpenFileDialog
    Friend WithEvents txtflag As TextBox
    Friend WithEvents fecha_vencimiento1 As DateTimePicker
    Friend WithEvents txtfecha_vencimiento As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
End Class
