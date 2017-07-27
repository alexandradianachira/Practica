using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class AnimalRepository : IAnimalRepository
    {
        private readonly AnimalContext _animalContext;
        //readonly - s a initializat o data si asa si ramane

        public AnimalRepository(AnimalContext animalContext)
        {
            _animalContext = animalContext;
        }

        public void Add(Animal animal)
        {
            _animalContext.Animals.Add(animal); // e adaugat doar in baza de date 
            _animalContext.SaveChanges(); //

        }

        public void Delete(Animal animal)
        {
            _animalContext.Animals.Remove(animal);
        }

        public void Dispose()
        {
            _animalContext.Dispose();
        }

        public Animal Get(string name)
        {
            return _animalContext.Animals.FirstOrDefault(animal => animal.Name.Equals(name));       }

        public void Save()
        {
            _animalContext.SaveChanges();
        }

        public void GetAll()
        {
            
        }

        public void Update(Animal animal)
        {
            var dbAnimal = _animalContext.Animals.FirstOrDefault(an => an.Id.Equals(animal.Name));
           if(dbAnimal!= null)
            {
                dbAnimal.Name = animal.Name;
            }
                
        }
    }
}
