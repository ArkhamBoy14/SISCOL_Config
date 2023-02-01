Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.SqlClient


Public Class R_CARTA_SUPERVISION_CACHAC
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
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Foto As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PIE_DE_PAGINA As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VALIDO As DevExpress.XtraReports.UI.XRLabel
    'Friend WithEvents DataSet_pCARTAS_IMPRIMIR_B1 As DataSet_pCARTAS_IMPRIMIR_B
    'Friend WithEvents PCARTAS_IMPRIMIR_BTableAdapter As DataSet_pCARTAS_IMPRIMIR_BTableAdapters.pCARTAS_IMPRIMIR_BTableAdapter
    Friend WithEvents CVE_FOLIO_CARTA As DevExpress.XtraReports.Parameters.Parameter
    Public WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ENCABEZADO As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_CARTA_SUPERVISION_CACHAC))
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.VALIDO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Foto = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.ENCABEZADO = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PIE_DE_PAGINA = New DevExpress.XtraReports.UI.XRPictureBox()
        'Me.DataSet_pCARTAS_IMPRIMIR_B1 = New iSISCOL.DataSet_pCARTAS_IMPRIMIR_B()
        'Me.PCARTAS_IMPRIMIR_BTableAdapter = New iSISCOL.DataSet_pCARTAS_IMPRIMIR_BTableAdapters.pCARTAS_IMPRIMIR_BTableAdapter()
        Me.CVE_FOLIO_CARTA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DataSet_pCARTAS_IMPRIMIR_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText2, Me.VALIDO, Me.XrLabel5, Me.XrRichText3, Me.XrLabel2, Me.XrRichText4, Me.XrRichText5, Me.XrRichText1, Me.XrLabel4, Me.XrLabel14, Me.XrLabel15, Me.Foto})
        Me.Detail.HeightF = 685.2307!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(0.0005722046!, 143.2614!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(506.6668!, 125.8752!)
        Me.XrRichText2.StylePriority.UsePadding = False
        '
        'VALIDO
        '
        Me.VALIDO.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!)
        Me.VALIDO.LocationFloat = New DevExpress.Utils.PointFloat(0!, 452.3107!)
        Me.VALIDO.Name = "VALIDO"
        Me.VALIDO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.VALIDO.SizeF = New System.Drawing.SizeF(650.0005!, 38.02777!)
        Me.VALIDO.StylePriority.UseFont = False
        Me.VALIDO.StylePriority.UseTextAlignment = False
        Me.VALIDO.Text = "[TEXTO_FECHA_VALIDA]"
        Me.VALIDO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UPPER([RESPONSABLE_CARGO])")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 20.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "DIRIGIDO A CARGO"
        '
        'XrRichText3
        '
        Me.XrRichText3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 283.199!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(649.9997!, 169.1117!)
        Me.XrRichText3.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(242.7086!, 490.3385!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(164.5833!, 15.33636!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ATENTAMENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrRichText4
        '
        Me.XrRichText4.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.0!)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 635.3494!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(325.0!, 38.62!)
        Me.XrRichText4.StylePriority.UseFont = False
        '
        'XrRichText5
        '
        Me.XrRichText5.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.0!)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(324.9998!, 635.3494!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(325.0!, 38.62!)
        Me.XrRichText5.StylePriority.UseFont = False
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001956255!, 91.19884!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(650.0!, 38.0!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([RESPONSABLE_NOMBRE])")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.00003306071!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "DIRIGIDO A REPRESENTANTE"
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UPPER([RESPONSABLE_DIRECCION])")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 40.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "DIRIGIDO A DOMICILIO"
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 60.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "PRESENTE"
        '
        'Foto
        '
        Me.Foto.LocationFloat = New DevExpress.Utils.PointFloat(521.6483!, 129.1988!)
        Me.Foto.Name = "Foto"
        Me.Foto.SizeF = New System.Drawing.SizeF(128.3522!, 154.0002!)
        Me.Foto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel6, Me.XrLabel3, Me.XrBarCode1, Me.ENCABEZADO})
        Me.TopMargin.HeightF = 229.9291!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ENCABEZADO
        '
        Me.ENCABEZADO.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.BottomRight
        Me.ENCABEZADO.LocationFloat = New DevExpress.Utils.PointFloat(503.0005!, 0!)
        Me.ENCABEZADO.Name = "ENCABEZADO"
        Me.ENCABEZADO.SizeF = New System.Drawing.SizeF(147.0!, 164.0!)
        Me.ENCABEZADO.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(299.9998!, 205.75!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(62.70834!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "FOLIO"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FOLIO]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Red
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(362.7081!, 205.75!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(286.2496!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "FOLIO"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FOLIO]")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(299.9998!, 164.0!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(348.9584!, 41.75002!)
        Me.XrBarCode1.StyleName = "XrControlStyle1"
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode1.Symbology = Code128Generator1
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(118.7498!, 115.5834!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(412.5005!, 48.41664!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Representante Técnico de Empresa Supervisora " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registro de Empresa  [CARTAS_FECHA" &
    "_ANO]"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PIE_DE_PAGINA})
        Me.BottomMargin.HeightF = 111.1595!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PIE_DE_PAGINA
        '
        Me.PIE_DE_PAGINA.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleRight
        Me.PIE_DE_PAGINA.LocationFloat = New DevExpress.Utils.PointFloat(392.0005!, 0!)
        Me.PIE_DE_PAGINA.Name = "PIE_DE_PAGINA"
        Me.PIE_DE_PAGINA.SizeF = New System.Drawing.SizeF(258.0!, 107.0!)
        Me.PIE_DE_PAGINA.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'DataSet_pCARTAS_IMPRIMIR_B1
        '
        'Me.DataSet_pCARTAS_IMPRIMIR_B1.DataSetName = "DataSet_pCARTAS_IMPRIMIR_B"
        'Me.DataSet_pCARTAS_IMPRIMIR_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCARTAS_IMPRIMIR_BTableAdapter
        '
        'Me.PCARTAS_IMPRIMIR_BTableAdapter.ClearBeforeFill = True
        '
        'CVE_FOLIO_CARTA
        '
        Me.CVE_FOLIO_CARTA.Name = "CVE_FOLIO_CARTA"
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrControlStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'R_CARTA_SUPERVISION_CACHAC
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        'Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCARTAS_IMPRIMIR_B1})
        'Me.DataAdapter = Me.PCARTAS_IMPRIMIR_BTableAdapter
        Me.DataMember = "pCARTAS_IMPRIMIR_B"
        'Me.DataSource = Me.DataSet_pCARTAS_IMPRIMIR_B1
        Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 230, 111)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.CVE_FOLIO_CARTA})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "17.2"
        Me.Watermark.Image = CType(resources.GetObject("R_CARTA_SUPERVISION_CACHAC.Watermark.Image"), System.Drawing.Image)
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DataSet_pCARTAS_IMPRIMIR_B1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Private Sub R_CARTA_DRO_CACHAC_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        ReDim Utilidades.ParametersX_Global(5)
        Dim ultimoIndice As Integer = 0
        For n = 0 To Parameters.Count - 1
            If Not Parameters.Item(n).Value = "" Then
                Utilidades.ParametersX_Global(n) = New SqlParameter("@" & Parameters.Item(n).Name, Parameters.Item(n).Value)
                ultimoIndice += 1
            End If
        Next
        Utilidades.ParametersX_Global(ultimoIndice) = New SqlParameter("@INCLUIR_ABREVIATURA_TITULO", 0)
        'Utilidades.Llenar_Catalogos("pCARTAS_IMPRIMIR_B", Me.DataSet_pCARTAS_IMPRIMIR_B1, "", Utilidades.ParametersX_Global)

        'XrBarCode1.Text = GetCurrentColumnValue("FOLIO")
    End Sub

    Private Sub R_CARTA_SUPERVISION_CACHAC_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        VALIDO.Text = GetCurrentRow("TEXTO_FECHA_VALIDA")
        'VALIDO.TextAlignment = TextAlignment.TopJustify
        'XrRichText1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Utilidades.EstablecerImagenReporte(ENCABEZADO, "LOGOS", GetCurrentColumnValue("ENCABEZADO_IMG_1"))
        'Utilidades.EstablecerImagenReporte(PIE_DE_PAGINA, "LOGOS", GetCurrentColumnValue("PIE_PAGINA_IMG"))
        'Utilidades.EstablecerImagenReporte(Foto, "Fotografias", GetCurrentColumnValue("ALUMNO_FOTOGRAFIA"))
    End Sub
End Class