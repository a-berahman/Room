using System;
using System.Linq;

namespace Implementation.HackerRank
{
    public class Designer_PDF_Viewer
    {
        public int designerPdfViewer(int[] h, string word) => word.Distinct().ToArray().Max(m => h[m - 'a']) * word.Length;

    }
}