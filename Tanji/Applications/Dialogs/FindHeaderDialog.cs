using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Tanji.Utilities;
using Tanji.Components;

using FlashInspect.ActionScript;

namespace Tanji.Applications.Dialogs
{
    public partial class FindHeaderDialog : TanjiForm
    {
        private readonly HGame _game;

        private string _hash = string.Empty;
        public string Hash
        {
            get { return _hash; }
            set
            {
                _hash = value;
                RaiseOnPropertyChanged(nameof(Hash));
            }
        }

        public FindHeaderDialog(HGame game)
        {
            _game = game;
            InitializeComponent();

            HashTxt.DataBindings.Add("Text", this,
                nameof(Hash), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            Find(HashTxt.Text);
        }

        public void Find(string hash)
        {
            Hash = hash;
            HeadersVw.ClearItems();

            IEnumerable<ASClass> messages = _game.GetMessages(HashTxt.Text);
            if (messages == null) return;

            foreach (ASClass messageClass in messages)
            {
                ushort header = _game.GetMessageHeader(messageClass);
                bool isOutgoing = _game.IsMessageOutgoing(messageClass);
                string messageName = messageClass.Instance.Name.Name;

                string type = "Outgoing";
                if (!isOutgoing)
                {
                    type = "Incoming";
                    messageName += (", " + _game.GetIncomingMessageParser(
                        messageClass).Instance.Name.Name);
                }
                HeadersVw.AddFocusedItem(type, header, messageName);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            CenterToParent();
            base.OnLoad(e);
        }
    }
}