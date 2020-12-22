using CampingOpinionsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CampingOpinionsAPI.Services.Interfaces
{
    public interface IMnenjaRepository
    {
        Task<List<Mnenja>> GetMnenjeByUporabnik(int uporabnik_id);

        Task<List<Mnenja>> GetMnenjeByAvtokamp(int kamp_id);

        Task<Mnenja> GetMnenje(int mnenje_id);

        Task<bool> CreateMnenje(Mnenja mnenje, int kamp_id);

        Task<Mnenja> UpdateMnenje(Mnenja mnenje, int mnenje_id);

        Task<bool> RemoveMnenje(int mnenje_id);
    }
}
