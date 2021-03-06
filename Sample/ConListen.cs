﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using com.shephertz.app42.gaming.multiplayer.client.events;
using com.shephertz.app42.gaming.multiplayer.client.command;
using com.shephertz.app42.gaming.multiplayer.client.listener;

namespace AppWarp_WP7_TestSDK
{
    public class ConListen : ConnectionRequestListener
    {
        private MainPage _page;

        public ConListen(MainPage result)
        {
            _page = result;
        }

        public void onConnectDone(ConnectEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                _page.showResult("connection success");
            }
            else
            {
                _page.showResult("connection fail");
            }

        }

        public void onDisconnectDone(ConnectEvent eventObj)
        {
        }

        public void onInitUDPDone(byte resultCode) { 
        
        }

    }
}
