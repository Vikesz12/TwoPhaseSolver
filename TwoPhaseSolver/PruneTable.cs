﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseSolver
{
    public class PruneTable
    {
        byte[] bytes;

        public PruneTable(int size)
        {
            bytes = new byte[size / 2];
        }

        public PruneTable(byte[] bytes)
        {
            this.bytes = bytes;
        }

        public byte this[int index]
        {
            get
            {
                if ((index & 1) == 1) { return (byte)((bytes[index / 2] & 0xf0) >> 4); }
                else { return (byte)(bytes[index / 2] & 0x0f); }
            }
            set
            {
                if ((index & 1) == 1) { bytes[index / 2] &= (byte)(0x0f | (value << 4)); }
                else { bytes[index / 2] &= (byte)(value | 0xf0); }
            }
        }

        // Prune tables

        public static readonly PruneTable pruneCO = new PruneTable(Properties.Resources.co_ud_prun);
        public static readonly PruneTable pruneEO = new PruneTable(Properties.Resources.eo_ud_prun);

        public static readonly PruneTable pruneCP = new PruneTable(Properties.Resources.cp_ud2_prun);
        public static readonly PruneTable pruneEP2 = new PruneTable(Properties.Resources.ep2_ud2_prun);
    }
}
