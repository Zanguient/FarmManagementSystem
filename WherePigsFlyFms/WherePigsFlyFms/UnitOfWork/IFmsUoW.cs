﻿using WherePigsFlyFms.Models;
using WherePigsFlyFms.Repository;

namespace WherePigsFlyFms.UnitOfWork
{
    public interface IFmsUoW
    {
        GenericRepository<Animals> AnimalRepo { get; }
        //GenericRepository<MedicalRecords> MedicalRepo { get; }
        GenericRepository<MedLookupModel> LookupRepo { get; }
        GenericRepository<VaccinationModel> VaccineRepo { get; }
        void Commit();
    }
}