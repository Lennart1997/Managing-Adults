using System.Collections.Generic;
using Models;

namespace ToDo.Data
{
    public interface IFamilyService
    {
        List<Adult> GetAdults();
        
        void AddAdult(Adult adult);
    }
}