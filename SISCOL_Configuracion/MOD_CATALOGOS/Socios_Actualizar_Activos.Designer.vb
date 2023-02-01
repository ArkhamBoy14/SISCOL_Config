<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socios_Actualizar_Activos
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
        Me.components = New System.ComponentModel.Container()
        Me.Dte_Inicial = New Wisej.Web.DateTimePicker()
        Me.Dte_Final = New Wisej.Web.DateTimePicker()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Btn_Guardar = New Wisej.Web.Button()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dte_Inicial
        '
        Me.Dte_Inicial.Format = Wisej.Web.DateTimePickerFormat.[Short]
        Me.Dte_Inicial.Location = New System.Drawing.Point(114, 43)
        Me.Dte_Inicial.Name = "Dte_Inicial"
        Me.Dte_Inicial.Size = New System.Drawing.Size(102, 22)
        Me.Dte_Inicial.TabIndex = 0
        Me.Dte_Inicial.Value = New Date(2022, 8, 17, 15, 51, 0, 0)
        '
        'Dte_Final
        '
        Me.Dte_Final.Format = Wisej.Web.DateTimePickerFormat.[Short]
        Me.Dte_Final.Location = New System.Drawing.Point(114, 109)
        Me.Dte_Final.Name = "Dte_Final"
        Me.Dte_Final.Size = New System.Drawing.Size(102, 22)
        Me.Dte_Final.TabIndex = 1
        Me.Dte_Final.Value = New Date(2022, 8, 17, 15, 51, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha final:"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromName("@buttonPressed")
        Me.Btn_Guardar.Image = Global.SISCOL_Configuracion.My.Resources.Resources.Save_Filled_64
        Me.Btn_Guardar.Location = New System.Drawing.Point(106, 190)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(80, 70)
        Me.Btn_Guardar.TabIndex = 4
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Socios_Actualizar_Activos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 290)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dte_Final)
        Me.Controls.Add(Me.Dte_Inicial)
        Me.Name = "Socios_Actualizar_Activos"
        Me.Text = "Socios_Actualizar_Activos"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dte_Inicial As DateTimePicker
    Friend WithEvents Dte_Final As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
