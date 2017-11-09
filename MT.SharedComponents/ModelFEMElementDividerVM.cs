using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.SharedComponents
{
    public class ModelFEMElementDividerVM : ViewModelBase
    {
        private double _value = 2;
        private bool _isMaxLenght;

        public double Value
        {
            get { return _value; }
            set { _value = value; RaisePropertyChanged();}
        }

        public bool IsMaxLenght
        {
            get { return _isMaxLenght; }
            set { _isMaxLenght = value; RaisePropertyChanged();}
        }
    }
}
