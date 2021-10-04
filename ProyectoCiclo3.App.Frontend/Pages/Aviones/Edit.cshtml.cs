using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class EditAvionesModel : PageModel
    {
        private readonly RepositorioAviones repositorioAviones;
        [BindProperty]
        public Aviones Aviones {get;set;}
 
        public EditAvionesModel(RepositorioAviones repositorioAviones)
       {
            this.repositorioAviones=repositorioAviones;
       }
 
        public IActionResult OnGet(int avionesId)
        {
                Aviones=repositorioAviones.GetAvionesWithId(avionesId);
                return Page();
 
        }
public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aviones.id>0)
            {
            Aviones= repositorioAviones.Update(Aviones);
            }
            return Page();
        }

    }
}
