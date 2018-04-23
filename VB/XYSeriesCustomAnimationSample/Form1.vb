Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace XYSeriesCustomAnimationSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler chartControl1.DoubleClick, AddressOf OnDoubleClick

            Dim series As Series = chartControl1.Series("Europe")
            If series Is Nothing Then
                Return
            End If
            Dim view As LineSeriesView = TryCast(series.View, LineSeriesView)
            If view Is Nothing Then
                Return
            End If
            view.SeriesAnimation = New XYSeriesRotateAndZoomAnimation With {.RotationCount = 1}
        End Sub

        Private Overloads Sub OnDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            chartControl1.Animate()
        End Sub
    End Class
End Namespace
