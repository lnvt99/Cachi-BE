using AutoMapper;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mapper: Profile
    {
        public Mapper() { 
            CreateMap<ExampleModel, ExampleResponse>();
        }
    }
}
