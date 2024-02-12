using AutoMapper;
using Domaine.DataEntity.PersonneModel;
using Domaine.Dto.PersonneDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MappingHelpers.PersonneMappingHelpers
{
    public class PersonneMapping : Profile
    {
        public PersonneMapping()
        {
            CreateMap<PersonneRequest, Personne>();
            CreateMap<Personne, PersonneRequest>();

            CreateMap<Personne, PersonneResponse>();
            CreateMap<PersonneResponse,Personne>();
        }
    }
}
