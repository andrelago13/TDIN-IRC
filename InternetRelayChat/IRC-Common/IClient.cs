﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC_Common
{
    public interface IClient
    {
        void HandleSessionUpdate(SessionUpdateArgs info);
    }
}
