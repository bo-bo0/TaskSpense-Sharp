using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseAndTaskManager;

namespace PersonalExpenseAndTaskManager
{
    internal abstract class Graphics
    {
        public static float[] Scale(Rectangle controlRectangle, Control control, int originalWidth, int originalHeight)
        {
            if (ExpensesForm.ActiveForm != null)
            {

                float xRatio = (float)ExpensesForm.ActiveForm.Width / (float)originalWidth;
                float yRatio = (float)ExpensesForm.ActiveForm.Height / (float)originalHeight;

                int newX = (int)(controlRectangle.X * xRatio);
                int newY = (int)(controlRectangle.Y * yRatio);

                int newW = (int)(controlRectangle.Width * xRatio);


                control.Location = new Point(newX, newY);
                control.Size = new Size(newW, controlRectangle.Height);

                return new float[] { newX, newY, newW, xRatio, yRatio };
            }

            return new float[] { -1, -1, -1, -1 };

        }

        public static FormWindowState screenSet(FormWindowState ws)
        {
            if (ws != FormWindowState.Maximized)
                ws = FormWindowState.Maximized;
            else
                ws = FormWindowState.Normal;

            return ws;
        }
    
    }
}
