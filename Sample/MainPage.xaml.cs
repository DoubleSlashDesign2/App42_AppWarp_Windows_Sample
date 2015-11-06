using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using com.shephertz.app42.gaming.multiplayer.client;

namespace AppWarp_WP7_TestSDK
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Initializing Connection ###########");
            
            // Please update with the Api and Secret Key pair received when signing up.
            WarpClient.initialize("9a7aa0b7b252e248d960bcf15da962f69293be42d85ff92cd27032b2373a4185", "450b40f7065716ac8cbe000f51dd2532a5938e6039518555a943f664be96d0ac");
            //
            
            WarpClient game = WarpClient.GetInstance();
            game.AddConnectionRequestListener(new ConListen(this));
            game.AddZoneRequestListener(new ZoneReqListener(this));
            game.AddRoomRequestListener(new RoomReqListener(this));
            game.AddNotificationListener(new NotificationListener(this));
            game.AddLobbyRequestListener(new LobbyReqListen(this));
            //game.Connect();
        }

        public void showResult(String result)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                resutlBlock.Text = result;
            });
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            WarpClient.GetInstance().Connect(inputBox.Text);
        }

        private void joinButton_Click(object sender, RoutedEventArgs e)
        {
            WarpClient.GetInstance().JoinRoom(this.inputJoinRoomIdBox.Text);
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {            
            Dictionary<string,object> tabelProperties = new Dictionary<string,object>();
            WarpClient.GetInstance().CreateRoom(inputCreateRoomBox.Text, inputBox.Text, 5, tabelProperties);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}