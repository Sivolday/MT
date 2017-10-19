using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;

namespace MT.AutoCAD
{
    public static class Select
    {
        /// <summary> Выбор примитивов на экране </summary>
        /// <param name="autoCADPrimitivesName"> Имя приметива </param>
        /// <returns> Список приметивов </returns>
        public static List<AcadEntity> OnScreen(string autoCADPrimitivesName)
        {

            var acadDocument = DocumentLocator.GetAcadDocument();

            // Установка пространства модели
            acadDocument.ActiveSpace = AcActiveSpace.acModelSpace;

            AcadSelectionSet selectionSet = acadDocument.SelectionSets.Add(DateTime.Now.Millisecond.ToString());
            Int16[] filterCode = new Int16[] { 0 };
            object[] filterValue = new object[] { autoCADPrimitivesName };

            selectionSet.SelectOnScreen(filterCode, filterValue);
            var listOfEntities = new List<AcadEntity>();

            Debug.WriteLine($"Из AutoCADa заполучено ${selectionSet.Count} объектов");

            foreach (AcadEntity entity in selectionSet)
            {
                listOfEntities.Add(entity);
            }

            selectionSet.Delete();
            return listOfEntities;
        }
    }
}
