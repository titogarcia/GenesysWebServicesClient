﻿using Genesys.WebServicesClient.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesys.WebServicesClient.Components
{
    public class GenesysDevice : NotifyPropertyChangedComponent
    {
        [Category("Activation")]
        public GenesysUser User
        {
            get { return (GenesysUser)parentComponent; }
            set { parentComponent = value; }
        }

        int deviceIndex = 0;

        [Category("Activation")]
        public int DeviceIndex
        {
            get { return deviceIndex; }
            set { deviceIndex = value; }
        }

        string id;

        protected override void ActivateImpl()
        {
            if (deviceIndex < 0)
                throw new InvalidOperationException("DeviceIndex must be >= 0");

            User.GenesysEventReceivedInternal += User_GenesysEventReceivedInternal;
            User.ResourceUpdatedInternal += User_ResourceUpdatedInternal;
        }

        protected override void DeactivateImpl()
        {
            id = null;
        }

        void User_GenesysEventReceivedInternal(GenesysEvent e)
        {
            if (e.MessageType == "DeviceStateChangeMessage")
                RefreshDevice(e.GetResourceAsType<IReadOnlyList<DeviceResource>>("devices"));
        }

        void User_ResourceUpdatedInternal(UserResource user)
        {
            RefreshDevice(user.devices);
        }

        void RefreshDevice(IReadOnlyList<DeviceResource> devices)
        {
            var device = ObtainDevice(devices);
            if (device == null)
                return;

            ChangeAndNotifyProperty("UserState", device.userState);
        }

        DeviceResource ObtainDevice(IReadOnlyList<DeviceResource> devices)
        {
            DeviceResource device = null;
            if (id == null)
            {
                if (devices.Count() > 0)
                {
                    device = devices[deviceIndex];
                    id = device.id;
                }
            }
            else
            {
                device = devices.FirstOrDefault(d => id == d.id);
            }

            return device;
        }

        // [Browsable(false)], needs to be Browsable for enabling data binding to its properties.
        public UserState UserState
        {
            get;
            private set;
        }
    }
}
