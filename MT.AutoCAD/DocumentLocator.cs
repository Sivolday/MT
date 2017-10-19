using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Interop;

namespace MT.AutoCAD
{
    public static class DocumentLocator
    {
        private static AcadApplication _acadApplication;
        private static AcadDocument _acadDocument;

        /// <summary>
        /// Заполучить активный документ в автокаде
        /// </summary>
        public static AcadDocument GetAcadDocument()
        {
            _acadApplication = _acadApplication ??  (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application");
            return _acadDocument ?? (_acadDocument = _acadApplication.ActiveDocument);
        }
    }
}
