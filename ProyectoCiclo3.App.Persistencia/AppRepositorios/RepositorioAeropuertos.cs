using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
     private readonly AppContext _appContext = new AppContext();  
        public IEnumerable<Aeropuertos> GetAll()
        {
            return _appContext.Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertosWithId(int id){
          return _appContext.Aeropuertos.Find(id);
        }
        public Aeropuertos Create(Aeropuertos newAeropuerto)
        {
         var addAeropuerto = _appContext.Aeropuertos.Add(newAeropuerto);
            _appContext.SaveChanges();
            return addAeropuerto.Entity;
        }
    public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.dirección = newAeropuerto.dirección;
                
            }
        return aeropuerto;
        }
    public void Delete(int id)
        {
        var aeropuerto = _appContext.Aeropuertos.Find(id);
        if (aeropuerto == null)
            return;
        _appContext.Aeropuertos.Remove(aeropuerto);
        _appContext.SaveChanges();
        }

    }
}
