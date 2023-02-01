﻿Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient
Public Class R_CARTAS_RTEC_CICCH
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

    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents Foto As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ENCABEZADO As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents PIE_DE_PAGINA As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Folio As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents VALIDO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText6 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataSet_pCARTA_IMPRIMIR1 As DataSet_pCARTA_IMPRIMIR
    Friend WithEvents PCARTA_IMPRIMIRTableAdapter As DataSet_pCARTA_IMPRIMIRTableAdapters.pCARTA_IMPRIMIRTableAdapter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_CARTAS_RTEC_CICCH))
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText6 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.VALIDO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.Foto = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PIE_DE_PAGINA = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ENCABEZADO = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Folio = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DataSet_pCARTA_IMPRIMIR1 = New SISCOL_Configuracion.DataSet_pCARTA_IMPRIMIR()
        Me.PCARTA_IMPRIMIRTableAdapter = New SISCOL_Configuracion.DataSet_pCARTA_IMPRIMIRTableAdapters.pCARTA_IMPRIMIRTableAdapter()
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCARTA_IMPRIMIR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel1, Me.XrRichText6, Me.XrRichText2, Me.VALIDO, Me.XrLabel6, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel14, Me.XrRichText1, Me.Foto, Me.XrRichText3, Me.XrRichText4, Me.XrRichText5, Me.XrBarCode1})
        Me.Detail.HeightF = 774.7623!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[En_Atencion_a_Cargo]")})
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 92.00016!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(323.9583!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "DIRIGIDO A DOMICILIO"
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[En_Atencion_a]")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 69.00016!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(323.9583!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "DIRIGIDO A DOMICILIO"
        '
        'XrRichText6
        '
        Me.XrRichText6.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText6.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 244.3336!)
        Me.XrRichText6.Name = "XrRichText6"
        Me.XrRichText6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrRichText6.SerializableRtfString = resources.GetString("XrRichText6.SerializableRtfString")
        Me.XrRichText6.SizeF = New System.Drawing.SizeF(506.6668!, 125.8752!)
        Me.XrRichText6.StylePriority.UsePadding = False
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(222.1875!, 736.1373!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(295.0002!, 38.62494!)
        Me.XrRichText2.StylePriority.UseFont = False
        '
        'VALIDO
        '
        Me.VALIDO.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.VALIDO.LocationFloat = New DevExpress.Utils.PointFloat(0!, 553.3829!)
        Me.VALIDO.Name = "VALIDO"
        Me.VALIDO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.VALIDO.SizeF = New System.Drawing.SizeF(694.9999!, 58.33313!)
        Me.VALIDO.StylePriority.UseFont = False
        '
        'XrLabel6
        '
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConsejoDirectivoAnio]")})
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 634.716!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(700.0!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "[ConsejoDirectivo]"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 611.716!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(700.0!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "ATENTAMENTE"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Dirigido_A_Representante])")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(699.9999!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "DIRIGIDO A REPRESENTANTE"
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UPPER([Dirigido_A_Cargo])")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 22.99994!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(699.9999!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "DIRIGIDO A CARGO"
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UPPER([Dirigido_A_Domicilio])")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.00016!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(699.9999!, 23.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "DIRIGIDO A DOMICILIO"
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 119.8112!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(699.9998!, 110.46!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'Foto
        '
        Me.Foto.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Foto]")})
        Me.Foto.LocationFloat = New DevExpress.Utils.PointFloat(561.65!, 230.2712!)
        Me.Foto.Name = "Foto"
        Me.Foto.SizeF = New System.Drawing.SizeF(128.35!, 154.0!)
        Me.Foto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrRichText3
        '
        Me.XrRichText3.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 384.2712!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(695.0!, 169.1117!)
        Me.XrRichText3.StylePriority.UseFont = False
        '
        'XrRichText4
        '
        Me.XrRichText4.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 668.6147!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(369.8864!, 38.62494!)
        Me.XrRichText4.StylePriority.UseFont = False
        '
        'XrRichText5
        '
        Me.XrRichText5.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(369.8862!, 668.6147!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(330.1136!, 38.62494!)
        Me.XrRichText5.StylePriority.UseFont = False
        '
        'XrBarCode1
        '
        Me.XrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FOLIO]")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(323.9583!, 69.00015!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(376.0417!, 39.44736!)
        Me.XrBarCode1.StylePriority.UsePadding = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator1
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PIE_DE_PAGINA, Me.XrLine1, Me.XrLabel15})
        Me.BottomMargin.HeightF = 85.25859!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PIE_DE_PAGINA
        '
        Me.PIE_DE_PAGINA.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("PIE_DE_PAGINA.ImageSource"))
        Me.PIE_DE_PAGINA.LocationFloat = New DevExpress.Utils.PointFloat(194.6799!, 37.41887!)
        Me.PIE_DE_PAGINA.Name = "PIE_DE_PAGINA"
        Me.PIE_DE_PAGINA.SizeF = New System.Drawing.SizeF(349.2788!, 47.83972!)
        Me.PIE_DE_PAGINA.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.BorderColor = System.Drawing.Color.OliveDrab
        Me.XrLine1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.XrLine1.LineWidth = 3.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001854367!, 22.99997!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(699.9996!, 3.125!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FRASE_COLEGIO]")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle), DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0001155969!, 0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(699.9999!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "FRASE"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ENCABEZADO, Me.XrLabel2})
        Me.PageHeader.HeightF = 114.5833!
        Me.PageHeader.Name = "PageHeader"
        '
        'ENCABEZADO
        '
        Me.ENCABEZADO.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("ENCABEZADO.ImageSource"))
        Me.ENCABEZADO.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ENCABEZADO.Name = "ENCABEZADO"
        Me.ENCABEZADO.SizeF = New System.Drawing.SizeF(699.9999!, 89.99999!)
        Me.ENCABEZADO.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001155969!, 89.99999!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(699.9999!, 22.99999!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "REGISTRO DE REPRESENTANTE TÉCNICO DE EMPRESA CONSTRUCTORA"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Folio
        '
        Me.Folio.Name = "Folio"
        Me.Folio.ValueInfo = "CICCH-3000 A 3999-10000-RTEC PRO 07002-1-2022"
        '
        'DataSet_pCARTA_IMPRIMIR1
        '
        Me.DataSet_pCARTA_IMPRIMIR1.DataSetName = "DataSet_pCARTA_IMPRIMIR"
        Me.DataSet_pCARTA_IMPRIMIR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCARTA_IMPRIMIRTableAdapter
        '
        Me.PCARTA_IMPRIMIRTableAdapter.ClearBeforeFill = True
        '
        'R_CARTAS_RTEC_CICCH
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCARTA_IMPRIMIR1})
        Me.DataAdapter = Me.PCARTA_IMPRIMIRTableAdapter
        Me.DataMember = "pCARTA_IMPRIMIR"
        Me.DataSource = Me.DataSet_pCARTA_IMPRIMIR1
        Me.Margins = New DevExpress.Drawing.DXMargins(65, 85, 25, 85)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Folio})
        Me.Version = "21.2"
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCARTA_IMPRIMIR1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Private Sub R_CARTA_DRO_CACHAC_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        ReDim Utilidades.ParametersX_Global(0)
        For n = 0 To Parameters.Count - 1
            If Not Parameters.Item(n).Value = "" Then
                Utilidades.ParametersX_Global(n) = New SqlParameter("@" & Parameters.Item(n).Name, Parameters.Item(n).Value)
            End If
        Next

        Utilidades.Llenar_Catalogos("pCARTA_IMPRIMIR", Me.DataSet_pCARTA_IMPRIMIR1, "", Utilidades.ParametersX_Global)
        'Utilidades.EstablecerImagenReporte(ENCABEZADO, "LOGOS\CICCH", GetCurrentColumnValue("ENCABEZADO_IMG_1"))
        'Utilidades.EstablecerImagenReporte(PIE_DE_PAGINA, "LOGOS\CICCH", GetCurrentColumnValue("PIE_PAGINA_IMG"))
        'Utilidades.EstablecerImagenReporte(Foto, "Fotografias", GetCurrentColumnValue("ALUMNO_FOTOGRAFIA"))
    End Sub



    Private Sub R_CARTAS_RTEC_CICCH_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        'VALIDO.Text = GetCurrentRow("TEXTO_FECHA_VALIDA")
        'VALIDO.TextAlignment = TextAlignment.TopJustify
        'XrRichText1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    End Sub
End Class