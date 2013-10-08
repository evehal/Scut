﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZyGames.Tianjiexing.Model.Enum
{
    /// <summary>
    /// 商店类型
    /// </summary>
    public enum ShopType
    {
        /// <summary>
        /// 道具
        /// </summary>
        Props  = 1,
        /// <summary>
        /// 礼包
        /// </summary>
        PresendBox,

        /// <summary>
        /// 装备
        /// </summary>
        Equ,
        /// <summary>
        /// 奇石3
        /// </summary>
        Kistler,
        /// <summary>
        /// 黑市4
        /// </summary>
        Blackmarket,
        /// <summary>
        /// 热卖5
        /// </summary>
        Hot,
        /// <summary>
        /// 打折6
        /// </summary>
        Discount,
        /// <summary>
        /// 声望7
        /// </summary>
        Prestige,

        
    }
}