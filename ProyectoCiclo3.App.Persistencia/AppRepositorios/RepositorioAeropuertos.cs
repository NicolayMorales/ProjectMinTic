using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
 
    public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,nombre="Bog",ciudad="Bog",pais="Cuba",dirección= 660},
                new Aeropuertos{id=2,nombre="Air",ciudad= "Bog",pais="Chile", dirección= 359}, 
                new Aeropuertos{id=3,nombre="Atr",ciudad= "Bog",pais="Panama",dirección= 62},
                new Aeropuertos{id=4,nombre="Bo",ciudad= "Bog",pais="Colombia", dirección= 240}
 
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetAeropuertosWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }
        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
           if(aeropuertos.Count > 0){
           newAeropuerto.id=aeropuertos.Max(r => r.id) +1; 
            }else{
               newAeropuerto.id = 1; 
            }
           aeropuertos.Add(newAeropuerto);
           return newAeropuerto;
        }

    public Aeropuertos Update(Aeropuertos newAeropuertos){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuertos.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuertos.nombre;
                aeropuerto.ciudad = newAeropuertos.ciudad;
                aeropuerto.pais = newAeropuertos.pais;
                aeropuerto.dirección = newAeropuertos.dirección;
                
            }
        return aeropuerto;
        }
    }
}
