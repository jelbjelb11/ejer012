﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012
{
    //ejemplo de patron Singleton
    public class CafeteraSingleton
    {
        private static CafeteraSingleton instance;

        private CafeteraSingleton()
        {

        }

        public static CafeteraSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new CafeteraSingleton();
            }
            return instance;
        }
            

    }
}
