using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace subtool
{
    public static class DrawPattern
    {
        public static void drawBackground(Bitmap bitmap, Color c1)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(c1);
            g.Dispose();
        }

        public static void drawVerticalStripe(Bitmap bitmap, Color c1, Color c2, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            int rectWidth = (int)(bitmap.Width / (20.0 + 10.0 * rdm.NextDouble()));
            int rectHeight = bitmap.Height;
            int xInterval = rectWidth * 2;
            int yInterval = rectHeight;

            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(c1);

            for (int x = (int)(xInterval * (rdm.NextDouble() - 0.5)); x < bitmap.Width; x += xInterval)
            {
                for (int y = 0; y < bitmap.Height; y += yInterval)
                {
                    g.FillRectangle(new SolidBrush(c2), x, y, rectWidth, rectHeight);
                }
            }
            g.Dispose();
        }

        public static void drawHorizontalStripe(Bitmap bitmap, Color c1, Color c2, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            int rectWidth = bitmap.Width;
            int rectHeight = (int)(bitmap.Height / (20.0 + 10.0 * rdm.NextDouble()));
            int xInterval = rectWidth;
            int yInterval = rectHeight * 2;

            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(c1);

            for (int y = (int)(yInterval * (rdm.NextDouble() - 0.5)); y < bitmap.Height; y += yInterval)
            {
                for (int x = 0; x < bitmap.Width; x += xInterval)
                {
                    g.FillRectangle(new SolidBrush(c2), x, y, rectWidth, rectHeight);
                }
            }
            g.Dispose();
        }


        public static string drawCircle(int classID, Bitmap bitmap, Color c1, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            int diameter = (int)(bitmap.Width / (5.0 + 5.0 * rdm.NextDouble()));
            float xr = (float)rdm.NextDouble();
            float yr = (float)rdm.NextDouble();
            int x = (int)(xr * (bitmap.Width - diameter));
            int y = (int)(yr * (bitmap.Height - diameter));

            Graphics g = Graphics.FromImage(bitmap);

            using (Brush b = new SolidBrush(c1))
            {
                g.FillEllipse(b, x, y, diameter, diameter);
            }

            g.Dispose();

            float centerX = (x + diameter / 2) / (float)bitmap.Width;
            float centerY = (y + diameter / 2) / (float)bitmap.Height;
            float borderWidth = diameter / (float)bitmap.Width;
            float borderHeight = diameter / (float)bitmap.Height;

            return $"{classID} {centerX} {centerY} {borderWidth} {borderHeight}";
        }



        public static void drawCircle(Bitmap bitmap1, Bitmap bitmap2, Color c1, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            int diameter = (int)(bitmap1.Width / (5.0 + 5.0 * rdm.NextDouble()));
            float xr = (float)rdm.NextDouble();
            float yr = (float)rdm.NextDouble();
            int x = (int)(xr * (bitmap1.Width - diameter));
            int y = (int)(yr * (bitmap1.Height - diameter));

            Graphics g1 = Graphics.FromImage(bitmap1);
            Graphics g2 = Graphics.FromImage(bitmap2);

            using (Brush b = new SolidBrush(c1))
            {
                g1.FillEllipse(b, x, y, diameter, diameter);
                g2.FillEllipse(b, x, y, diameter, diameter);
            }

            g1.Dispose();
            g2.Dispose();
        }

        public static string drawTriangle(int classID, Bitmap bitmap, Color c1, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            int diameter = (int)(bitmap.Width / (5.0 + 5.0 * rdm.NextDouble()));
            float xr = (float)rdm.NextDouble();
            float yr = (float)rdm.NextDouble();
            int x = (int)(xr * (bitmap.Width - diameter));
            int y = (int)(yr * (bitmap.Height - diameter));

            float borderWidth = 0;
            float borderHeight = 0;
            float centerX = 0;
            float centerY = 0;

            Graphics g = Graphics.FromImage(bitmap);

            using (Brush b = new SolidBrush(c1))
            {
                // Calculate the triangle's points
                PointF topPoint = new PointF(x + diameter / 2, y);
                PointF leftPoint = new PointF(x, y + diameter);
                PointF rightPoint = new PointF(x + diameter, y + diameter);
                PointF[] points = { topPoint, leftPoint, rightPoint };

                // Rotate the triangle
                float angle = (float)(360 * rdm.NextDouble());
                Matrix rotateMatrix = new Matrix();
                rotateMatrix.RotateAt(angle, new PointF(x + diameter / 2, y + diameter / 2));
                rotateMatrix.TransformPoints(points);

                // Draw the triangle
                g.FillPolygon(b, points);

                // Calculate bounding box based on rotated points
                float minX = Math.Min(points[0].X, Math.Min(points[1].X, points[2].X));
                float maxX = Math.Max(points[0].X, Math.Max(points[1].X, points[2].X));
                float minY = Math.Min(points[0].Y, Math.Min(points[1].Y, points[2].Y));
                float maxY = Math.Max(points[0].Y, Math.Max(points[1].Y, points[2].Y));

                borderWidth = maxX - minX;
                borderHeight = maxY - minY;
                centerX = minX + borderWidth / 2;
                centerY = minY + borderHeight / 2;
            }

            g.Dispose();
            return $"{classID} {centerX / (float)bitmap.Width} {centerY / (float)bitmap.Height} {borderWidth / (float)bitmap.Width} {borderHeight / (float)bitmap.Height}";
        }



        public static string drawSquare(int classID, Bitmap bitmap, Color c1, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            int diameter = (int)(bitmap.Width / (5.0 + 5.0 * rdm.NextDouble()));

            float xr = (float)rdm.NextDouble();
            float yr = (float)rdm.NextDouble();

            int x = (int)(xr * (bitmap.Width - diameter));
            int y = (int)(yr * (bitmap.Height - diameter));

            float borderWidth = 0;
            float borderHeight = 0;
            float centerX = 0;
            float centerY = 0;

            Graphics g = Graphics.FromImage(bitmap);

            using (Brush b = new SolidBrush(c1))
            {
                // Calculate the square's points
                PointF topLeftPoint = new PointF(x + diameter / 2 - (float)(diameter / Math.Sqrt(2) / 2), y + diameter / 2 - (float)(diameter / Math.Sqrt(2) / 2));
                PointF topRightPoint = new PointF(x + diameter / 2 + (float)(diameter / Math.Sqrt(2) / 2), y + diameter / 2 - (float)(diameter / Math.Sqrt(2) / 2));
                PointF bottomRightPoint = new PointF(x + diameter / 2 + (float)(diameter / Math.Sqrt(2) / 2), y + diameter / 2 + (float)(diameter / Math.Sqrt(2) / 2));
                PointF bottomLeftPoint = new PointF(x + diameter / 2 - (float)(diameter / Math.Sqrt(2) / 2), y + diameter / 2 + (float)(diameter / Math.Sqrt(2) / 2));
                PointF[] points = { topLeftPoint, topRightPoint, bottomRightPoint, bottomLeftPoint };

                // Rotate the square
                float angle = (float)(360 * rdm.NextDouble());
                Matrix rotateMatrix = new Matrix();
                rotateMatrix.RotateAt(angle, new PointF(x + diameter / 2, y + diameter / 2));
                rotateMatrix.TransformPoints(points);

                // Draw the square
                g.FillPolygon(b, points);

                // Calculate bounding box
                float minX = Math.Min(points[0].X, Math.Min(points[1].X, Math.Min(points[2].X, points[3].X)));
                float maxX = Math.Max(points[0].X, Math.Max(points[1].X, Math.Max(points[2].X, points[3].X)));
                float minY = Math.Min(points[0].Y, Math.Min(points[1].Y, Math.Min(points[2].Y, points[3].Y)));
                float maxY = Math.Max(points[0].Y, Math.Max(points[1].Y, Math.Max(points[2].Y, points[3].Y)));

                borderWidth = maxX - minX;
                borderHeight = maxY - minY;
                centerX = minX + borderWidth / 2;
                centerY = minY + borderHeight / 2;
            }

            g.Dispose();

            return $"{classID} {centerX / (float)bitmap.Width} {centerY / (float)bitmap.Height} {borderWidth / (float)bitmap.Width} {borderHeight / (float)bitmap.Height}";
        }


        public static string drawRectangle(int classID, Bitmap bitmap, Color c1, float Rate, Random rdm = null)
        {
            if (rdm == null) rdm = new Random(DateTime.Now.Millisecond);

            float diameter = (float)(bitmap.Width / (5.0 + 5.0 * rdm.NextDouble()));
            float xr = (float)rdm.NextDouble();
            float yr = (float)rdm.NextDouble();

            float x = (float)(xr * (bitmap.Width - diameter));
            float y = (float)(yr * (bitmap.Height - diameter));

            // Calculate the rectangle's width and height based on the Rate
            float rectWidth = (float)(diameter / Math.Sqrt(1 + Rate * Rate));
            float rectHeight = Rate * rectWidth;

            float borderWidth = 0;
            float borderHeight = 0;
            float centerX = 0;
            float centerY = 0;

            Graphics g = Graphics.FromImage(bitmap);

            using (Brush b = new SolidBrush(c1))
            {
                // Calculate the rectangle's points
                PointF topLeftPoint = new PointF(x + diameter / 2 - rectWidth / 2, y + diameter / 2 - rectHeight / 2);
                PointF topRightPoint = new PointF(x + diameter / 2 + rectWidth / 2, y + diameter / 2 - rectHeight / 2);
                PointF bottomRightPoint = new PointF(x + diameter / 2 + rectWidth / 2, y + diameter / 2 + rectHeight / 2);
                PointF bottomLeftPoint = new PointF(x + diameter / 2 - rectWidth / 2, y + diameter / 2 + rectHeight / 2);
                PointF[] points = { topLeftPoint, topRightPoint, bottomRightPoint, bottomLeftPoint };

                // Rotate the rectangle
                float angle = (float)(360 * rdm.NextDouble());
                Matrix rotateMatrix = new Matrix();
                rotateMatrix.RotateAt(angle, new PointF(x + diameter / 2, y + diameter / 2));
                rotateMatrix.TransformPoints(points);

                // Draw the rectangle
                g.FillPolygon(b, points);

                // Calculate bounding box
                float minX = Math.Min(points[0].X, Math.Min(points[1].X, Math.Min(points[2].X, points[3].X)));
                float maxX = Math.Max(points[0].X, Math.Max(points[1].X, Math.Max(points[2].X, points[3].X)));
                float minY = Math.Min(points[0].Y, Math.Min(points[1].Y, Math.Min(points[2].Y, points[3].Y)));
                float maxY = Math.Max(points[0].Y, Math.Max(points[1].Y, Math.Max(points[2].Y, points[3].Y)));

                borderWidth = maxX - minX;
                borderHeight = maxY - minY;
                centerX = minX + borderWidth / 2;
                centerY = minY + borderHeight / 2;
            }

            g.Dispose();

            return $"{classID} {centerX / (float)bitmap.Width} {centerY / (float)bitmap.Height} {borderWidth / (float)bitmap.Width} {borderHeight / (float)bitmap.Height}";
        }


    }
}
