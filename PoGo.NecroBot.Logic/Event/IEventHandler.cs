﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGo.NecroBot.Logic.Event
{
    public interface IEventHandler
    {
        void OnEvent(IEvent evt);
    }
}