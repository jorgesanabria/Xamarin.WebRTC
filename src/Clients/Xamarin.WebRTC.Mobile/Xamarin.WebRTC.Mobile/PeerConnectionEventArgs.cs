﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.WebRTC.Mobile
{
    public class PeerConnectionEventArgs : EventArgs
    {
        public string PeerId { get; set; }
    }
}
