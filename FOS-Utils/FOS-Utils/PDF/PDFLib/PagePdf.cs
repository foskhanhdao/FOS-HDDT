using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FOS_Utils.PDF.PDFLib
{
    public enum PageType
    {
        A4,
        A3,
        Custom,
    }
    public class PagePdf
    {
        #region Variable
        private float with;
        private float height;
        //private PageType pageType;
        #endregion
        #region Field
        public float Height
        {
            get { return height; }
        }
        public float With
        {
            get { return with; }
        }
       
        #endregion
        #region Contructer
        public PagePdf()
        { }
        public PagePdf(PageType pageType)
        {
            
        }
        public PagePdf(float with, float height)
        {
            this.with = with;
            this.height = height;
        }
        #endregion
        #region Fun
        
        #endregion

    }
}
