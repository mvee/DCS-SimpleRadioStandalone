﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciribob.DCS.SimpleRadio.Standalone.Client
{
    public class InputDevice
    {
        //public enum InputBinding
        //{
        //    SWITCH_1,
        //    SWITCH_2,
        //    SWITCH_3,
        //    PTT

        //}

        //public InputBinding InputBind { get; set; }

        public string DeviceName { get; set; }

        public int Button { get; set; }
        public Guid InstanceGUID { get; internal set; }

        public InputDevice()
        {

        }
    }
}