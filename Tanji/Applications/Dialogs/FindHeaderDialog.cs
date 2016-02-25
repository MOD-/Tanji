using System;
using System.Collections.Generic;

using Tanji.Utilities;
using Tanji.Components;

using FlashInspect.ActionScript;

namespace Tanji.Applications.Dialogs
{
    public partial class FindHeaderDialog : TanjiForm
    {
        private readonly HFlash _game;

        public FindHeaderDialog(HFlash game)
        {
            InitializeComponent();

            _game = game;
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            HeadersVw.ClearItems();

            List<ASClass> messageClasses =
                FindClasses(HashTxt.Text);

            if (messageClasses == null) return;
            foreach (ASClass messageClass in messageClasses)
            {
                string className =
                    messageClass.Instance.Type.ObjName;

                ushort header =
                    _game.GetHeader(messageClass);

                bool isOutgoing =
                    _game.IsOutgoing(messageClass);

                if (!isOutgoing)
                {
                    className += (", " + _game.GetIncomingParser(
                        messageClass.Instance).Instance.Type.ObjName);
                }

                string type = (isOutgoing ?
                    "Outgoing" : "Incoming");

                HeadersVw.AddFocusedItem(
                    type, header, className);
            }
        }

        public void Find(string hash)
        {
            HashTxt.Text = hash;
            FindBtn_Click(this, EventArgs.Empty);
        }

        private List<ASClass> FindClasses(string hash)
        {
            List<ASClass> messageClasses = _game.GetClasses(hash);
            if ((messageClasses?.Count ?? 0) == 0)
            {
                messageClasses = FindClasses(hash,
                    true, _game.OutgoingTypes);
            }
            if ((messageClasses?.Count ?? 0) == 0)
            {
                messageClasses = FindClasses(hash,
                    false, _game.IncomingTypes);
            }
            return messageClasses;
        }
        protected List<ASClass> FindClasses(string hash, bool isOutgoing, Dictionary<ushort, ASClass> messages)
        {
            var messageClasses = new List<ASClass>();
            foreach (ASClass msgClass in messages.Values)
            {
                string outHash = _game
                    .GetHash(msgClass, true, isOutgoing);

                if (outHash == hash)
                    messageClasses.Add(msgClass);
            }
            return messageClasses;
        }

        protected override void OnLoad(EventArgs e)
        {
            CenterToParent();
            base.OnLoad(e);
        }
    }
}