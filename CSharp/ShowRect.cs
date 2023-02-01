using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;








namespace FrostSteelCorporation.CSharp
{
    public class ShowRect
    {

       

       


        public static void ShowRectum(PaintEventArgs e) {

          
            Pen blackPen = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(0, 0, 200, 200);
            e.Graphics.DrawRectangle(blackPen, rect);




        }




    }
}
