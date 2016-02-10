using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo
{
    public class SampleData : IDataErrorInfo
    {
        public SampleData()
        {
            Val1 = 5;
            Val2 = 5;
        }

        private int _val1;

        public int Val1
        {
            get { return _val1; }
            set
            {
                if (value > 50)
                    throw new Exception("bad bad bad value");
                _val1 = value;
            }
        }

        public int Val2 { get; set; }

        string IDataErrorInfo.Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                string errorMessage = null;
                switch (columnName)
                {
                    case "Val2":
                        if (Val2 > 40)
                        {
                            errorMessage = "falscher Wert bei Val2";
                        }
                        break;
                    default:
                        break;
                }

                return errorMessage;
            }
        }
    }
}
