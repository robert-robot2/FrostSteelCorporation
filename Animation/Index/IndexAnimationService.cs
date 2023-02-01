

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Extensions.Canvas.Canvas2D;

using FrostSteelCorporation.Index.Models;









namespace FrostSteelCorporation.Index
{
    public class IndexAnimationService
    {

        private readonly IndexBezierCurveService indexbezierCurveService;
        private readonly IndexService indexService;

        public IndexAnimationService(IServiceProvider serviceProvider)
        {
            indexbezierCurveService = (IndexBezierCurveService)serviceProvider.GetService(typeof(IndexBezierCurveService));
            indexService = (IndexService)serviceProvider.GetService(typeof(IndexService));
        }

        public void Animate(IndexAnimation animations)
        {
            animations.indexPercent += animations.indexSpeed;

            if (animations.indexPercent < 0)
                animations.indexPercent = 0;
            else if (animations.indexPercent > 100)
                animations.indexPercent = 100;

        }

        public void Draw(Canvas2DContext context, IndexAnimation animations)
        {
            foreach (IndexWords words in animations.indexWords)
            {
                if (words.indexPath!= null)
                {
                    {
                        words.indexLocation = indexbezierCurveService.getCubicBezierXYatPercent(words.indexPath, animations.indexPercent);
                        if (words.indexDrawPath) indexbezierCurveService.DrawCurve(context, words.indexPath);
                    }
                }
                indexService.DrawText(context, words);
                
            }
        }











    }
}
