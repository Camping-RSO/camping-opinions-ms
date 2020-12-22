using CampingOpinionsAPI.Models;
using CampingOpinionsAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampingOpinionsAPI.Services
{
    public class MnenjaRepository : IMnenjaRepository
    {
        private readonly avtokampiContext _db;

        public MnenjaRepository(avtokampiContext db)
        {
            _db = db;
        }

        public async Task<List<Mnenja>> GetMnenjeByUporabnik(int uporabnik_id)
        {
            return await _db.Mnenja.Where(o => o.Uporabnik == uporabnik_id).ToListAsync();
        }

        public async Task<List<Mnenja>> GetMnenjeByAvtokamp(int kamp_id)
        {
            return await _db.Mnenja.Where(o => o.Avtokamp == kamp_id).ToListAsync();
        }

        public async Task<Mnenja> GetMnenje(int mnenje_id)
        {
            return await _db.Mnenja.Where(o => o.MnenjeId == mnenje_id).FirstOrDefaultAsync();
        }

        public async Task<bool> CreateMnenje(Mnenja mnenje, int kamp_id)
        {
            await _db.Mnenja.AddAsync(mnenje);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Mnenja> UpdateMnenje(Mnenja mnenje, int mnenje_id)
        {
            _db.Entry(mnenje).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return await _db.Mnenja.FindAsync(mnenje_id);
        }

        public async Task<bool> RemoveMnenje(int mnenje_id)
        {
            _db.Mnenja.Remove(await _db.Mnenja.FindAsync(mnenje_id));
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
