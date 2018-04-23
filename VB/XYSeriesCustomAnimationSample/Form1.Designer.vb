Namespace XYSeriesCustomAnimationSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (DirectCast(546R, Object))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (DirectCast(605R, Object))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (DirectCast(656R, Object))})
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (DirectCast(694R, Object))})
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (DirectCast(721R, Object))})
            Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (DirectCast(730R, Object))})
            Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (DirectCast(728R, Object))})
            Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (DirectCast(721R, Object))})
            Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (DirectCast(704R, Object))})
            Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (DirectCast(680R, Object))})
            Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (DirectCast(650R, Object))})
            Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartControl1.DataBindings = Nothing
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chartControl1.Diagram = xyDiagram2
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series2.Name = "Europe"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22})
            series2.View = lineSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
            Me.chartControl1.Size = New System.Drawing.Size(624, 321)
            Me.chartControl1.TabIndex = 0
            chartTitle2.Text = "Historic, current and future population"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

