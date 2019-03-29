﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public enum WaGs
    {
        smallwidget, mediumwidget, largewidget, smallgadget, mediumgadget, largegadget
    }
    public class WAGSerialGen
    {
        private static volatile WAGSerialGen instance;
        private string _prefix;
        private int _count;


        private static object synchronizationRoot = new object();

        public static WAGSerialGen Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new WAGSerialGen();
                        }
                    }
                }
                return instance;
            }
        }
        public WAGSerialGen() { }
        public string NextSerial(WaGs waGs)
        {
            int value;
            switch (waGs)
            {
                case WaGs.smallwidget:
                    _prefix = " 02SML";
                    _count = 1245;
                    value = _count++;
                    return _prefix + value;

                case WaGs.mediumwidget:
                    _prefix = " 04MED";
                    _count = 2356;
                    value = _count++;
                    return _prefix + value;
                case WaGs.largewidget:
                    _prefix = " 06LRG";
                    _count = 3467;
                    value = _count++;
                    return _prefix + value;
                case WaGs.smallgadget:
                    _prefix = " 22SML";
                    _count = 1346;
                    value = _count++;
                    return _prefix + value;
                case WaGs.mediumgadget:
                    _prefix = " 44MED";
                    _count = 2457;
                    value = _count++;
                    return _prefix + value;
                case WaGs.largegadget:
                    _prefix = " 66LRG";
                    _count = 3568;
                    value = _count++;
                    return _prefix + value;
                default:
                    _prefix = " 02SSS";
                    _count = 1000;
                    value = _count++;
                    return _prefix + value;

            }
        }
    }
}
