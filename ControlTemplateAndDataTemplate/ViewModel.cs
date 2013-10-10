using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveUI;
using ReactiveUI.Xaml;

namespace ControlTemplateAndDataTemplate
{
    class ViewModel:ReactiveObject
    {
        private string _MyText;
        public string MyText { get { return _MyText; } set { this.RaiseAndSetIfChanged(x => x.MyText, value); } }
        public ReactiveCommand MyButton { get; set; }
        public ViewModel()
        {
            MyText = "Mark";
            MyButton=new ReactiveCommand();
            MyButton.Subscribe(ButtonFunc);

        }

        public void ButtonFunc(object o)
        {
            MyText += "Mark";

        }
    }
}
