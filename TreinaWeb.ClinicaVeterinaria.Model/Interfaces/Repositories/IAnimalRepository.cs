﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.ClinicaVeterinaria.Model.Entities;

namespace TreinaWeb.ClinicaVeterinaria.Model.Interfaces.Repositories
{
    public interface IAnimalRepository:IRepositoryBase<Animal>
    {
        IEnumerable<Animal> SearchByName(string name);
    }
}
