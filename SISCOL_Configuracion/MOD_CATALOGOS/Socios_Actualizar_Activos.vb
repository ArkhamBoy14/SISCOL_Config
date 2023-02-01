Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient


Public Class Socios_Actualizar_Activos
    Dim Alertas As New Notificaciones
    Dim cvesocio As String = ""


    Private Function ValidarDatos() As Boolean
        ValidarDatos = True

        If Dte_Inicial.Value = Nothing Then
            Me.ErrorProvider1.SetError(Dte_Inicial, "Ingrese una fecha especifica")
            Dte_Inicial.Focus()
            ValidarDatos = False
        Else
            Me.ErrorProvider1.SetError(Dte_Inicial, Nothing)
        End If

        If Dte_Final.Value = Nothing Then
            Me.ErrorProvider1.SetError(Dte_Final, "Ingrese una fecha especifica")
            Dte_Final.Focus()
            ValidarDatos = False
        Else
            Me.ErrorProvider1.SetError(Dte_Final, Nothing)
        End If
    End Function

    Sub Guardar()
        If ValidarDatos() Then
            Try
                Dim fechA1 As Date = Now
                Date.TryParse(Dte_Inicial.Value, fechA1)
                Dim fechA2 As Date = Now
                Date.TryParse(Dte_Final.Value, fechA2)

                ReDim Utilidades.ParametersX_Global(1)
                Utilidades.ParametersX_Global(0) = New SqlParameter("@Fecha1", Format(fechA1, "yyyyMMdd"))
                Utilidades.ParametersX_Global(1) = New SqlParameter("@Fecha2", Format(fechA2, "yyyyMMdd"))
                cvesocio = Utilidades.EjecutarProcedure_Id("pSOCIOS_ACTUALIZAR_ACTIVOS_G", "@PARAMETRO", Utilidades.ParametersX_Global)
                If cvesocio <> Nothing And cvesocio > -1 Then
                    MessageBox.Show("Datos guardados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Datos no guardados", "Error" & cvesocio, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Guardar()
    End Sub
End Class
