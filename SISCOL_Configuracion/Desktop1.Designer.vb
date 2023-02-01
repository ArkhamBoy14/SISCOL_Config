<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop1
    Inherits Wisej.Web.Desktop

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
        Me.NavigationBar1 = New Wisej.Web.Ext.NavigationBar.NavigationBar()
        Me.BtnConfig = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NBISocios_Activos = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.SuspendLayout()
        '
        'NavigationBar1
        '
        Me.NavigationBar1.Dock = Wisej.Web.DockStyle.Left
        Me.NavigationBar1.Items.AddRange(New Wisej.Web.Ext.NavigationBar.NavigationBarItem() {Me.BtnConfig, Me.NBISocios_Activos})
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Size = New System.Drawing.Size(315, 789)
        Me.NavigationBar1.TabIndex = 0
        Me.NavigationBar1.Text = "Menú de Configuración"
        '
        'BtnConfig
        '
        Me.BtnConfig.BackColor = System.Drawing.Color.Transparent
        Me.BtnConfig.Name = "NavigationBarItem"
        Me.BtnConfig.Text = "Configuración Inicial "
        '
        'NBISocios_Activos
        '
        Me.NBISocios_Activos.BackColor = System.Drawing.Color.Transparent
        Me.NBISocios_Activos.Name = "NavigationBarItem"
        Me.NBISocios_Activos.Text = "Actualizar Socios Activos"
        '
        'Desktop1
        '
        Me.Controls.Add(Me.NavigationBar1)
        Me.Name = "Desktop1"
        Me.Size = New System.Drawing.Size(1567, 837)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationBar1 As Ext.NavigationBar.NavigationBar
    Friend WithEvents BtnConfig As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NBISocios_Activos As Ext.NavigationBar.NavigationBarItem
End Class
