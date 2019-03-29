﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Builder
{
    public class WidgetDirector : WagDirector
    {
        public override IWag Build(WagBuilder wagBuilder)
        {
            wagBuilder.BuildWidgetParts();

            return wagBuilder.Widget;
        }
    }
}
