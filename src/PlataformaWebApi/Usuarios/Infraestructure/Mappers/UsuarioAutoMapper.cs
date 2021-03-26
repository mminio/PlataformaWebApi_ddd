using AutoMapper;
using PlataformaWebApi.Usuarios.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlataformaWebApi.Usuarios.Infraestructure.Mappers
{
    public class UsuarioAutoMapper<Usuario> : IUsuarioMapper<Usuario>
    {
        private readonly IMapper _mapper = Create();
        private static IMapper Create()
        {
            var config = new MapperConfiguration(cfg => {});
            return config.CreateMapper();
        }

        public Usuario Map(object data, Usuario entity)
        {
            dynamic operations = (data as Dictionary<string, object>)
                                .Aggregate(new Dictionary<string, object>(), (a, p) => {
                                    var key = p.Key.Replace("/", "");
                                    a.Add(String.Concat(key, ".", key), p.Value); 
                                    return a;
                                });

            return _mapper.Map(operations, entity);
        }
    }
}
