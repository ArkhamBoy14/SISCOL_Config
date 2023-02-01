Imports System
Imports Wisej.Web

Public Class Desktop1
    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click
        Dim window = New Configuracion_Cartas
        window.Show()
    End Sub

    Private Sub NBISocios_Activos_Click(sender As Object, e As EventArgs) Handles NBISocios_Activos.Click
        Dim window = New Socios_Actualizar_Activos
        window.Show()
    End Sub
End Class
