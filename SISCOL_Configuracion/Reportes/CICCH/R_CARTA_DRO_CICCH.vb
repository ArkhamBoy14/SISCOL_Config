Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Data.SqlClient

Public Class R_CARTA_DRO_CICCH
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

    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Encabezado As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Foto As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PIE_DE_PAGINA As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VALIDO As DevExpress.XtraReports.UI.XRLabel
    'Friend WithEvents DataSet_pCARTAS_IMPRIMIR_B1 As DataSet_pCARTAS_IMPRIMIR_B
    'Friend WithEvents PCARTAS_IMPRIMIR_BTableAdapter As DataSet_pCARTAS_IMPRIMIR_BTableAdapters.pCARTAS_IMPRIMIR_BTableAdapter
    Friend WithEvents Folio As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrRichText6 As XRRichText
    Friend WithEvents DataSet_pCARTA_IMPRIMIR1 As DataSet_pCARTA_IMPRIMIR
    Friend WithEvents PCARTA_IMPRIMIRTableAdapter As DataSet_pCARTA_IMPRIMIRTableAdapters.pCARTA_IMPRIMIRTableAdapter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_CARTA_DRO_CICCH))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText6 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.Foto = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.VALIDO = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Encabezado = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PIE_DE_PAGINA = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.Folio = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DataSet_pCARTA_IMPRIMIR1 = New SISCOL_Configuracion.DataSet_pCARTA_IMPRIMIR()
        Me.PCARTA_IMPRIMIRTableAdapter = New SISCOL_Configuracion.DataSet_pCARTA_IMPRIMIRTableAdapters.pCARTA_IMPRIMIRTableAdapter()
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCARTA_IMPRIMIR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText6, Me.XrLabel21, Me.XrLabel17, Me.XrLabel14, Me.XrLabel13, Me.XrRichText1, Me.Foto, Me.XrLabel6, Me.XrLabel16, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.VALIDO})
        Me.Detail.HeightF = 592.4501!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText6
        '
        Me.XrRichText6.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 63.47907!)
        Me.XrRichText6.Name = "XrRichText6"
        Me.XrRichText6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrRichText6.SerializableRtfString = resources.GetString("XrRichText6.SerializableRtfString")
        Me.XrRichText6.SizeF = New System.Drawing.SizeF(506.6668!, 125.8752!)
        Me.XrRichText6.StylePriority.UsePadding = False
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(0.001621246!, 575.4501!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(699.9399!, 16.99994!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "COMISIÓN DE DRO"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.001621246!, 472.4839!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(349.97!, 17.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "PRESIDENTE"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cConsejoDirectivo]")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0.06017685!, 402.2777!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(699.94!, 20.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "[cConsejoDirectivo]"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.06017685!, 384.2778!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(699.94!, 17.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "ATENTAMENTE"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 203.9167!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(698.9998!, 89.99998!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'Foto
        '
        Me.Foto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Foto]")})
        Me.Foto.LocationFloat = New DevExpress.Utils.PointFloat(557.9579!, 48.91666!)
        Me.Foto.Name = "Foto"
        Me.Foto.SizeF = New System.Drawing.SizeF(141.0419!, 155.0!)
        Me.Foto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.999973!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(700.0!, 45.91669!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Por medio del presente el Colegio de Ingenieros Civiles de Chiapas, A. C. Certifi" &
    "ca que el  Ingeniero:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrLabel16
        '
        Me.XrLabel16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Presidente]")})
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.001621246!, 448.4838!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(349.97!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "PRESIDENTE"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Secretario]")})
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(349.9717!, 448.4838!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(349.97!, 23.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UsePadding = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "SECRETARIO"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel19
        '
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sexo_secretario]")})
        Me.XrLabel19.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(349.9717!, 472.484!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(349.97!, 17.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COMISION_DRO]")})
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(0.001621246!, 555.6168!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(699.9985!, 18.83337!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "[FIRMA_COMISION_DRO]"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'VALIDO
        '
        Me.VALIDO.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.VALIDO.LocationFloat = New DevExpress.Utils.PointFloat(0!, 293.9167!)
        Me.VALIDO.Name = "VALIDO"
        Me.VALIDO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.VALIDO.SizeF = New System.Drawing.SizeF(698.9999!, 90.36105!)
        Me.VALIDO.StylePriority.UseFont = False
        Me.VALIDO.StylePriority.UseTextAlignment = False
        Me.VALIDO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.0!
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.Encabezado, Me.XrLabel1, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5})
        Me.PageHeader.HeightF = 272.0835!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FOLIO]")})
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Red
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 180.0417!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(487.5!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "FOLIO"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'Encabezado
        '
        Me.Encabezado.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("Encabezado.ImageSource"))
        Me.Encabezado.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.Encabezado.Name = "Encabezado"
        Me.Encabezado.SizeF = New System.Drawing.SizeF(700.0!, 100.0!)
        Me.Encabezado.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 15.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 100.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(700.0!, 78.7084!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "REGISTRO DE DIRECTORES                                                           " &
    "             RESPONSABLES DE OBRAS Y CORRESPONSABLE EN SEGURIDAD ESTRUCTURAL (CS" &
    "E)"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dirigido_A_Representante]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 203.0417!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(700.0001!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "DIRIGIDO A REPRESENTANTE"
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dirigido_A_Cargo]")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 226.0416!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(700.0001!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "DIRIGIDO A CARGO"
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dirigido_A_Domicilio]")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 249.0418!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(700.0001!, 23.00002!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "DIRIGIDO A DOMICILIO"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel15, Me.PIE_DE_PAGINA})
        Me.ReportFooter.HeightF = 92.42422!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.BorderColor = System.Drawing.Color.OliveDrab
        Me.XrLine1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.XrLine1.LineWidth = 3.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 37.08018!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(699.9399!, 3.125!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FRASE_COLEGIO]")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Italic, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 14.00001!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(699.9401!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "FRASE"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PIE_DE_PAGINA
        '
        Me.PIE_DE_PAGINA.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("PIE_DE_PAGINA.ImageSource"))
        Me.PIE_DE_PAGINA.LocationFloat = New DevExpress.Utils.PointFloat(148.6796!, 44.08012!)
        Me.PIE_DE_PAGINA.Name = "PIE_DE_PAGINA"
        Me.PIE_DE_PAGINA.SizeF = New System.Drawing.SizeF(349.2788!, 47.83972!)
        Me.PIE_DE_PAGINA.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'Folio
        '
        Me.Folio.Name = "Folio"
        Me.Folio.ValueInfo = "DRO/01553/2022"
        '
        'DataSet_pCARTA_IMPRIMIR1
        '
        Me.DataSet_pCARTA_IMPRIMIR1.DataSetName = "DataSet_pCARTA_IMPRIMIR"
        Me.DataSet_pCARTA_IMPRIMIR1.EnforceConstraints = False
        Me.DataSet_pCARTA_IMPRIMIR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCARTA_IMPRIMIRTableAdapter
        '
        Me.PCARTA_IMPRIMIRTableAdapter.ClearBeforeFill = True
        '
        'R_CARTA_DRO_CICCH
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCARTA_IMPRIMIR1})
        Me.DataAdapter = Me.PCARTA_IMPRIMIRTableAdapter
        Me.DataMember = "pCARTA_IMPRIMIR"
        Me.DataSource = Me.DataSet_pCARTA_IMPRIMIR1
        Me.Margins = New DevExpress.Drawing.DXMargins(65, 85, 25, 0)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Folio})
        Me.Version = "21.2"
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCARTA_IMPRIMIR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Private Sub R_CARTA_DRO_CACHAC_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        Try
            ReDim Utilidades.ParametersX_Global(1)
            Dim ultimoIndice As Integer = 0
            For n = 0 To Parameters.Count - 1
                If Not Parameters.Item(n).Value = "" Then
                    Utilidades.ParametersX_Global(n) = New SqlParameter("@" & Parameters.Item(n).Name, Parameters.Item(n).Value)
                    ultimoIndice += 1
                End If
            Next
            ''PARÁMETRO PARA QUE SOLO TRAIGA EL NOMBRE SIN LA ABREVIATURA DEL TÍTULO
            'Utilidades.ParametersX_Global(ultimoIndice) = New SqlParameter("@INCLUIR_ABREVIATURA_TITULO", 0)
            Utilidades.Llenar_Catalogos("pCARTA_IMPRIMIR", Me.DataSet_pCARTA_IMPRIMIR1, "", Utilidades.ParametersX_Global)

            'Utilidades.EstablecerImagenReporte(Foto, "Fotografias", GetCurrentColumnValue("ALUMNO_FOTOGRAFIA"))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub R_CARTA_DRO_CICCH_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        Try
            VALIDO.Text = GetCurrentColumnValue("Fecha_Completa_DRO")
            VALIDO.TextAlignment = TextAlignment.TopJustify
            XrRichText1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Catch ex As Exception

        End Try
    End Sub
End Class