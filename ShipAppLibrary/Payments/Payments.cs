using ShipAppLibrary.User;
using System;
using System.Collections.Generic;
using System.Text;
using ShipAppLibrary.Shipment;

namespace ShipAppLibrary
{
    class Payments : Shipment
        {
            public IDP dr;
            private string paymentmode;
            private string cost;
        }
    
}
