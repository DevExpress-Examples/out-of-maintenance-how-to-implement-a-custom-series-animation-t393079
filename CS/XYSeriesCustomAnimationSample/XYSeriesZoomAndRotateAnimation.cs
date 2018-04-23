using DevExpress.XtraCharts;
using System.Drawing;

namespace XYSeriesCustomAnimationSample {
    class XYSeriesRotateAndZoomAnimation : XYSeriesAnimationBase {
        const int defaultRotationCount = 1;

        int rotationCount = defaultRotationCount;
        public int RotationCount {
            get { return rotationCount; }
            set { rotationCount = value; }
        }

        public override void ApplyState(SceneModifier modifier, Rectangle diagramBounds, float progress) {
            float currentWidth = diagramBounds.Width * progress;
            float currentHeight = diagramBounds.Height * progress;

            float diagramCenterX = diagramBounds.X + diagramBounds.Width / 2.0f;
            float diagramCenterY = diagramBounds.Y + diagramBounds.Height / 2.0f;

            float dx = (currentWidth - diagramBounds.Width) / 2;
            float dy = (currentHeight - diagramBounds.Height) / 2;

            modifier.Translate(-dx, -dy);
            modifier.Scale(progress, progress);

            modifier.Translate(diagramCenterX, diagramCenterY);
            modifier.Rotate(progress * 360 * RotationCount);
            modifier.Translate(-diagramCenterX, -diagramCenterY);
        }

        protected override ChartElement CreateObjectForClone() {
            return new XYSeriesRotateAndZoomAnimation();
        }
    }
}
