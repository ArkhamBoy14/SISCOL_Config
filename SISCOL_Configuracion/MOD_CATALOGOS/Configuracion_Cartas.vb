Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class Configuracion_Cartas

    Dim Alertas As New Notificaciones
    Private Sub Configuracion_Inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ImprimirDocumento()
    End Sub
    Sub CargarCombos()
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@ACTUAL", "SI")
        Cbx_Presidente.LlenarListBox("pSOCIOS_CONSEJO_CARGOS", "Cve_Socio", "NombreCompletoX", Utilidades.ParametersX_Global)
        Cbx_Secretario.LlenarListBox("pSOCIOS_CONSEJO_CARGOS", "Cve_Socio", "NombreCompletoX", Utilidades.ParametersX_Global)
        Cbx_DRO.LlenarListBox("pSOCIOS_CONSEJO_CARGOS", "Cve_Socio", "NombreCompletoX", Utilidades.ParametersX_Global)
        Cbx_RTEC.LlenarListBox("pSOCIOS_CONSEJO_CARGOS", "Cve_Socio", "NombreCompletoX", Utilidades.ParametersX_Global)
        CargarDatos()
    End Sub


    Sub CargarDatos()
        Utilidades.Conectar()
        Dim DataReader As SqlDataReader
        Dim Command As New SqlCommand

        Try
            Command = New SqlClient.SqlCommand("pCONFIGURACION_CARTAS_IMPRESION", Utilidades.cConnect)
            Command.CommandType = CommandType.StoredProcedure
            DataReader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            If DataReader.HasRows Then
                While (DataReader.Read)
                    If DataReader.Item("EsCopia") = True Then
                        rb_FechaActual.Checked = DataReader.Item("EsCopia")
                    Else
                        rb_EsCopia.Checked = DataReader.Item("EsCopia")

                    End If

                    Cbx_Presidente.SelectedValue = DataReader.Item("Firma_Presidente")
                    Cbx_Secretario.SelectedValue = DataReader.Item("Firma_Secretario")
                    Cbx_DRO.SelectedValue = DataReader.Item("Firma_Comision_DRO")
                    Cbx_RTEC.SelectedValue = DataReader.Item("Firma_Comision_RTEC")
                    Chk_Clasificacion.Checked = DataReader.Item("AplicaCategoriaDRO")
                    Cmb_Clasificacion.SelectedItem = DataReader.Item("CategoriaDRO")
                    Chk_AplicaCSE.Checked = DataReader.Item("AplicaCategoriaCSE")
                    Cmb_CategoriaCSE.SelectedItem = DataReader.Item("CategoriaCSE")


                End While
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If IsNothing(DataReader) = False Then
                If DataReader.IsClosed = False Then DataReader.Close()
            End If
            Utilidades.Desconectar()
        End Try

    End Sub
    Sub Guardar()
        Try
            ReDim Utilidades.ParametersX_Global(10)
            Utilidades.ParametersX_Global(0) = New SqlParameter("@EsCopia", rb_EsCopia.Checked)
            Utilidades.ParametersX_Global(1) = New SqlParameter("@Firma_Presidente", Cbx_Presidente.SelectedValue)
            Utilidades.ParametersX_Global(2) = New SqlParameter("@Firma_Secretario", Cbx_Secretario.SelectedValue)
            Utilidades.ParametersX_Global(3) = New SqlParameter("@Firma_Comision_DRO", Cbx_DRO.SelectedValue)
            Utilidades.ParametersX_Global(4) = New SqlParameter("@Firma_Comision_RTEC", Cbx_RTEC.SelectedValue)
            Utilidades.ParametersX_Global(5) = New SqlParameter("@Fecha_Especifica", Chk_Especifica.Checked)
            Utilidades.ParametersX_Global(6) = New SqlParameter("@Fecha_Impresion", Dtp_FechaCarta.Value)
            Utilidades.ParametersX_Global(7) = New SqlParameter("@AplicaCategoriaDRO", Chk_Clasificacion.Checked)
            Utilidades.ParametersX_Global(8) = New SqlParameter("@CategoriaDRO", IIf(Cmb_Clasificacion.SelectedItem = Nothing, "NA", Cmb_Clasificacion.SelectedItem))
            Utilidades.ParametersX_Global(9) = New SqlParameter("@AplicaCategoriaCSE", Chk_AplicaCSE.Checked)
            Utilidades.ParametersX_Global(10) = New SqlParameter("@CategoriaCSE", IIf(Cmb_CategoriaCSE.SelectedItem = Nothing, "NA", Cmb_CategoriaCSE.SelectedItem))


            Dim sDevuelveID = Utilidades.EjecutarProcedure_Id("pCONFIGURACION_CARTAS_IMPRESION_G", "@PARAMETRO", Utilidades.ParametersX_Global)
            If sDevuelveID = 1 Then
                Alertas.NotificacionExito("Se han guardado los datos con éxito", "Aviso")
            Else
                Alertas.NotificacionError("Error al guardar los datos, consulte con el administrador del sistema", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Guardar()
        ImprimirDocumento()
    End Sub

    Sub ImprimirDocumento()
        If opcDRO.Checked Then
            GenerarReporte("R_CARTA_DRO_CICCH")
        End If
        If opcRTEC.Checked Then
            GenerarReporte("R_CARTAS_RTEC_CICCH")
        End If
    End Sub

    Sub GenerarReporte(ByVal sReportName As String)
        Try
            If Trim(sReportName <> Nothing) Then
                AspNetPanel1.PageSource = Nothing
                Application.Session("ReportName") = sReportName
                Application.Session("DocumentCached") = Nothing
                AspNetPanel1.PageSource = "ReportView.aspx"
                Me.AspNetPanel1.Update()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cargar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub opcDRO_CheckedChanged(sender As Object, e As EventArgs) Handles opcDRO.CheckedChanged
        ImprimirDocumento()
    End Sub



    Private Sub Chk_Especifica_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Especifica.CheckedChanged
        If Chk_Especifica.Checked Then
            Dtp_FechaCarta.Enabled = True
        Else
            Dtp_FechaCarta.Enabled = False
        End If
    End Sub

    Private Sub Chk_Clasificacion_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Clasificacion.CheckedChanged
        If Chk_Clasificacion.Checked = True Then
            Cmb_Clasificacion.Enabled = True
        Else
            Cmb_Clasificacion.Enabled = False
        End If
    End Sub
End Class
