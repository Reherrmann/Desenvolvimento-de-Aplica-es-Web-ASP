using System;
using Amigos.services.interfaces;
using Base.Domain;
using Base.Domain.Entities;



namespace Amigos.services
{
	public class AmigosService : IAmigosService
    {
        public List<EAmigos> GetAmigos()
        {
            var amigo = new EAmigos();
            
            amigo.Nome = "Renan";
            amigo.Sobrenome = "Herrmann";
            amigo.Dn = 32;

            


            var amigos = new List<EAmigos>();
            amigos.Add(amigo);

            return amigos;

           
        }

        public List<EAmigos> GetAmigosSelected(List<int> selected)
        {
            throw new NotImplementedException();
        }
    }
    }

