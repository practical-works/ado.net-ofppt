﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO_ManipulationDonnées
{
    class ValeurInvalideException : Exception
    {
        public override string Message
        {
            get
            {
                return "Valeur hors limite!";
            }
        }
    }
}
