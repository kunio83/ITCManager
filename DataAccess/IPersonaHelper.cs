﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    interface IPersonaHelper
    {
        List<Persona> GetPersonas();

        Persona GetPersonaById(int idPersona);

    }
}
