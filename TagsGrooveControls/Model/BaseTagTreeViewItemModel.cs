﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TagsGrooveControls.Model
{
    public class BaseTagTreeViewItemModel : TagTreeViewItemModel    
    {

        public override bool IsNameMode
        {
            get
            {
                return false;
            }
        }

        public BaseTagTreeViewItemModel(int id)
            : base(id)
        {
        }

        public override bool IsBase()
        {
            return true;
        }
    }
}
