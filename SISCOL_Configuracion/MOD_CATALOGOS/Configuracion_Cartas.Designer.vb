<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion_Cartas
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.opcDRO = New Wisej.Web.RadioButton()
        Me.AspNetPanel1 = New SISCOL_Configuracion.AspNetPanelII()
        Me.GroupBox4 = New Wisej.Web.GroupBox()
        Me.opcRTEC = New Wisej.Web.RadioButton()
        Me.rb_FechaActual = New Wisej.Web.RadioButton()
        Me.Cbx_DRO = New SISCOL_Configuracion.ComboWisax()
        Me.Cbx_RTEC = New SISCOL_Configuracion.ComboWisax()
        Me.Cbx_Secretario = New SISCOL_Configuracion.ComboWisax()
        Me.Cbx_Presidente = New SISCOL_Configuracion.ComboWisax()
        Me.Label4 = New Wisej.Web.Label()
        Me.rb_EsCopia = New Wisej.Web.RadioButton()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.Cmb_Clasificacion = New Wisej.Web.ComboBox()
        Me.Chk_Clasificacion = New Wisej.Web.CheckBox()
        Me.Chk_Especifica = New Wisej.Web.CheckBox()
        Me.Label5 = New Wisej.Web.Label()
        Me.Dtp_FechaCarta = New Wisej.Web.DateTimePicker()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Btn_Guardar = New Wisej.Web.Button()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.Cmb_CategoriaCSE = New Wisej.Web.ComboBox()
        Me.Chk_AplicaCSE = New Wisej.Web.CheckBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'opcDRO
        '
        Me.opcDRO.Checked = True
        Me.opcDRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.opcDRO.Location = New System.Drawing.Point(108, 26)
        Me.opcDRO.Name = "opcDRO"
        Me.opcDRO.Size = New System.Drawing.Size(62, 22)
        Me.opcDRO.TabIndex = 0
        Me.opcDRO.TabStop = True
        Me.opcDRO.Text = "DRO"
        '
        'AspNetPanel1
        '
        Me.AspNetPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.AspNetPanel1.Location = New System.Drawing.Point(0, 66)
        Me.AspNetPanel1.Name = "AspNetPanel1"
        Me.AspNetPanel1.Size = New System.Drawing.Size(453, 412)
        Me.AspNetPanel1.TabIndex = 4
        Me.AspNetPanel1.Text = "AspNetPanelII1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.opcRTEC)
        Me.GroupBox4.Controls.Add(Me.opcDRO)
        Me.GroupBox4.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(453, 66)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.Text = "Vista Previa"
        '
        'opcRTEC
        '
        Me.opcRTEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.opcRTEC.Location = New System.Drawing.Point(313, 26)
        Me.opcRTEC.Name = "opcRTEC"
        Me.opcRTEC.Size = New System.Drawing.Size(69, 22)
        Me.opcRTEC.TabIndex = 1
        Me.opcRTEC.Text = "RTEC"
        '
        'rb_FechaActual
        '
        Me.rb_FechaActual.Checked = True
        Me.rb_FechaActual.Location = New System.Drawing.Point(8, 21)
        Me.rb_FechaActual.Name = "rb_FechaActual"
        Me.rb_FechaActual.Size = New System.Drawing.Size(108, 22)
        Me.rb_FechaActual.TabIndex = 3
        Me.rb_FechaActual.TabStop = True
        Me.rb_FechaActual.Text = "Fecha Actual"
        '
        'Cbx_DRO
        '
        Me.Cbx_DRO.Location = New System.Drawing.Point(17, 196)
        Me.Cbx_DRO.Name = "Cbx_DRO"
        Me.Cbx_DRO.Size = New System.Drawing.Size(363, 22)
        Me.Cbx_DRO.TabIndex = 7
        '
        'Cbx_RTEC
        '
        Me.Cbx_RTEC.Location = New System.Drawing.Point(17, 147)
        Me.Cbx_RTEC.Name = "Cbx_RTEC"
        Me.Cbx_RTEC.Size = New System.Drawing.Size(363, 22)
        Me.Cbx_RTEC.TabIndex = 6
        '
        'Cbx_Secretario
        '
        Me.Cbx_Secretario.Location = New System.Drawing.Point(17, 100)
        Me.Cbx_Secretario.Name = "Cbx_Secretario"
        Me.Cbx_Secretario.Size = New System.Drawing.Size(363, 22)
        Me.Cbx_Secretario.TabIndex = 5
        '
        'Cbx_Presidente
        '
        Me.Cbx_Presidente.Location = New System.Drawing.Point(17, 46)
        Me.Cbx_Presidente.Name = "Cbx_Presidente"
        Me.Cbx_Presidente.Size = New System.Drawing.Size(363, 22)
        Me.Cbx_Presidente.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = Wisej.Web.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Comisión DRO"
        '
        'rb_EsCopia
        '
        Me.rb_EsCopia.Location = New System.Drawing.Point(122, 21)
        Me.rb_EsCopia.Name = "rb_EsCopia"
        Me.rb_EsCopia.Size = New System.Drawing.Size(118, 22)
        Me.rb_EsCopia.TabIndex = 4
        Me.rb_EsCopia.Text = "Fecha Anterior"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cmb_CategoriaCSE)
        Me.GroupBox2.Controls.Add(Me.Chk_AplicaCSE)
        Me.GroupBox2.Controls.Add(Me.Cmb_Clasificacion)
        Me.GroupBox2.Controls.Add(Me.Chk_Clasificacion)
        Me.GroupBox2.Controls.Add(Me.Chk_Especifica)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Dtp_FechaCarta)
        Me.GroupBox2.Controls.Add(Me.rb_EsCopia)
        Me.GroupBox2.Controls.Add(Me.rb_FechaActual)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 168)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.Text = "Fecha de Impresión"
        '
        'Cmb_Clasificacion
        '
        Me.Cmb_Clasificacion.Items.AddRange(New Object() {"Categoría A", "Categoría B", "Categoría C"})
        Me.Cmb_Clasificacion.Location = New System.Drawing.Point(174, 97)
        Me.Cmb_Clasificacion.Name = "Cmb_Clasificacion"
        Me.Cmb_Clasificacion.Size = New System.Drawing.Size(222, 22)
        Me.Cmb_Clasificacion.TabIndex = 10
        '
        'Chk_Clasificacion
        '
        Me.Chk_Clasificacion.Location = New System.Drawing.Point(8, 97)
        Me.Chk_Clasificacion.Name = "Chk_Clasificacion"
        Me.Chk_Clasificacion.Size = New System.Drawing.Size(170, 22)
        Me.Chk_Clasificacion.TabIndex = 9
        Me.Chk_Clasificacion.Text = "Aplica Categoría (DRO)"
        '
        'Chk_Especifica
        '
        Me.Chk_Especifica.Location = New System.Drawing.Point(264, 21)
        Me.Chk_Especifica.Name = "Chk_Especifica"
        Me.Chk_Especifica.Size = New System.Drawing.Size(132, 22)
        Me.Chk_Especifica.TabIndex = 8
        Me.Chk_Especifica.Text = "Fecha Específica"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Seleccione la fecha específica:"
        '
        'Dtp_FechaCarta
        '
        Me.Dtp_FechaCarta.Enabled = False
        Me.Dtp_FechaCarta.Format = Wisej.Web.DateTimePickerFormat.[Short]
        Me.Dtp_FechaCarta.Location = New System.Drawing.Point(197, 57)
        Me.Dtp_FechaCarta.Name = "Dtp_FechaCarta"
        Me.Dtp_FechaCarta.Size = New System.Drawing.Size(92, 22)
        Me.Dtp_FechaCarta.TabIndex = 6
        Me.Dtp_FechaCarta.Value = New Date(2022, 8, 4, 10, 51, 54, 212)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comisión RTEC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Secretario"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(280, 228)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(100, 60)
        Me.Btn_Guardar.TabIndex = 8
        Me.Btn_Guardar.Text = "Guardar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox3.Controls.Add(Me.Cbx_DRO)
        Me.GroupBox3.Controls.Add(Me.Cbx_RTEC)
        Me.GroupBox3.Controls.Add(Me.Cbx_Secretario)
        Me.GroupBox3.Controls.Add(Me.Cbx_Presidente)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(487, 299)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.Text = "Firmas de Cartas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Presidente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 478)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "Configuración de Cartas"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.TabStop = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AspNetPanel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.TabStop = True
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 480)
        Me.SplitContainer1.SplitterDistance = 495
        Me.SplitContainer1.TabIndex = 4
        '
        'Cmb_CategoriaCSE
        '
        Me.Cmb_CategoriaCSE.Items.AddRange(New Object() {"Categoría A", "Categoría B", "Categoría C"})
        Me.Cmb_CategoriaCSE.Location = New System.Drawing.Point(174, 125)
        Me.Cmb_CategoriaCSE.Name = "Cmb_CategoriaCSE"
        Me.Cmb_CategoriaCSE.Size = New System.Drawing.Size(222, 22)
        Me.Cmb_CategoriaCSE.TabIndex = 12
        '
        'Chk_AplicaCSE
        '
        Me.Chk_AplicaCSE.Location = New System.Drawing.Point(8, 125)
        Me.Chk_AplicaCSE.Name = "Chk_AplicaCSE"
        Me.Chk_AplicaCSE.Size = New System.Drawing.Size(168, 22)
        Me.Chk_AplicaCSE.TabIndex = 11
        Me.Chk_AplicaCSE.Text = "Aplica Categoría (CSE)"
        '
        'Configuracion_Cartas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 480)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Configuracion_Cartas"
        Me.Text = "Configuracion_Cartas"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents opcDRO As RadioButton
    Friend WithEvents AspNetPanel1 As AspNetPanelII
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents opcRTEC As RadioButton
    Friend WithEvents rb_FechaActual As RadioButton
    Friend WithEvents Cbx_DRO As ComboWisax
    Friend WithEvents Cbx_RTEC As ComboWisax
    Friend WithEvents Cbx_Secretario As ComboWisax
    Friend WithEvents Cbx_Presidente As ComboWisax
    Friend WithEvents Label4 As Label
    Friend WithEvents rb_EsCopia As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Dtp_FechaCarta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Chk_Especifica As CheckBox
    Friend WithEvents Cmb_Clasificacion As ComboBox
    Friend WithEvents Chk_Clasificacion As CheckBox
    Friend WithEvents Cmb_CategoriaCSE As ComboBox
    Friend WithEvents Chk_AplicaCSE As CheckBox
End Class
