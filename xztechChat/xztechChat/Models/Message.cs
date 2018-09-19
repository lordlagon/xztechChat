using Prism.Mvvm;
using System;

namespace xztechChat.Models
{
    public class Message : BindableBase
    {
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
        string _text;

        public DateTime MessageDateTime
        {
            get { return _messageDateTime; }
            set { SetProperty(ref _messageDateTime, value); }
        }

        DateTime _messageDateTime;

        public string TimeDisplay => MessageDateTime.ToLocalTime().ToString();

        public bool IsTextIn
        {
            get { return _isTextIn; }
            set { SetProperty(ref _isTextIn, value); }
        }
        bool _isTextIn;
    }
}
