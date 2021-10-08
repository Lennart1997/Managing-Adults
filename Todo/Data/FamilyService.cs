using System.Collections.Generic;
using FileData;
using Models;

namespace ToDo.Data
{
    public class FamilyService : IFamilyService
    {
        private IFileContext FileContext; 
        
        public FamilyService()
        {
            FileContext = new FileContext();
        }
        
        public List<Adult> GetAdults()
        {
            return FileContext.GetAdults();
        }
        
        public void AddAdult(Adult adult)
        {
            FileContext.AddAdult(adult);
        }
        
    }
}