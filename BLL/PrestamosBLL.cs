using RegistroPersona.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersona.BLL
{
    public class PrestamosBLL
    {
        private Contexto _dbContext;

        public PrestamosBLL(Contexto _dbContext)
        {
            this._dbContext = _dbContext;
        }
    }
}
