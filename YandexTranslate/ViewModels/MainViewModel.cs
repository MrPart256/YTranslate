using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using YandexTranslate.Commands;

namespace YandexTranslate.ViewModels
{
    class MainViewModel : BaseViewModel
    {
   
        private string _inputString;

        public string InputString
        {
            get
            {
                return _inputString;
            }
            set
            {
                _inputString = value;
                OnPropertyChanged(nameof(InputString));
            }
        }
        private string _OutputString;

        public string OutputString
        {
            get
            {
                return _OutputString;
            }
            set
            {
                _OutputString = value;
                OnPropertyChanged(nameof(OutputString));
            }
        }

        private string _selectedInputLang;

        public string SelectedInputLang
        {
            get
            {
                return _selectedInputLang;
            }
            set
            {
                _selectedInputLang = value;
                OnPropertyChanged(nameof(SelectedInputLang));
            }
        }
        public List<string> InputLang
        {
            get
            {
                return new List<string>
                {
                    "English",
                    "Russian",
                    "Deutsch"
                };
            }
        }
        private string _selectedOutputLang;
        public string SelectedOutputLang
        {
            get
            {
                return _selectedOutputLang;
            }
            set
            {
                _selectedOutputLang = value;
                OnPropertyChanged(nameof(SelectedOutputLang));
            }
        }
        public List<string> OutputLang
        {
            get
            {
                return new List<string>
                {
                    "English",
                    "Russian",
                    "Deutsch"
                };
            }
        }

        private ICommand command;

        public ICommand Command
        {
            get
            {
                if (command == null)
                {
                    command = new DelegateCommand(() => { Translate(); }, () => !string.IsNullOrEmpty(_inputString));
                }
                return command;
            }

        }
        private void Translate()
        {
            TTranslate ttr = new TTranslate();
            OutputString = ttr.Translator(_inputString, ttr.GetLangPair(SelectedInputLang, SelectedOutputLang));
        }

    }
}
