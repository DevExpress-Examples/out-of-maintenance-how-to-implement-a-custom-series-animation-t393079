using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace XYSeriesCustomAnimationSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            chartControl1.DoubleClick += OnDoubleClick;

            Series series = chartControl1.Series["Europe"];
            if(series == null) return;
            LineSeriesView view = series.View as LineSeriesView;
            if(view == null) return;
            view.SeriesAnimation = new XYSeriesRotateAndZoomAnimation { RotationCount = 1 };
        }

        private void OnDoubleClick(object sender, EventArgs e) {
            chartControl1.Animate();
        }
    }
}
