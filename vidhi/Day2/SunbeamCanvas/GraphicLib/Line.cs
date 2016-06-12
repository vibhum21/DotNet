﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicLib
{
   public  class Line:IShape
   {
       #region MemberVariables
        Point ptStartPoint;
        Point ptEndPoint;
        int style;
        int width;
        Color color;
       #endregion

        #region Properties
        public Point StartPoint
        {
            get { return ptStartPoint; }
            set { ptStartPoint = value; }
        }
        public Point EndPoint
        {
            get { return ptEndPoint; }
            set { ptEndPoint = value; }
        }
        public int Style
        {
            get { return style; }
            set { style = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public Color PenColor
        {
            get { return color; }
            set { color = value; }
        }
     
#endregion

        #region Constructors
        public Line()
       {
           this.StartPoint = new Point(10, 10);
           this.EndPoint = new Point(100, 100);
           this.Style = 1;
           this.PenColor = Color.OrangeRed;
           this.Width = 3;
       }
        public Line(Point ptst, Point ptend, int style, int width, Color color)
       {
           this.StartPoint = ptst;
           this.EndPoint = ptend;
           this.Style = style;
           this.PenColor = color;
           this.Width = width;
       }
        #endregion

        #region Behaviour
        public void Draw(System.Drawing.Graphics g)
        {
            Pen drawingPen = new Pen(PenColor, Width);
            g.DrawLine(drawingPen, StartPoint, EndPoint);
        }
        #endregion

        ~Line()
        { 
        }
   }
}
