﻿using System;

namespace DamageMeter
{
    public class Duration : ICloneable
    {
        public Duration(long begin, long end)
        {
            End = end;
            Begin = begin;
        }

        public long Begin { get; }
        public long End { get; set; }

        public object Clone()
        {
            return new Duration(Begin, End);
        }

    }
}