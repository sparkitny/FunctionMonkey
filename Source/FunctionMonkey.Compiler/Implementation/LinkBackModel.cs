﻿using System;
using System.Collections.Generic;
using System.Text;
using FunctionMonkey.Model;

namespace FunctionMonkey.Compiler.Implementation
{
    internal class LinkBackModel
    {
        public string Namespace { get; set; }

        public string TypeName { get; set; }
        
        public IReadOnlyCollection<ImmutableTypeConstructorParameter> ConstructorParameters { get; set; }
    }
}