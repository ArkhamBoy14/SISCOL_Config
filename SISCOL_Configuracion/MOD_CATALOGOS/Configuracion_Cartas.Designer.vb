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
        Me.Panel1 = New Wisej.Web.Panel()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.Cmb_CategoriaCSE = New Wisej.Web.ComboBox()
        Me.Chk_AplicaCSE = New Wisej.Web.CheckBox()
        Me.Cmb_Clasificacion = New Wisej.Web.ComboBox()
        Me.Chk_Clasificacion = New Wisej.Web.CheckBox()
        Me.Chk_Especifica = New Wisej.Web.CheckBox()
        Me.Label5 = New Wisej.Web.Label()
        Me.Dtp_FechaCarta = New Wisej.Web.DateTimePicker()
        Me.rb_EsCopia = New Wisej.Web.RadioButton()
        Me.rb_FechaActual = New Wisej.Web.RadioButton()
        Me.CheckBox1 = New Wisej.Web.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 469)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
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
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 265)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.Text = "Fecha de Impresión"
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
        'rb_EsCopia
        '
        Me.rb_EsCopia.Location = New System.Drawing.Point(122, 21)
        Me.rb_EsCopia.Name = "rb_EsCopia"
        Me.rb_EsCopia.Size = New System.Drawing.Size(118, 22)
        Me.rb_EsCopia.TabIndex = 4
        Me.rb_EsCopia.Text = "Fecha Anterior"
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
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 153)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 22)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Aplica Categoría (CSE)"
        '
        'Configuracion_Cartas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 469)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Configuracion_Cartas"
        Me.Text = "Configuracion_Cartas"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Cmb_CategoriaCSE As ComboBox
    Friend WithEvents Chk_AplicaCSE As CheckBox
    Friend WithEvents Cmb_Clasificacion As ComboBox
    Friend WithEvents Chk_Clasificacion As CheckBox
    Friend WithEvents Chk_Especifica As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Dtp_FechaCarta As DateTimePicker
    Friend WithEvents rb_EsCopia As RadioButton
    Friend WithEvents rb_FechaActual As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
End Class
