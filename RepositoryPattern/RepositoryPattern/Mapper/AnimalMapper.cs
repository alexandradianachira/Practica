using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Mapper
{
    public static class AnimalMapper
    {
        public static Animal ToModelUi(this Repository.Models.Animal animal)
        {
            return new Animal()
            {
                Id = animal.Id,
                Name = animal.Name

            };
        }

    public static Repository.Models.Animal ToModelDb(this Animal animal)
        {
            return new Repository.Models.Animal()
            {
                Id = animal.Id,
                Name = animal.Name
            };
        }
    }
}