

using System;
using Blazor.Extensions.Canvas.Canvas2D;
using FrostSteelCorporation.Index.Models;


namespace FrostSteelCorporation.Index
{
    public class IndexService
    {


        public async void DrawText(Canvas2DContext context, IndexWords words)
        {
           
            await context.SetFillStyleAsync(words.indexColor);
            await context.SetFontAsync(words.indexFont);
            await context.FillTextAsync(words.indexTextString, words.indexLocation.X, words.indexLocation.Y);
            await context.RestoreAsync();
        }






    }
}
