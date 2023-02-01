Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient

Imports DevExpress.XtraReports.UI
Public Class R_MEMBRESIA_CACHAC
    Inherits DevExpress.XtraReports.UI.XtraReport
    
#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents TxtLeyenda As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ENCABEZADO As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PIE_DE_PAGINA As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FolioConstancia As DevExpress.XtraReports.Parameters.Parameter
    'Friend WithEvents DataSet_pCONSTANCIA_iMPRIMIR_B1 As DataSet_pCONSTANCIA_iMPRIMIR_B
    'Friend WithEvents PCONSTANCIA_iMPRIMIR_BTableAdapter As DataSet_pCONSTANCIA_iMPRIMIR_BTableAdapters.pCONSTANCIA_iMPRIMIR_BTableAdapter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_MEMBRESIA_CACHAC))
        Dim Code39Generator1 As DevExpress.XtraPrinting.BarCode.Code39Generator = New DevExpress.XtraPrinting.BarCode.Code39Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TxtLeyenda = New DevExpress.XtraReports.UI.XRRichText()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ENCABEZADO = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.PIE_DE_PAGINA = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.FolioConstancia = New DevExpress.XtraReports.Parameters.Parameter()
        'Me.DataSet_pCONSTANCIA_iMPRIMIR_B1 = New iSISCOL.DataSet_pCONSTANCIA_iMPRIMIR_B()
        'Me.PCONSTANCIA_iMPRIMIR_BTableAdapter = New iSISCOL.DataSet_pCONSTANCIA_iMPRIMIR_BTableAdapters.pCONSTANCIA_iMPRIMIR_BTableAdapter()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLeyenda, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DataSet_pCONSTANCIA_iMPRIMIR_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrRichText3, Me.XrRichText4, Me.XrRichText5, Me.XrRichText1, Me.XrRichText2, Me.TxtLeyenda})
        Me.Detail.HeightF = 648.0294!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 16.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(27.50004!, 478.4363!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(601.0416!, 38.9314!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "[Fecha_Solo_Mes]"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrRichText3
        '
        Me.XrRichText3.Font = New DevExpress.Drawing.DXFont("Times New Roman", 20.0!)
        Me.XrRichText3.ForeColor = System.Drawing.Color.Red
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(300.4867!, 0!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(328.055!, 29.25!)
        Me.XrRichText3.StylePriority.UseFont = False
        Me.XrRichText3.StylePriority.UseForeColor = False
        '
        'XrRichText4
        '
        Me.XrRichText4.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 578.8211!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(321.8799!, 69.20831!)
        '
        'XrRichText5
        '
        Me.XrRichText5.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(321.8799!, 578.8211!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(323.87!, 69.20831!)
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(27.50004!, 99.44852!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(601.0416!, 101.125!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(27.50004!, 248.4469!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(601.0416!, 49.04167!)
        Me.XrRichText2.StylePriority.UseFont = False
        '
        'TxtLeyenda
        '
        Me.TxtLeyenda.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.TxtLeyenda.LocationFloat = New DevExpress.Utils.PointFloat(27.50004!, 322.5074!)
        Me.TxtLeyenda.Name = "TxtLeyenda"
        Me.TxtLeyenda.SerializableRtfString = resources.GetString("TxtLeyenda.SerializableRtfString")
        Me.TxtLeyenda.SizeF = New System.Drawing.SizeF(601.0416!, 117.5685!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrLabel2, Me.XrLabel1, Me.ENCABEZADO})
        Me.PageHeader.HeightF = 222.37!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(401.0001!, 182.37!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(250.0!, 40.0!)
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Code39Generator1.CalcCheckSum = False
        Code39Generator1.WideNarrowRatio = 3.0!
        Me.XrBarCode1.Symbology = Code39Generator1
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 199.37!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(259.375!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "PRESENTE"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 176.37!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(259.375!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "A QUIEN CORRESPONDA "
        '
        'ENCABEZADO
        '
        Me.ENCABEZADO.LocationFloat = New DevExpress.Utils.PointFloat(480.2301!, 0!)
        Me.ENCABEZADO.Name = "ENCABEZADO"
        Me.ENCABEZADO.SizeF = New System.Drawing.SizeF(169.77!, 182.37!)
        Me.ENCABEZADO.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PIE_DE_PAGINA})
        Me.PageFooter.HeightF = 134.4!
        Me.PageFooter.Name = "PageFooter"
        '
        'PIE_DE_PAGINA
        '
        Me.PIE_DE_PAGINA.LocationFloat = New DevExpress.Utils.PointFloat(358.8001!, 0!)
        Me.PIE_DE_PAGINA.Name = "PIE_DE_PAGINA"
        Me.PIE_DE_PAGINA.SizeF = New System.Drawing.SizeF(292.2!, 134.4!)
        Me.PIE_DE_PAGINA.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'GroupHeader1
        '
        Me.GroupHeader1.HeightF = 0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'FolioConstancia
        '
        Me.FolioConstancia.Name = "FolioConstancia"
        '
        'DataSet_pCONSTANCIA_iMPRIMIR_B1
        '
        'Me.DataSet_pCONSTANCIA_iMPRIMIR_B1.DataSetName = "DataSet_pCONSTANCIA_iMPRIMIR_B"
        'Me.DataSet_pCONSTANCIA_iMPRIMIR_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCONSTANCIA_iMPRIMIR_BTableAdapter
        '
        'Me.PCONSTANCIA_iMPRIMIR_BTableAdapter.ClearBeforeFill = True
        '
        'R_MEMBRESIA_CACHAC
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
        'Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCONSTANCIA_iMPRIMIR_B1})
        Me.DataMember = "pCONSTANCIA_iMPRIMIR_B"
        'Me.DataSource = Me.DataSet_pCONSTANCIA_iMPRIMIR_B1
        Me.Margins = New DevExpress.Drawing.DXMargins(100, 99, 0, 0)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.FolioConstancia})
        Me.Version = "17.2"
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLeyenda, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DataSet_pCONSTANCIA_iMPRIMIR_B1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Private Sub R_Membresia_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        Try
            ReDim Utilidades.ParametersX_Global(1)
            Dim ultimoIndice As Integer = 0
            For n = 0 To Parameters.Count - 1
                If Not Parameters.Item(n).Value = "" Then
                    Utilidades.ParametersX_Global(n) = New SqlParameter("@" & Parameters.Item(n).Name, Parameters.Item(n).Value)
                    ultimoIndice += 1
                End If
            Next
            'Utilidades.Llenar_Catalogos("pCONSTANCIA_iMPRIMIR_B", Me.DataSet_pCONSTANCIA_iMPRIMIR_B1, "", Utilidades.ParametersX_Global)

            'Utilidades.EstablecerImagenReporte(ENCABEZADO, "LOGOS", GetCurrentColumnValue("ENCABEZADO_IMG_1"))
            'Utilidades.EstablecerImagenReporte(PIE_DE_PAGINA, "LOGOS", GetCurrentColumnValue("PIE_PAGINA_IMG"))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub R_MEMBRESIA_CACHAC_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint

    End Sub
End Class