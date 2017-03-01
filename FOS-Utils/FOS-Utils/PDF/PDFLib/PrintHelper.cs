using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using FOS_Utils.PDF.PDFControl;
using System.Drawing;
using System.Data;

namespace FOS_Utils.PDF.PDFLib
{
    
    public static class PrintHelper
    {
        #region variable
        private static PrintDocument doc;
        private static PrintPreviewDialog prDialog;
        //Panel Chinh de ve
        private static FPdfPanel panelMain;
        //tong so trang Pdf
        private static int NumberPage = 1;
        //trang Pdf hien tai
        private static int CurPage = 1;      
        //Tong hop tat ca cac line trong trang
        private static List<FosLine> lsLineInpage = new List<FosLine>();
        #endregion
        #region FunPrint
        /// <summary>
        /// Bat dau in Document
        /// </summary>
        /// <param name="panelMain"></param>
        public static void BeginPrint(FPdfPanel panelMainInput)
        {
            panelMain = panelMainInput;
            if (doc == null && prDialog == null)
            {
                if (panelMain != null &&panelMain.DataSource!=null&& panelMain.DataSource.Rows.Count>0)
                {                    
                    NumberPage = panelMain.DataSource.Rows.Count;
                }
                
                PaperSize pageSize = new PaperSize("PaperA4", panelMain.Size.Width, panelMain.Size.Height);                
                doc = new PrintDocument();                
                doc.DefaultPageSettings.PaperSize = pageSize;
                //doc.DefaultPageSettings.Landscape = true;
                doc.PrintPage += new PrintPageEventHandler(On_PrintPage);
                
             
                prDialog = new PrintPreviewDialog();
                prDialog.Document = doc;
                prDialog.Width = Screen.PrimaryScreen.WorkingArea.Width;
                prDialog.Height = Screen.PrimaryScreen.WorkingArea.Height;
               
            }
        }
        public static void ViewBeforPrint()
        {
            if (doc != null && prDialog != null)
            {
                prDialog.ShowDialog();
            }
        }
        public static void Print()
        {
            if (doc != null)
            {
                doc.Print();
                doc.Dispose();
            }
        }
        /// <summary>
        /// Sau khi in xong goi ham nay de reset lai cac bien dung de in lan sau
        /// </summary>
        public static void EndPrint()
        {
            doc = null;
            prDialog = null;
            panelMain = null;
            NumberPage = 1;
            CurPage = 1;         
            lsLineInpage = new List<FosLine>();
        }
        /// <summary>
        /// Su kien In, dung de ve cac control len trang Document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        private static void On_PrintPage(object sender, PrintPageEventArgs ev)
        {

            Graphics g = ev.Graphics;
            if (doc != null)
            {
                // In het cac control trong trang
                PrintAllControlInPanel(g, panelMain, CurPage, new FosPoint(0, 0));
                //In het cac line trong trang sau cung
                foreach (FosLine line in lsLineInpage)
                {
                    PrintLine(g, line);
                }
                if (CurPage != NumberPage)
                {
                    ev.HasMorePages = true;
                    CurPage++;
                }
                else
                {
                    ev.HasMorePages = false;
                    CurPage = 1;
                }

            }
            
        }         
        /// <summary>
        /// In tat ca cac control co trong Panel
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="page"></param>
        /// <param name="curPage"></param>
        /// <param name="rootPoint"></param>
        public static void PrintAllControlInPanel(Graphics g,FPdfPanel panel, int curPage, FosPoint rootPoint)
        {
            //Add line
            if (panel.lsPdfLine.Count > 0)
            {
                foreach (FosLine line in panel.lsPdfLine)
                {
                    if (curPage == 1)
                    {
                        FosLine lineNew = new FosLine(new FosPoint(), new FosPoint());
                        lineNew.PointStart.XPoint = rootPoint.XPoint + line.PointStart.XPoint;
                        lineNew.PointStart.YPoint = rootPoint.YPoint + line.PointStart.YPoint;
                        lineNew.PointDest.XPoint = rootPoint.XPoint + line.PointDest.XPoint;
                        lineNew.PointDest.YPoint = rootPoint.YPoint + line.PointDest.YPoint;
                        lsLineInpage.Add(lineNew);
                    }
                }
            }
           
            // In hinh dau tien
            foreach (Control c in panel.Controls)
            {

                if (c is PictureBox)
                {
                    PictureBox pB = c as PictureBox;
                    PrintImage(g,pB, rootPoint);
                }
            }
            //Sau do in chu
            foreach (Control c in panel.Controls)
            {
                //if (c is FPdfText)
                //{
                //    FPdfText FPdfText = c as FPdfText;
                //    PrinString(FPdfText, page, rootPoint, curPage);
                //}
                if (c is FPdfLabel)
                {
                    FPdfLabel FPdfLabel = c as FPdfLabel;
                    PrintString(g,FPdfLabel, rootPoint, curPage);
                }
                //in Panel con
                if (c is FPdfPanel)
                {
                    FPdfPanel FPdfPanelChirld = c as FPdfPanel;
                    if (FPdfPanelChirld.Enabled == true)
                    {
                        //In BackGround Image
                        PrintBackGroundImage(g, FPdfPanelChirld, rootPoint);
                        //inborder
                        if (FPdfPanelChirld.BorderStyle == BorderStyle.FixedSingle)
                            PrintBorderForControl(FPdfPanelChirld, rootPoint);
                        PrintAllControlInPanel(g, FPdfPanelChirld, curPage, new FosPoint(rootPoint.XPoint + FPdfPanelChirld.Location.X, rootPoint.YPoint + FPdfPanelChirld.Location.Y));
                    }
                }
            }
        }
        /// <summary>
        /// Dua vao Label Viet chu len PrintDocument
        /// </summary>
        /// <param name="g"></param>
        /// <param name="FPdfLabel"></param>
        /// <param name="rootPoint"></param>
        /// <param name="curPage"></param>
        private static void PrintString(Graphics g, FPdfLabel FPdfLabel, FosPoint rootPoint, int curPage)
        {
            if (!FPdfLabel.Enabled)
                return;
            //In Backcolor
            PrintBackColor(g, FPdfLabel, rootPoint);
            //Inborder
            PrintBorderLabel(FPdfLabel, rootPoint);
            // tao bien tao do
            FosPoint point = CreatePointFromLabel(FPdfLabel);
            // Tuy vao control cha la gi ma chinh lai toa do
            point.XPoint += rootPoint.XPoint;
            point.YPoint += rootPoint.YPoint;           
            //Lay du lieu cua dataSource bo vao text
            string text = GetDataFPdfLabel(FPdfLabel, curPage);
            point.XPoint += AlignforFPdfLabel(FPdfLabel as FPdfLabel);
            g.DrawString(text, FPdfLabel.Font, new SolidBrush(FPdfLabel.ForeColor), point.XPoint, point.YPoint);
        }
        /// <summary>
        /// Ve mot duong thang tren PrintDocument
        /// </summary>
        /// <param name="g"></param>
        /// <param name="line"></param>   
        public static void PrintLine(Graphics g, FosLine line)
        {
           
            Pen blackPen = new Pen(Color.Black, 1);
            if (line.LineStyle == LineStyle.Dot)
            {
                float[] dashValues = { 2, 2, 2, 2 };
                blackPen.DashPattern = dashValues;
            }
            g.DrawLine(blackPen, line.PointStart.XPoint, line.PointStart.YPoint, line.PointDest.XPoint, line.PointDest.YPoint);

        }
        /// <summary>
        /// In Hinh anh len PrintDocument
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pB"></param>
        /// <param name="rootPoint"></param>
        public static void PrintImage(Graphics g, PictureBox pB, FosPoint rootPoint)
        {
            if (!pB.Enabled)
                return;
            try
            {
                Image img = pB.Image;
                g.DrawImage(img, pB.Location.X + rootPoint.XPoint, pB.Location.Y + rootPoint.YPoint, pB.Width, pB.Height);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
        }
        /// <summary>
        /// Print BackGround Image
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pB"></param>
        /// <param name="rootPoint"></param>
        public static void PrintBackGroundImage(Graphics g, Control ct, FosPoint rootPoint)
        {
            if (ct.BackgroundImage == null)
                return;
            try
            {
                Image img = ct.BackgroundImage;
                FosPoint point = new FosPoint(ct.Location.X, ct.Location.Y);
                Size size = new Size(ct.Width,ct.Height);
                if (ct.BackgroundImageLayout == ImageLayout.Center)
                {
                    if (ct.Width > img.Width)
                    {
                        point.XPoint += (ct.Width - img.Width) / 2;
                    }
                    if (ct.Height > img.Height)
                    {
                        point.YPoint += (ct.Height - img.Height) / 2;
                    }
                    size.Width = img.Width;
                    size.Height = img.Height;
                }
                g.DrawImage(img, point.XPoint + rootPoint.XPoint, point.YPoint + rootPoint.YPoint, size.Width, size.Height);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// In Backcolor cho Label
        /// </summary>
        /// <param name="g"></param>
        /// <param name="FPdfLabel"></param>
        /// <param name="rootPoint"></param>
        public static void PrintBackColor(Graphics g,FPdfLabel FPdfLabel, FosPoint rootPoint)
        {
            if (FPdfLabel.BackColor == Color.White || FPdfLabel.BackColor == Color.Transparent)
                return;
            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(FPdfLabel.BackColor);

            // Create rectangle.
            Rectangle rect = new Rectangle((int)rootPoint.XPoint + FPdfLabel.Location.X, (int)rootPoint.YPoint + FPdfLabel.Location.Y, FPdfLabel.Size.Width, FPdfLabel.Size.Height);
            
            // Fill rectangle to screen.
            g.FillRectangle(blueBrush, rect);
        }
        #endregion
        #region Fun
        /// <summary>
        /// tao border cho cac control
        /// </summary>
        /// <param name="ct"></param>
        /// <param name="page"></param>
        /// <param name="rootPoint"></param>
        public static void PrintBorderForControl(Control ct, FosPoint rootPoint)
        {
            FosLine line1 = new FosLine();
            line1.PointStart = new FosPoint(rootPoint.XPoint + ct.Location.X, rootPoint.YPoint + ct.Location.Y);
            line1.PointDest = new FosPoint(rootPoint.XPoint + ct.Location.X + ct.Width, rootPoint.YPoint + ct.Location.Y);
            if (CurPage == 1)
                lsLineInpage.Add(line1);

            FosLine line2 = new FosLine();
            line2.PointStart = new FosPoint(rootPoint.XPoint + ct.Location.X, rootPoint.YPoint + ct.Location.Y + ct.Height);
            line2.PointDest = new FosPoint(rootPoint.XPoint + ct.Location.X + ct.Width, rootPoint.YPoint + ct.Location.Y + ct.Height);
            if (CurPage == 1)
                lsLineInpage.Add(line2);

            FosLine line3 = new FosLine();
            line3.PointStart = new FosPoint(rootPoint.XPoint + ct.Location.X, rootPoint.YPoint + ct.Location.Y);
            line3.PointDest = new FosPoint(rootPoint.XPoint + ct.Location.X, rootPoint.YPoint + ct.Location.Y + ct.Height);
            if (CurPage == 1)
                lsLineInpage.Add(line3);

            FosLine line4 = new FosLine();
            line4.PointStart = new FosPoint(rootPoint.XPoint + ct.Location.X + ct.Width, rootPoint.YPoint + ct.Location.Y);
            line4.PointDest = new FosPoint(rootPoint.XPoint + ct.Location.X + ct.Width, rootPoint.YPoint + ct.Location.Y + ct.Height);
            if (CurPage == 1)
                lsLineInpage.Add(line4);

        }
        /// <summary>
        /// In border cho label
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="page"></param>
        /// <param name="rootPoint"></param>
        public static void PrintBorderLabel(FPdfLabel tb, FosPoint rootPoint)
        {
            if (tb.IsShowLineTop)
            {
                FosLine lineTop = new FosLine();
                lineTop.PointStart = new FosPoint(rootPoint.XPoint + tb.Location.X, rootPoint.YPoint + tb.Location.Y);
                lineTop.PointDest = new FosPoint(rootPoint.XPoint + tb.Location.X + tb.Width, rootPoint.YPoint + tb.Location.Y);
                if (tb.LineStyleTop == System.Drawing.Drawing2D.DashStyle.Dot)
                {
                    lineTop.LineStyle = LineStyle.Dot;
                }
                if (CurPage == 1)
                    lsLineInpage.Add(lineTop);
            }
            if (tb.IsShowLineBottom)
            {
                FosLine lineBottom = new FosLine();
                lineBottom.PointStart = new FosPoint(rootPoint.XPoint + tb.Location.X, rootPoint.YPoint + tb.Location.Y + tb.Height);
                lineBottom.PointDest = new FosPoint(rootPoint.XPoint + tb.Location.X + tb.Width, rootPoint.YPoint + tb.Location.Y + tb.Height);
                if (tb.LineStyleBottom == System.Drawing.Drawing2D.DashStyle.Dot)
                {
                    lineBottom.LineStyle = LineStyle.Dot;
                }
                if (CurPage == 1)
                    lsLineInpage.Add(lineBottom);
            }
            if (tb.IsShowLineLeft)
            {
                FosLine lineLeft = new FosLine();
                lineLeft.PointStart = new FosPoint(rootPoint.XPoint + tb.Location.X, rootPoint.YPoint + tb.Location.Y);
                lineLeft.PointDest = new FosPoint(rootPoint.XPoint + tb.Location.X, rootPoint.YPoint + tb.Location.Y + tb.Height);
                if (tb.LineStyleLeft == System.Drawing.Drawing2D.DashStyle.Dot)
                {
                    lineLeft.LineStyle = LineStyle.Dot;
                }
                if (CurPage == 1)
                    lsLineInpage.Add(lineLeft);
            }
            if (tb.IsShowLineRight)
            {
                FosLine lineRight = new FosLine();
                lineRight.PointStart = new FosPoint(rootPoint.XPoint + tb.Location.X + tb.Width, rootPoint.YPoint + tb.Location.Y);
                lineRight.PointDest = new FosPoint(rootPoint.XPoint + tb.Location.X + tb.Width, rootPoint.YPoint + tb.Location.Y + tb.Height);
                if (tb.LineStyleRight == System.Drawing.Drawing2D.DashStyle.Dot)
                {
                    lineRight.LineStyle = LineStyle.Dot;
                }
                if (CurPage == 1)
                    lsLineInpage.Add(lineRight);
            }
        }
        /// <summary>
        /// Tu Label lay ra toa do de in text 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static FosPoint CreatePointFromLabel(FPdfLabel label)
        {
            int height = label.Size.Height;
            int size = (int)label.Font.Size;
            int xPoint = label.Location.X ;
            int yPoint = 0;
            //center
            if (label.TextAlign == ContentAlignment.MiddleLeft ||
                label.TextAlign == ContentAlignment.MiddleCenter ||
                label.TextAlign == ContentAlignment.MiddleRight)
            {
                yPoint = (label.Location.Y + (label.Size.Height - size) / 2)-1;
            }
            //top
            if (label.TextAlign == ContentAlignment.TopLeft ||
                label.TextAlign == ContentAlignment.TopCenter ||
                label.TextAlign == ContentAlignment.TopRight)
            {
                yPoint = label.Location.Y ;
            }
            ////bottom
            if (label.TextAlign == ContentAlignment.BottomLeft ||
                label.TextAlign == ContentAlignment.BottomCenter ||
                label.TextAlign == ContentAlignment.BottomRight)
            {
                yPoint = label.Location.Y + (label.Size.Height - size -2);
            }
            FosPoint point = new FosPoint(xPoint, yPoint);
            return point;
        }
        /// <summary>
        ///  Canh trai, phai, giua cho label
        /// </summary>
        /// <param name="lb"></param>
        /// <returns></returns>
        public static int AlignforFPdfLabel(FPdfLabel lb)
        {
            double align;
            double width = lb.Size.Width;
            using (Bitmap tempImage = new Bitmap(lb.Size.Width, lb.Size.Height))
            {
                SizeF stringSize = Graphics.FromImage(tempImage).MeasureString(lb.Text, lb.Font);
                align = width - stringSize.Width;
            }
            if (lb.TextAlign == ContentAlignment.TopCenter ||
                lb.TextAlign == ContentAlignment.MiddleCenter ||
                lb.TextAlign == ContentAlignment.BottomCenter)
            {
                align = align / 2;
            }
            if (lb.TextAlign == ContentAlignment.TopLeft ||
                lb.TextAlign == ContentAlignment.MiddleLeft ||
                lb.TextAlign == ContentAlignment.BottomLeft)
            {
                align = 4;
            }
            if (lb.TextAlign == ContentAlignment.TopRight ||
                lb.TextAlign == ContentAlignment.MiddleRight ||
                lb.TextAlign == ContentAlignment.BottomRight)
            {
                align = align - 4;
            }
            return (int)Math.Round(align, MidpointRounding.AwayFromZero);
        }
        /// <summary>
        /// Lay du lieu cho Label dua vao DataSource cua Detail
        /// </summary>
        /// <param name="FPdfText"></param>
        /// <param name="curPage"></param>
        public static string GetDataFPdfLabel(FPdfLabel FPdfLabel, int curPage)
        {
            
            string text = FPdfLabel.Text;
            if (panelMain.DataSource == null)
                return text;
            DataTable dt = panelMain.DataSource;
            if (dt != null&&dt.Rows.Count != 0 && dt.Columns.Contains(FPdfLabel.FPdfProperties.TableColumn))
            {              
                text = dt.Rows[curPage][FPdfLabel.FPdfProperties.TableColumn] + "";
            }
            return text;
        }
        #endregion
    }
}
