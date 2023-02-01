using System;
using System.Drawing;
using Blazor.Extensions.Canvas.Canvas2D;
using FrostSteelCorporation.Index;
using FrostSteelCorporation.Index.Models;

namespace FrostSteelCorporation.Index
{
    public class IndexBezierCurveService
    {
        public IndexBezierCurveService()
        {
        }

        public async void DrawCurve(Canvas2DContext context, IndexBezierCurve curve2)
        {
            await context.SetLineWidthAsync(3);
            await context.BeginPathAsync();
            await context.MoveToAsync(curve2.indexStartPoint.X, curve2.indexStartPoint.Y);
            await context.BezierCurveToAsync(curve2.indexControlPoint1.X, curve2.indexControlPoint1.Y, curve2.indexControlPoint2.X, curve2.indexControlPoint2.Y, curve2.indexEndPoint.X, curve2.indexEndPoint.Y);
            await context.SetStrokeStyleAsync("Yellow");
            await context.StrokeAsync();
        }

        public PointF getCubicBezierXYatPercent(IndexBezierCurve curve2, float percent)
        {

            percent = percent / 100;

            var x = CubicN(percent, curve2.indexStartPoint.X, curve2.indexControlPoint1.X, curve2.indexControlPoint2.X, curve2.indexEndPoint.X);
            var y = CubicN(percent, curve2.indexStartPoint.Y, curve2.indexControlPoint1.Y, curve2.indexControlPoint2.Y, curve2.indexEndPoint.Y);

            return new PointF(x, y);
        }

        // cubic helper formula at percent distance
        private static float CubicN(float percent, float a, float b, float c, float d)
        {
            var t2 = percent * percent;
            var t3 = t2 * percent;
            return a + (-a * 3 + percent * (3 * a - a * percent)) * percent + (3 * b + percent * (-6 * b + b * 3 * percent)) * percent + (c * 3 - c * 3 * percent) * t2 + d * t3;
        }
    }
}