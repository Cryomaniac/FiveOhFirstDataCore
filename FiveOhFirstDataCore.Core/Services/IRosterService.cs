﻿using FiveOhFirstDataCore.Core.Account;
using FiveOhFirstDataCore.Core.Data.Roster;
using FiveOhFirstDataCore.Core.Structures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveOhFirstDataCore.Core.Services
{
    public interface IRosterService
    {
        public Task<List<Trooper>> GetPlacedRosterAsync();
        public Task<List<Trooper>> GetActiveReservesAsync();
        public Task<List<Trooper>> GetInactiveReservesAsync();
        public Task<List<Trooper>> GetArchivedTroopersAsync();
        public Task<List<Trooper>> GetFullRosterAsync();
        public Task<List<Trooper>> GetUnregisteredTroopersAsync();
        public Task<OrbatData> GetOrbatDataAsync();
        public Task<ZetaOrbatData> GetZetaOrbatDataAsync();
        public Task<(HashSet<int>, HashSet<string>)> GetInUseUserDataAsync();

        public Task<RegisterTrooperResult> RegisterTrooper(NewTrooperData trooperData);
    }
}