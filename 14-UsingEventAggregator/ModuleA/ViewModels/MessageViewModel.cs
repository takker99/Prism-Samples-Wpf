using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace ModuleA.ViewModels
{
    public class MessageViewModel : BindableBase
    {
        public string Message
        {
            get => return this._message;
            set => SetProperty(ref this._message, value);
        }

        public DelegateCommand SendMessageCommand { get; private set; }

        public MessageViewModel(IEventAggregator ea)
        {
            this._ea = ea;
            this.SendMessageCommand = new DelegateCommand(
                () =>
                {
                    this._ea.GetEvent<MessageSentEvent>().Publish(Message);
                }
            );
        }

        private IEventAggregator _ea;
        private string _message = "Message to Send";
    }
}
