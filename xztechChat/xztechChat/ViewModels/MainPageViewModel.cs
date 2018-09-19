using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using xztechChat.Models;

namespace xztechChat.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Message> ListMessages { get; }
        public ICommand SendCommand { get; set; }
        public MainPageViewModel() 
        {
            Title = "Main Page";

            ListMessages = new ObservableCollection<Message>();

            SendCommand = new Command(() =>
            {
                if (!String.IsNullOrWhiteSpace(OutText))
                {
                    var message = new Message
                    {
                        Text = OutText,
                        IsTextIn = false,
                        MessageDateTime = DateTime.Now,

                    };

                    ListMessages.Add(message);
                    OutText = "";


                }

            });
        }

        public string OutText
        {
            get { return _outText; }
            set { SetProperty(ref _outText, value); }
        }
        string _outText = string.Empty;
    }
}
