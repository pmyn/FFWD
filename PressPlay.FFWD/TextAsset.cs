﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;

namespace PressPlay.FFWD
{
    public class TextAsset : Asset
    {
        internal TextAsset()
        {
        }

        internal TextAsset(string text)
        {
            this.text = text;
        }

        [ContentSerializer]
        public string text { get; private set; }

        protected override void DoLoadAsset(AssetHelper assetHelper)
        {            
        }
    }
}
