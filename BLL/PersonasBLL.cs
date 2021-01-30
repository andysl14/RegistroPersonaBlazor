using Microsoft.EntityFrameworkCore;
using RegistroPersona.DAL;
using RegistroPersona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RegistroPersona.BLL
{
    public class PersonasBLL
    {
        private Contexto _dbContext;

        public PersonasBLL(Contexto _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public async Task<bool> Existe(int id)
        {
            bool pass = false;
            try
            {
                pass = await _dbContext.Personas.AnyAsync(p => p.PersonaId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return pass;
        }

        private async Task<bool> Insertar(Personas persona)
        {
            bool pass = false;

            try
            {
                await _dbContext.Personas.AddAsync(persona);
                pass = await _dbContext.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return pass;
        }

        public async Task<bool> Modificar(Personas persona)
        {
            bool pass = false;

            try
            {
                _dbContext.Entry(persona).State = EntityState.Modified;
                pass = await _dbContext.SaveChangesAsync() > 0;
            }
            catch
            {
                throw;
            }

            return pass;
        }

        public async Task<bool> Guardar(Personas persona)
        {
            if (!await Existe(persona.PersonaId))
                return await Insertar(persona);
            else
                return await Modificar(persona);
        }

        public async Task<Personas> Buscar(int id)
        {
            Personas persona;

            try
            {
                //where(p => p.PersonaId==Id).AsNoTracking.FirstOrDefaultAsync();
                persona = await _dbContext.Personas.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

            return persona;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool eliminado = false;

            try
            {
                var encontrado = await _dbContext.Personas.FindAsync(id);
                if (encontrado != null)
                {
                    _dbContext.Personas.Remove(encontrado);
                    eliminado = await _dbContext.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return eliminado;
        }

        public async Task<List<Personas>> GetPersonas()
        {
            List<Personas> lista = new List<Personas>();

            try
            {
                lista = await _dbContext.Personas.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }


            return lista;
        }

        public async Task<List<Personas>> GetPersonas(Expression<Func<Personas, bool>> criterio)
        {
            List<Personas> lista = new List<Personas>();

            try
            {
                lista = await _dbContext.Personas.Where(criterio).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
    
}
