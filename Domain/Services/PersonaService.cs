using Entities;
using Microsoft.EntityFrameworkCore;
using Domain.Validations;

namespace Domain.Services
{
    public class PersonaService
    {
        private readonly PersonaValidation personaValidation;

        public PersonaService()
        {
            personaValidation = new PersonaValidation();
        }

        public Persona? Add(Persona persona)
        {
            using var context = new AcademiaContext();
            if (personaValidation.isValid(persona))
            {
                context.Personas.Add(persona);
                context.SaveChanges();
                return persona;
            }
            return null;

        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            Persona? personaToDelete = context.Personas.Find(id);

            if (personaToDelete != null)
            {
                personaToDelete.activo = false;

                context.SaveChanges();
            }
        }

        public Persona? Get(int? id)
        {
            if (id == null) return null;

            using var context = new AcademiaContext();
            var persona = context.Personas.Find(id);
            if(persona == null || persona.activo == false) return null; 
            return persona;
        }

        public List<PersonaDto> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Personas
                .Where(p => p.activo) 
                .Select(p => new PersonaDto
                {
                    id_persona = p.id_persona,
                    nombre = p.nombre,
                    apellido = p.apellido,
                    direccion = p.direccion,
                    email = p.email,
                    telefono = p.telefono,
                    fecha_nac = p.fecha_nac
                })
                .ToList();
        }

        public void Update(Persona persona)
        {
            using var context = new AcademiaContext();
            Persona? personaToUpdate = context.Personas.Find(persona.id_persona);

            if (personaValidation.isValid(persona) && personaToUpdate != null)
            {
                personaToUpdate.nombre = persona.nombre;
                personaToUpdate.apellido = persona.apellido;
                personaToUpdate.direccion = persona.direccion;
                personaToUpdate.email = persona.email;
                personaToUpdate.telefono = persona.telefono;
                personaToUpdate.fecha_nac = persona.fecha_nac;

                context.SaveChanges();
            }
        }
    }
}
