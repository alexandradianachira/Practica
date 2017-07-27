using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IAnimalRepository : IDisposable
    {
        void Add(Animal animal);

        void Update(Animal animal);

        void Delete(Animal animal);

        Animal Get(String name);

        void Save();

        void GetAll();




    }
}
