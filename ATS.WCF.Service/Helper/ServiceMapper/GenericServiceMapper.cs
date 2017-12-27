using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ATS.WCF.Service.Helper.ServiceMapper
{
    /// <summary>
    /// Generic Mapper class
    /// </summary>
    /// <typeparam name="source">The type of the ource.</typeparam>
    /// <typeparam name="destination">The type of the estination.</typeparam>
    public class GenericServiceMapper<source, destination>
        where source : class
        where destination : class
    {
        /// <summary>Maps the service dto.</summary>
        /// <param name="Entity">The entity.</param>
        /// <returns></returns>
        public static destination MapServiceToDto(source Entity)
        {
            Mapper.Initialize(cfg=> {
                cfg.CreateMap<source, destination>();

            });
            var dto = Mapper.Map<source, destination>(Entity);

            return dto;
        }
        /// <summary>Maps the dto to service.</summary>
        /// <param name="Entity">The entity.</param>
        /// <returns></returns>
        public static source MapDtoToService(destination Entity)
        {
            Mapper.Initialize(cfg=> {
                cfg.CreateMap<source, destination>();

            });
            var dto = Mapper.Map<destination, source>(Entity);

            return dto;
        }
        /// <summary>Maps the service dto.</summary>
        /// <param name="Entity">The entity.</param>
        /// <returns></returns>
        public static List<destination> MapServiceDto(List<source> entity)
        {
            Mapper.Initialize(cfg=> {
                cfg.CreateMap<source, destination>();

            });
            var dto = Mapper.Map< List<destination>>(entity);

            return dto;
        }
        /// <summary>Maps the dto to service.</summary>
        /// <param name="Entity">The entity.</param>
        /// <returns></returns>
        public static List<source> MapDtoToService(List<destination> Entity)
        {
            Mapper.Initialize(cfg=> {
                cfg.CreateMap<source, destination>();

            });
            var dto = Mapper.Map<List<destination>, List<source>>(Entity);

            return dto;
        }
    }
}