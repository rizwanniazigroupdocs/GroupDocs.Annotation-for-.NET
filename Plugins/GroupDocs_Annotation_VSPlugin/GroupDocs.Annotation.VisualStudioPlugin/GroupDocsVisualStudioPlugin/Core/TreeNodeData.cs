﻿// Copyright (c) Aspose 2002-2016. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocsAnnotationVisualStudioPlugin.Core
{
    public class TreeNodeData
    {
        string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        Example _example;

        public Example Example
        {
            get { return _example; }
            set { _example = value; }
        }
    }
}
