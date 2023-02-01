Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class R_CREDENCIAL_CACHACH
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
    'Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    'Friend WithEvents DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1 As DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS
    'Friend WithEvents DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2 As DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS
    'Friend WithEvents PCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter As DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapters.pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents Foto As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_CREDENCIAL_CACHACH))
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim Code39Generator1 As DevExpress.XtraPrinting.BarCode.Code39Generator = New DevExpress.XtraPrinting.BarCode.Code39Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.Foto = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        'Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        'Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1 = New iSISCOL.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS()
        'Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2 = New iSISCOL.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS()
        'Me.PCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter = New iSISCOL.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapters.pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrPanel2})
        Me.Detail.HeightF = 316.9328!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Foto, Me.XrPictureBox3, Me.XrRichText1, Me.XrRichText2, Me.XrPictureBox1})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(249.3257!, 316.9328!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'Foto
        '
        Me.Foto.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Foto.LocationFloat = New DevExpress.Utils.PointFloat(9.99999!, 79.54762!)
        Me.Foto.Name = "Foto"
        Me.Foto.SizeF = New System.Drawing.SizeF(82.18748!, 109.8055!)
        Me.Foto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.Foto.StylePriority.UseBorders = False
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(249.3257!, 79.54761!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox3.StylePriority.UseBorders = False
        '
        'XrRichText1
        '
        Me.XrRichText1.BackColor = System.Drawing.Color.Transparent
        Me.XrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrRichText1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText1.ForeColor = System.Drawing.Color.Transparent
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(103.4722!, 79.54762!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(145.8535!, 131.7006!)
        Me.XrRichText1.StylePriority.UseBackColor = False
        Me.XrRichText1.StylePriority.UseBorders = False
        Me.XrRichText1.StylePriority.UseForeColor = False
        '
        'XrRichText2
        '
        Me.XrRichText2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrRichText2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 211.2482!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(148.3631!, 105.6846!)
        Me.XrRichText2.StylePriority.UseBorders = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(148.3631!, 211.2482!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(97.49037!, 105.6846!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrPictureBox4, Me.XrRichText4, Me.XrPictureBox2, Me.XrRichText5, Me.XrBarCode2, Me.XrRichText3})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(249.3257!, 0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(251.3889!, 316.9328!)
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrBarCode1
        '
        Me.XrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.BorderColor = System.Drawing.Color.Black
        Me.XrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907348!, 79.54762!)
        Me.XrBarCode1.Module = 5.0!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(113.1944!, 106.7006!)
        Me.XrBarCode1.StylePriority.UseBorderColor = False
        Me.XrBarCode1.StylePriority.UseBorders = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        QrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.[Byte]
        Me.XrBarCode1.Symbology = QrCodeGenerator1
        Me.XrBarCode1.Text = "http://cachac.dnsdojo.com/socios/principal.aspx"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"), System.Drawing.Image)
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(153.1945!, 79.54762!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(88.1944!, 58.25792!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox4.StylePriority.UseBorders = False
        '
        'XrRichText4
        '
        Me.XrRichText4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrRichText4.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 137.8055!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(241.3888!, 70.22221!)
        Me.XrRichText4.StylePriority.UseBorders = False
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(45.80275!, 197.6111!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(157.4142!, 42.97229!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox2.StylePriority.UseBorders = False
        '
        'XrRichText5
        '
        Me.XrRichText5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrRichText5.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 240.5833!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(251.3888!, 13.97223!)
        Me.XrRichText5.StylePriority.UseBorders = False
        '
        'XrBarCode2
        '
        Me.XrBarCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        Me.XrBarCode2.AutoModule = True
        Me.XrBarCode2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrBarCode2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ALUMNO_CLAVE_AGREMIADO]")})
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 254.5556!)
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode2.ShowText = False
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(251.3888!, 42.04366!)
        Me.XrBarCode2.StylePriority.UseBorders = False
        Me.XrBarCode2.StylePriority.UseTextAlignment = False
        Code39Generator1.CalcCheckSum = False
        Code39Generator1.WideNarrowRatio = 3.0!
        Me.XrBarCode2.Symbology = Code39Generator1
        Me.XrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrRichText3
        '
        Me.XrRichText3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrRichText3.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75!)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(251.3888!, 79.54762!)
        Me.XrRichText3.StylePriority.UseBorders = False
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 17.70833!
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
        'C1DataViewSet1
        '
        'Me.C1DataViewSet1.DiagramXML = ""
        '
        'DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1
        '
        'Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1.DataSetName = "DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS"
        'Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2
        '
        'Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2.DataSetName = "DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS"
        'Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter
        '
        'Me.PCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter.ClearBeforeFill = True
        '
        'R_CREDENCIAL_CACHACH
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        'Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1, Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2})
        'Me.DataAdapter = Me.PCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOSTableAdapter
        Me.DataMember = "pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS"
        'Me.DataSource = Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1
        Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 18, 0)
        Me.ShowPrintMarginsWarning = False
        Me.Version = "17.2"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Private Sub R_Membresia_DataSourceDemanded(sender As Object, e As EventArgs) Handles Me.DataSourceDemanded
        If Application.Session("XDATASET") = "SI" Then
            Me.DataSource = Application.Session("ds")
            Application.Session("ds") = ""
            Application.Session("XDATASET") = ""
            '   Else
            'DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1.Clear()
            'Dim myDA = New SqlDataAdapter("pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS", Utilidades.sConexion)
            'myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            'For n = 0 To Parameters.Count - 1
            '    myDA.SelectCommand.Parameters.AddWithValue("@" & Parameters.Item(n).Name, Parameters.Item(n).Value)
            'Next

            'myDA.Fill(DataSet_pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS1.pCARTA_NO_ELABORADAS_SOCIOS_NUMERARIOS)
            'myDA.Dispose()
        End If
        'If GetCurrentColumnValue("ALUMNO_FOTO").ToString <> "NA" Then
        '    Dim ImagenPieDePagina = New Bitmap(HttpContext.Current.Server.MapPath("~/Resources/Images/Fotografias/CACHAC/") & (GetCurrentColumnValue("ALUMNO_FOTO").ToString).ToString.Replace("._", "\"), True)
        '    Foto.Image = ImagenPieDePagina
        'End If
    End Sub

    Private Sub R_CREDENCIAL_CACHACH_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        'XrBarCode2.Text = GetCurrentColumnValue("ALUMNO_CLAVE_AGREMIADO")
    End Sub

    Private Sub R_CREDENCIAL_CACHACH_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        If GetCurrentColumnValue("ALUMNO_FOTO").ToString <> "NA" Then
            Dim ImagenPieDePagina = New Bitmap(HttpContext.Current.Server.MapPath("~/Resources/Images/Fotografias/CACHAC/") & (GetCurrentColumnValue("ALUMNO_FOTO").ToString).ToString.Replace("._", "\"), True)
            Foto.Image = ImagenPieDePagina
        End If
        XrBarCode2.Text = GetCurrentColumnValue("ALUMNO_CLAVE_AGREMIADO")
    End Sub

    Private Sub R_CREDENCIAL_CACHACH_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint
        ' XrBarCode2.Text = GetCurrentColumnValue("ALUMNO_CLAVE_AGREMIADO")
    End Sub
End Class