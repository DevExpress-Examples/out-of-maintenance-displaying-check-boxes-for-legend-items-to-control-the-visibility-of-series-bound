using DevExpress.Xpf.Charts;
using System.Windows.Media;

namespace CheckBoxesInLegendExample_BoundMode {
    
    class SeriesNonVisualWrapper {

        public Series Series { 
            get; 
            set; 
        }
        public Brush MarkerBrush {
            get;
            set;
        }
        public Brush MarkerLineBrush {
            get;
            set;
        }

        // This property is bound to legend marker template.
        public DevExpress.Xpf.Charts.LineStyle MarkerLineStyle { 
            get; 
            set; 
        }

        public SeriesNonVisualWrapper(Series series, Brush markerBrush) {
            Series = series;
            MarkerBrush = markerBrush;
            MarkerLineStyle = new DevExpress.Xpf.Charts.LineStyle(1);
            MarkerLineBrush = markerBrush;
        }
    }
}