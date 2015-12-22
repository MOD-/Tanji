using Sulakore.Communication;

namespace Tanji.Managers
{
    public class ToolboxManager
    {
        public MainFrm MainUI { get; }
        public HTriggers Triggers { get; }

        public bool ReEnterOnKick { get; private set; }

        public bool IsInRoom { get; private set; }
        public int LastEnteredRoomId { get; private set; }
        public string LastEnteredRoomPassword { get; private set; }

        public ToolboxManager(MainFrm main)
        {
            MainUI = main;
            Triggers = new HTriggers(true);

            #region Incoming Events
            Triggers.EntityAction += Triggers_EntityAction;
            //Triggers.FurnitureMove += Triggers_FurnitureMove;
            Triggers.PlayerKickHost += Triggers_PlayerKickHost;
            #endregion
            #region Outgoing Events
            Triggers.HostDance += Triggers_HostDance;
            Triggers.HostGesture += Triggers_HostGesture;
            Triggers.HostExitRoom += Triggers_HostExitRoom;
            Triggers.HostRaiseSign += Triggers_HostRaiseSign;
            Triggers.HostNavigateRoom += Triggers_HostNavigateRoom;
            Triggers.HostUpdateStance += Triggers_HostUpdateStance;
            #endregion

            MainUI.Connection.DataIncoming += Connection_DataIncoming;
            MainUI.Connection.DataOutgoing += Connection_DataOutgoing;
        }

        #region Incoming Event Handlers
        private void Triggers_EntityAction(object sender, EntityActionEventArgs e)
        { }
        private void Triggers_FurnitureMove(object sender, FurnitureMoveEventArgs e)
        { }
        private async void Triggers_PlayerKickHost(object sender, PlayerKickHostEventArgs e)
        {
            if (!ReEnterOnKick) return;
            if (LastEnteredRoomId == 0) return;

            await MainUI.Connection.SendToServerAsync(Triggers.OutgoingDetected.NavigateRoom,
                LastEnteredRoomId, LastEnteredRoomPassword, -1);
        }
        #endregion
        #region Outgoing Event Handlers
        private void Triggers_HostDance(object sender, HostDanceEventArgs e)
        { }
        private void Triggers_HostGesture(object sender, HostGestureEventArgs e)
        { }
        private void Triggers_HostExitRoom(object sender, HostExitRoomEventArgs e)
        {
            IsInRoom = false;
        }
        private void Triggers_HostRaiseSign(object sender, HostRaiseSignEventArgs e)
        { }
        private void Triggers_HostNavigateRoom(object sender, HostNavigateRoomEventArgs e)
        {
            LastEnteredRoomId = e.RoomId;
            LastEnteredRoomPassword = e.Password;
        }
        private void Triggers_HostUpdateStance(object sender, HostUpdateStanceEventArgs e)
        { }
        #endregion

        private void Connection_DataIncoming(object sender, InterceptedEventArgs e)
        {
            Triggers.HandleIncoming(e);
        }
        private void Connection_DataOutgoing(object sender, InterceptedEventArgs e)
        {
            Triggers.HandleOutgoing(e);
        }
    }
}