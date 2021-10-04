using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1 ,origen="BOG" ,destino= "CTG" ,tiempo_estimado= 660},
                new Rutas{id=2 ,origen="CAL" ,destino= "MED" ,tiempo_estimado= 359}, 
                new Rutas{id=3 ,origen="MED" ,destino= "BOG" ,tiempo_estimado= 62},
                new Rutas{id=4 ,origen="CTG" ,destino= "CAL" ,tiempo_estimado= 240}
             };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutasWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
        public Rutas Create(Rutas newRuta)
        {
           if(rutas.Count > 0){
           newRuta.id=rutas.Max(r => r.id) +1; 
            }else{
               newRuta.id = 1; 
            }
           rutas.Add(newRuta);
           return newRuta;
        }

    public Rutas Update(Rutas newRutas){
            var ruta= rutas.SingleOrDefault(b => b.id == newRutas.id);
            if(ruta != null){
                ruta.origen = newRutas.origen;
                ruta.destino = newRutas.destino;
                ruta.tiempo_estimado = newRutas.tiempo_estimado;
                                
            }
        return ruta;
        }
    }
}
