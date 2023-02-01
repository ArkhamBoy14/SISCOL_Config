Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraPrinting
Imports System.Data
Imports System.Data.SqlClient

Public Class R_CARTA_RTEC_CACHAC
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
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents Foto As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents VALIDO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Folio As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents DataSet_pCARTA_IMPRIMIR1 As DataSet_pCARTA_IMPRIMIR
    Friend WithEvents PCARTA_IMPRIMIRTableAdapter As DataSet_pCARTA_IMPRIMIRTableAdapters.pCARTA_IMPRIMIRTableAdapter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_CARTA_RTEC_CACHAC))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.Foto = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.VALIDO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Folio = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.DataSet_pCARTA_IMPRIMIR1 = New SISCOL_Configuracion.DataSet_pCARTA_IMPRIMIR()
        Me.PCARTA_IMPRIMIRTableAdapter = New SISCOL_Configuracion.DataSet_pCARTA_IMPRIMIRTableAdapters.pCARTA_IMPRIMIRTableAdapter()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCARTA_IMPRIMIR1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText2, Me.XrLabel15, Me.XrLabel5, Me.XrLabel4, Me.XrLabel14, Me.XrRichText5, Me.XrRichText3, Me.Foto, Me.XrRichText1, Me.XrLabel1, Me.VALIDO, Me.XrRichText4, Me.XrLabel13})
        Me.Detail.HeightF = 708.6949!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(29.16667!, 190.46!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(506.6668!, 133.781!)
        Me.XrRichText2.StylePriority.UsePadding = False
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(29.16659!, 60.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "PRESENTE"
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UPPER([RESPONSABLE_CARGO])")})
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(29.16659!, 19.99999!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "DIRIGIDO A CARGO"
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([RESPONSABLE_NOMBRE])")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(29.16659!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "DIRIGIDO A REPRESENTANTE"
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UPPER([RESPONSABLE_DIRECCION])")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("Arial", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(29.16659!, 40.00001!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(650.0!, 20.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "DIRIGIDO A DOMICILIO"
        '
        'XrRichText5
        '
        Me.XrRichText5.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(379.1669!, 580.1028!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(300.0!, 38.62!)
        Me.XrRichText5.StylePriority.UseFont = False
        '
        'XrRichText3
        '
        Me.XrRichText3.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(29.16675!, 324.241!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(649.9999!, 169.1117!)
        Me.XrRichText3.StylePriority.UseFont = False
        '
        'Foto
        '
        Me.Foto.LocationFloat = New DevExpress.Utils.PointFloat(560.4584!, 190.46!)
        Me.Foto.Name = "Foto"
        Me.Foto.SizeF = New System.Drawing.SizeF(118.7082!, 133.781!)
        Me.Foto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(29.16667!, 79.99999!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(649.9999!, 110.46!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(271.8752!, 520.4361!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(164.5833!, 17.6615!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "ATENTAMENTE"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'VALIDO
        '
        Me.VALIDO.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.VALIDO.LocationFloat = New DevExpress.Utils.PointFloat(29.16671!, 495.3527!)
        Me.VALIDO.Name = "VALIDO"
        Me.VALIDO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.VALIDO.SizeF = New System.Drawing.SizeF(650.0001!, 25.08331!)
        Me.VALIDO.StylePriority.UseFont = False
        Me.VALIDO.StylePriority.UseTextAlignment = False
        Me.VALIDO.Text = "VALIDO"
        Me.VALIDO.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrRichText4
        '
        Me.XrRichText4.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(29.16667!, 580.1027!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(300.0!, 38.62!)
        Me.XrRichText4.StylePriority.UseFont = False
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(203.1249!, 669.5315!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(300.0!, 37.58!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "[FIRMA_COMISION_RTEC]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REVISÓ COMISIÓN DE RTEC"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel3, Me.XrLabel2, Me.XrLabel6})
        Me.TopMargin.HeightF = 178.2417!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FOLIO]")})
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Red
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(232.2917!, 165.6583!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(417.7083!, 12.58334!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "FOLIO"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Arial", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(173.9583!, 165.6583!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(58.33334!, 12.58334!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "FOLIO"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Arial", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 118.7!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(450.0!, 46.95832!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "CONSTANCIA DE REPRESENTANTE TÉCNICO PARA EMPRESA CONSTRUCTORA 2019"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Folio
        '
        Me.Folio.Name = "Folio"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(95.3!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(459.4!, 118.7!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrPictureBox3, Me.XrPictureBox5, Me.XrPictureBox4, Me.XrPictureBox6})
        Me.ReportFooter.HeightF = 103.5!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox2.ImageSource"))
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(341.2!, 103.5!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox3.ImageSource"))
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(370.4166!, 18.95!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(75.0!, 65.6!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox5
        '
        Me.XrPictureBox5.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox5.ImageSource"))
        Me.XrPictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(458.3334!, 18.95!)
        Me.XrPictureBox5.Name = "XrPictureBox5"
        Me.XrPictureBox5.SizeF = New System.Drawing.SizeF(75.0!, 65.6!)
        Me.XrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox4.ImageSource"))
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(553.1251!, 18.95!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(75.0!, 65.6!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox6.ImageSource"))
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(646.6082!, 18.95002!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(75.0!, 65.6!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
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
        'R_CARTA_RTEC_CACHAC
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCARTA_IMPRIMIR1})
        Me.DataAdapter = Me.PCARTA_IMPRIMIRTableAdapter
        Me.DataMember = "pCARTA_IMPRIMIR"
        Me.DataSource = Me.DataSet_pCARTA_IMPRIMIR1
        Me.Font = New DevExpress.Drawing.DXFont("Arial Narrow", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Margins = New DevExpress.Drawing.DXMargins(100.0!, 26.0!, 178.2417!, 0!)
        Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.Folio, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Folio})
        Me.Version = "22.2"
        Me.Watermark.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("R_CARTA_RTEC_CACHAC.Watermark.ImageSource"))
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCARTA_IMPRIMIR1, System.ComponentModel.ISupportInitialize).EndInit()
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
        'Utilidades.ParametersX_Global(ultimoIndice) = New SqlParameter("@INCLUIR_ABREVIATURA_TITULO", 0)
        Utilidades.Llenar_Catalogos("pCARTA_IMPRIMIR1", Me.DataSet_pCARTA_IMPRIMIR1, "", Utilidades.ParametersX_Global)

    End Sub


    Private Sub R_CARTA_RTEC_CACHACvb_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        'VALIDO.Text = GetCurrentRow("TEXTO_FECHA_VALIDA")
        'VALIDO.TextAlignment = TextAlignment.TopJustify
        'XrRichText1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        'Utilidades.EstablecerImagenReporte(ENCABEZADO, "LOGOS", GetCurrentColumnValue("ENCABEZADO_IMG_1"))
        'Utilidades.EstablecerImagenReporte(PIE_DE_PAGINA, "LOGOS", GetCurrentColumnValue("PIE_PAGINA_IMG"))
        'Utilidades.EstablecerImagenReporte(Foto, "Fotografias", GetCurrentColumnValue("ALUMNO_FOTOGRAFIA"))
    End Sub

    Private Sub XrRichText2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrRichText2.BeforePrint

        'Dim docServer As New RichEditDocumentServer()
        'docServer.Document.DefaultParagraphProperties.LineSpacing = ParagraphLineSpacing.Single


    End Sub
End Class