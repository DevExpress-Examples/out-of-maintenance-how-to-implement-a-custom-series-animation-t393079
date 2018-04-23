Imports DevExpress.XtraCharts
Imports System.Drawing

Namespace XYSeriesCustomAnimationSample
    Friend Class XYSeriesRotateAndZoomAnimation
        Inherits XYSeriesAnimationBase

        Private Const defaultRotationCount As Integer = 1


        Private rotationCount_Renamed As Integer = defaultRotationCount
        Public Property RotationCount() As Integer
            Get
                Return rotationCount_Renamed
            End Get
            Set(ByVal value As Integer)
                rotationCount_Renamed = value
            End Set
        End Property

        Public Overrides Sub ApplyState(ByVal modifier As SceneModifier, ByVal diagramBounds As Rectangle, ByVal progress As Single)
            Dim currentWidth As Single = diagramBounds.Width * progress
            Dim currentHeight As Single = diagramBounds.Height * progress

            Dim diagramCenterX As Single = diagramBounds.X + diagramBounds.Width / 2.0F
            Dim diagramCenterY As Single = diagramBounds.Y + diagramBounds.Height / 2.0F

            Dim dx As Single = (currentWidth - diagramBounds.Width) / 2
            Dim dy As Single = (currentHeight - diagramBounds.Height) / 2

            modifier.Translate(-dx, -dy)
            modifier.Scale(progress, progress)

            modifier.Translate(diagramCenterX, diagramCenterY)
            modifier.Rotate(progress * 360 * RotationCount)
            modifier.Translate(-diagramCenterX, -diagramCenterY)
        End Sub

        Protected Overrides Function CreateObjectForClone() As ChartElement
            Return New XYSeriesRotateAndZoomAnimation()
        End Function
    End Class
End Namespace
