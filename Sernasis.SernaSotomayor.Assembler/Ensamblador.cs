using Sernasis.SernaSotomayor.ORM;
using SernaSIs.SernaSotomayor.WCF.Contract.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sernasis.SernaSotomayor.Assembler {
    public static class Ensamblador {
        public static Rol ToRol(RolRequest rol)
        {
            return new Rol { Id = rol.Id, Nombre = rol.Nombre };
        }
        public static Tipo ToTipo(TipoRequest tipo)
        {
            return new Tipo
            {
                Id = tipo.Id,
                Nombre = tipo.Nombre
            };
        }
        public static Catalogo ToCatalogo(CatalogoRequest catalogo)
        {
            return new Catalogo
            {
                Id = catalogo.Id, Valor = catalogo.Valor,
                IdTipo = catalogo.Tipo.Id
            };
        }
        public static Ubicacion ToUbicacion(UbicacionRequest ubicacion)
        {
            return new Ubicacion
            {
                Id = ubicacion.Id,
                Abreviatura = ubicacion.Abreviatura,
                Lada = ubicacion.Lada,
                Nombre = ubicacion.Nombre
            };
        }
        public static Persona ToPersona(PersonaRequest request)
        {
            return new Persona
            {
                Domicilio = request.Domicilio,
                Edad = request.Edad,
                Email = request.Email,
                Id = request.Id,
                Nacimiento = request.Nacimiento,
                Nombre = request.Nombre,
                Ocupación = request.Ocupacion,
                Rh = request.Rh
            };
        }
    }

}
