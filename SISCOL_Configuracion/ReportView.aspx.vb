Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraPrinting
Imports System.IO

Public Class ReportView
    Inherits System.Web.UI.Page
    Dim sReportName, sProcedureName As String
    Dim _report, _report2, _report3, _report4, _report5 As XtraReport
    Dim DicX As New Dictionary(Of String, Object)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Wisej.Web.Application.Session("DocumentCached") Is Nothing Then

                sReportName = Wisej.Web.Application.Session("ReportName")
                DicX = Wisej.Web.Application.Session("DicParametros")
                If Trim(sReportName) <> Nothing Then

                    Dim _ReporteInstance As XtraReport
                    Try
                        _ReporteInstance = Activator.CreateInstance(Type.GetType("SISCOL_Configuracion." & sReportName))
                        If DicX Is Nothing = False Then
                            For i = 0 To DicX.Count - 1
                                _ReporteInstance.Parameters(DicX.Keys(i)).Value = DicX.Values(i)
                            Next
                        End If
                        Dim MS As New MemoryStream()
                        Dim opts As New DevExpress.XtraPrinting.PdfExportOptions
                        'opts.ShowPrintDialogOnOpen = True
                        MS.Seek(0, SeekOrigin.Begin)
                        _ReporteInstance.ExportToPdf(MS, opts)

                        Dim report As Byte() = MS.ToArray()
                        Page.Response.ContentType = "application/pdf"
                        Page.Response.Clear()
                        Page.Response.OutputStream.Write(report, 0, report.Length)

                        _ReporteInstance.CreateDocument()
                        'ASPxDocumentViewer2.Report = _ReporteInstance
                    Catch ex1 As Exception
                        MessageBox.Show(ex1.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                End If
            End If
            DicX = Nothing
            Wisej.Web.Application.Session("DicParametros") = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Wisej.Web.Application.Session("ds") = ""
        Wisej.Web.Application.Session("XDATASET") = ""
    End Sub
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Protected Sub ReportViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As CacheReportDocumentEventArgs)
        Try
            e.Key = Guid.NewGuid().ToString()
            Page.Session(e.Key) = e.SaveDocumentToMemoryStream()
            Wisej.Web.Application.Session("DocumentCached") = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Protected Sub ReportViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As RestoreReportDocumentFromCacheEventArgs)
        Dim stream As IO.Stream = TryCast(Page.Session(e.Key), IO.Stream)
        Try
            If stream IsNot Nothing Then
                e.RestoreDocumentFromStream(stream)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class