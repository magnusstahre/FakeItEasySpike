﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeLab
{
    public interface ICandyShop
    {
        ICandy GetTopSellingCandy();
        void BuyCandy(ICandy lollipop);
    }
}
