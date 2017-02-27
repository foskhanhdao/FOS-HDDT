﻿using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace FOS_Utils
{
    public class FTextBoxLine:FTextBox
    {
        
        public FTextBoxLine()
        {
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint,true);
        }
        private DashStyle _lineStyleTop = DashStyle.Solid;
        private DashStyle _lineStyleBottom = DashStyle.Solid;
        private DashStyle _lineStyleLeft = DashStyle.Solid;
        private DashStyle _lineStyleRight = DashStyle.Solid;
        private bool _isShowLineTop = false;
        private bool _isShowLineBottom = false;
        private bool _isShowLineLeft = false;
        private bool _isShowLineRight = false;

        private ContentAlignment _verticalAlign = ContentAlignment.MiddleLeft; 

        public DashStyle LineStyleTop
        {
            get { return _lineStyleTop; }
            set { _lineStyleTop = value; this.Refresh(); }
        }
        public DashStyle LineStyleBottom
        {
            get { return _lineStyleBottom; }
            set { _lineStyleBottom = value; this.Refresh(); }
        }
        public DashStyle LineStyleLeft
        {
            get { return _lineStyleLeft; }
            set { _lineStyleLeft = value; this.Refresh(); }
        }
        public DashStyle LineStyleRight
        {
            get { return _lineStyleRight; }
            set { _lineStyleRight = value; this.Refresh(); }
        }

        public bool IsShowLineTop
        {
            get { return _isShowLineTop; }
            set { _isShowLineTop = value; this.Refresh(); }
        }

        public bool IsShowLineBottom
        {
            get { return _isShowLineBottom; }
            set { _isShowLineBottom = value; this.Refresh(); }
        }

        public bool IsShowLineLeft
        {
            get { return _isShowLineLeft; }
            set { _isShowLineLeft = value; this.Refresh(); }
        }

        public bool IsShowLineRight
        {
            get { return _isShowLineRight; }
            set { _isShowLineRight = value; this.Refresh(); }
        }

        public ContentAlignment VerticalAlign
        {
            get { return _verticalAlign; }
            set { _verticalAlign = value; this.Refresh(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(Color.Black))
            {
                if (IsShowLineTop)
                {
                    pen.DashStyle = LineStyleTop;
                    e.Graphics.DrawLine(pen, 0, 0, this.Width, 0);
                }
                if (IsShowLineBottom)
                {
                    pen.DashStyle = LineStyleBottom;
                    e.Graphics.DrawLine(pen, 0, this.ClientSize.Height - 1, this.ClientSize.Width, this.ClientSize.Height - 1);
                }
                if (IsShowLineLeft)
                {
                    pen.DashStyle = LineStyleLeft;
                    e.Graphics.DrawLine(pen, 0, 0, 0, this.ClientSize.Height);
                }
                if (IsShowLineRight)
                {
                    pen.DashStyle = LineStyleRight;
                    e.Graphics.DrawLine(pen, this.ClientSize.Width - 1, 0, this.ClientSize.Width - 1, this.ClientSize.Height);
                }
                //DRAW TEXT HERE
                e.Graphics.DrawString(this.Text, this.Font, Brushes.Black, 0, this.Height / 2); 
            }
        }

       

    }
}
