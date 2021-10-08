using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileContext
    {
        List<Adult> GetAdults();

        void AddAdult(Adult adult);

    }
}