﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012
{
    public class RecetaRepository : IRecetaRepository
    {
        public Receta Create(Receta receta)
        {
            return receta;
        }
    }
}
