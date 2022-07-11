<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For_FacturasRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For_FacturasRegistro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.CmbProyecto = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DTFechaRecibido = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DTFechaVence = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.LblCC = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValorCC = New System.Windows.Forms.TextBox()
        Me.CmbCentroCosto = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.LblRutafactura = New System.Windows.Forms.Label()
        Me.BtnAdjuntar = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ODRutaArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CmbAprobador = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtFactura)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "No. FACTURA"
        '
        'TxtFactura
        '
        Me.TxtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactura.Location = New System.Drawing.Point(6, 19)
        Me.TxtFactura.MaxLength = 20
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(140, 26)
        Me.TxtFactura.TabIndex = 1
        Me.TxtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblProveedor)
        Me.GroupBox4.Controls.Add(Me.BtnBuscar)
        Me.GroupBox4.Location = New System.Drawing.Point(177, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(595, 53)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROVEEDOR"
        '
        'LblProveedor
        '
        Me.LblProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProveedor.Location = New System.Drawing.Point(44, 19)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(545, 26)
        Me.LblProveedor.TabIndex = 14
        Me.LblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(6, 15)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtConcepto)
        Me.GroupBox2.Controls.Add(Me.GroupBox12)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(762, 170)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONCEPTO"
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConcepto.Location = New System.Drawing.Point(6, 19)
        Me.TxtConcepto.MaxLength = 2000
        Me.TxtConcepto.Multiline = True
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(746, 82)
        Me.TxtConcepto.TabIndex = 1
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.CmbProyecto)
        Me.GroupBox12.Location = New System.Drawing.Point(536, 109)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(217, 53)
        Me.GroupBox12.TabIndex = 26
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "PROYECTO"
        '
        'CmbProyecto
        '
        Me.CmbProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProyecto.FormattingEnabled = True
        Me.CmbProyecto.Location = New System.Drawing.Point(6, 19)
        Me.CmbProyecto.Name = "CmbProyecto"
        Me.CmbProyecto.Size = New System.Drawing.Size(204, 28)
        Me.CmbProyecto.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTFechaExpedicion)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FECHA EXPEDICION"
        '
        'DTFechaExpedicion
        '
        Me.DTFechaExpedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaExpedicion.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaExpedicion.Name = "DTFechaExpedicion"
        Me.DTFechaExpedicion.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaExpedicion.TabIndex = 16
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DTFechaRecibido)
        Me.GroupBox5.Location = New System.Drawing.Point(183, 107)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "FECHA RECIBIDO"
        '
        'DTFechaRecibido
        '
        Me.DTFechaRecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaRecibido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaRecibido.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaRecibido.Name = "DTFechaRecibido"
        Me.DTFechaRecibido.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaRecibido.TabIndex = 16
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DTFechaVence)
        Me.GroupBox6.Location = New System.Drawing.Point(367, 109)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(148, 53)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "VENCIMIENTO"
        '
        'DTFechaVence
        '
        Me.DTFechaVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaVence.Location = New System.Drawing.Point(6, 17)
        Me.DTFechaVence.Name = "DTFechaVence"
        Me.DTFechaVence.Size = New System.Drawing.Size(134, 29)
        Me.DTFechaVence.TabIndex = 16
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.TxtTotal)
        Me.GroupBox7.Controls.Add(Me.TxtIva)
        Me.GroupBox7.Controls.Add(Me.TxtSubtotal)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 303)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(336, 141)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TOTAL :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IVA :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SUBTOTAL :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(150, 92)
        Me.TxtTotal.MaxLength = 15
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(174, 31)
        Me.TxtTotal.TabIndex = 2
        Me.TxtTotal.Text = "$ 0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIva
        '
        Me.TxtIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(150, 55)
        Me.TxtIva.MaxLength = 15
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(174, 31)
        Me.TxtIva.TabIndex = 1
        Me.TxtIva.Text = "$ 0"
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubtotal.Location = New System.Drawing.Point(150, 18)
        Me.TxtSubtotal.MaxLength = 15
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(174, 31)
        Me.TxtSubtotal.TabIndex = 0
        Me.TxtSubtotal.Text = "$ 0"
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.LblCC)
        Me.GroupBox10.Controls.Add(Me.Label1)
        Me.GroupBox10.Controls.Add(Me.TxtValorCC)
        Me.GroupBox10.Controls.Add(Me.CmbCentroCosto)
        Me.GroupBox10.Location = New System.Drawing.Point(20, 450)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(555, 53)
        Me.GroupBox10.TabIndex = 5
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "CENTRO DE COSTO"
        '
        'LblCC
        '
        Me.LblCC.BackColor = System.Drawing.Color.Transparent
        Me.LblCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCC.Location = New System.Drawing.Point(252, 18)
        Me.LblCC.Name = "LblCC"
        Me.LblCC.Size = New System.Drawing.Size(82, 29)
        Me.LblCC.TabIndex = 3
        Me.LblCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VALOR :"
        '
        'TxtValorCC
        '
        Me.TxtValorCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtValorCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorCC.Location = New System.Drawing.Point(408, 15)
        Me.TxtValorCC.MaxLength = 15
        Me.TxtValorCC.Name = "TxtValorCC"
        Me.TxtValorCC.Size = New System.Drawing.Size(140, 31)
        Me.TxtValorCC.TabIndex = 1
        Me.TxtValorCC.Text = "$ 0"
        Me.TxtValorCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbCentroCosto
        '
        Me.CmbCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCentroCosto.FormattingEnabled = True
        Me.CmbCentroCosto.Location = New System.Drawing.Point(6, 19)
        Me.CmbCentroCosto.Name = "CmbCentroCosto"
        Me.CmbCentroCosto.Size = New System.Drawing.Size(232, 28)
        Me.CmbCentroCosto.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.BtnBorrar)
        Me.GroupBox8.Controls.Add(Me.LblRutafactura)
        Me.GroupBox8.Controls.Add(Me.BtnAdjuntar)
        Me.GroupBox8.Location = New System.Drawing.Point(14, 68)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(758, 53)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "FACTURA"
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.Location = New System.Drawing.Point(718, 14)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(33, 35)
        Me.BtnBorrar.TabIndex = 2
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'LblRutafactura
        '
        Me.LblRutafactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRutafactura.Location = New System.Drawing.Point(111, 16)
        Me.LblRutafactura.Name = "LblRutafactura"
        Me.LblRutafactura.Size = New System.Drawing.Size(607, 32)
        Me.LblRutafactura.TabIndex = 1
        Me.LblRutafactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAdjuntar
        '
        Me.BtnAdjuntar.Image = CType(resources.GetObject("BtnAdjuntar.Image"), System.Drawing.Image)
        Me.BtnAdjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdjuntar.Location = New System.Drawing.Point(6, 16)
        Me.BtnAdjuntar.Name = "BtnAdjuntar"
        Me.BtnAdjuntar.Size = New System.Drawing.Size(99, 33)
        Me.BtnAdjuntar.TabIndex = 0
        Me.BtnAdjuntar.Text = "Pegar URL"
        Me.BtnAdjuntar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdjuntar.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox9.Location = New System.Drawing.Point(354, 303)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(421, 86)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "OBSERVACIONES"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(6, 19)
        Me.TxtObservaciones.MaxLength = 500
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(400, 61)
        Me.TxtObservaciones.TabIndex = 1
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Gray
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(615, 452)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(161, 51)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "Registrar Factura"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'ODRutaArchivo
        '
        Me.ODRutaArchivo.FileName = "OpenFileDialog1"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CmbAprobador)
        Me.GroupBox11.Controls.Add(Me.Label5)
        Me.GroupBox11.Location = New System.Drawing.Point(356, 393)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(418, 51)
        Me.GroupBox11.TabIndex = 7
        Me.GroupBox11.TabStop = False
        '
        'CmbAprobador
        '
        Me.CmbAprobador.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAprobador.FormattingEnabled = True
        Me.CmbAprobador.Location = New System.Drawing.Point(87, 16)
        Me.CmbAprobador.Name = "CmbAprobador"
        Me.CmbAprobador.Size = New System.Drawing.Size(317, 26)
        Me.CmbAprobador.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "APROBADOR"
        '
        'For_FacturasRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 515)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "For_FacturasRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Facturas "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtFactura As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblProveedor As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents CmbProyecto As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DTFechaExpedicion As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DTFechaRecibido As DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DTFechaVence As DateTimePicker
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtIva As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValorCC As TextBox
    Friend WithEvents CmbCentroCosto As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents LblRutafactura As Label
    Friend WithEvents BtnAdjuntar As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblCC As Label
    Friend WithEvents ODRutaArchivo As OpenFileDialog
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CmbAprobador As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnBorrar As Button
End Class
