using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayBindingSample
{
    public class SampleData
    {
        private ObservableCollection<string> _userInputs = new ObservableCollection<string>();
        private string _text1;

        public string Text1
        {
            get { return _text1; }
            set
            {
                _text1 = value;
                _userInputs.Add(_text1);
            }
        }

        public IEnumerable<string> UserInputs => _userInputs;

    }
}
