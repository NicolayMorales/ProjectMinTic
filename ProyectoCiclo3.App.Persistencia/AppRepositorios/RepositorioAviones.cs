using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Boeing 747",modelo= 2018,num_asientos= 660,Wc= 10,cap_maxima= 550},
                new Aviones{id=2,marca="AirBusA340",modelo= 2019, num_asientos= 359,Wc= 7, cap_maxima= 140640}, 
                new Aviones{id=3,marca="Atr-72",modelo= 2020,num_asientos= 62,Wc= 2,cap_maxima= 150},
                new Aviones{id=4,marca="Boeing 787",modelo= 2000, num_asientos= 240,Wc= 7, cap_maxima= 80}
 
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetAvionesWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }
        public Aviones Create(Aviones newAvion)
        {
           if(aviones.Count > 0){
           newAvion.id=aviones.Max(r => r.id) +1; 
            }else{
               newAvion.id = 1; 
            }
           aviones.Add(newAvion);
           return newAvion;
        }

    public Aviones Update(Aviones newAviones){
            var avion= aviones.SingleOrDefault(b => b.id == newAviones.id);
            if(avion != null){
                avion.marca = newAviones.marca;
                avion.modelo = newAviones.modelo;
                avion.Wc = newAviones.Wc;
                avion.num_asientos = newAviones.num_asientos;
                avion.cap_maxima = newAviones.cap_maxima;
                
            }
        return avion;
        }

    public Aviones Delete(int id)
        {
        var avion= aviones.SingleOrDefault(b => b.id == id);
        aviones.Remove(avion);
        return avion;
        }

    }
}
