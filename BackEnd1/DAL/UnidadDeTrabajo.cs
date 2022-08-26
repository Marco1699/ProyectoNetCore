using BackEnd1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd1.DAL
{
    public class UnidadDeTrabajo<T> : IDisposable where T : class
    {
        private readonly NetCoreFinalContext context;
        //public IDALGenerico<Queja> quejaDAL;
        //public IDALGenerico<TablaGeneral> tablaDAL;
        public IDALGenerico<T> genericDAL;


        public UnidadDeTrabajo(NetCoreFinalContext _context)
        {
            context = _context;
            genericDAL = new DALGenericoImpl<T>(context);
          
        }

        public bool Complete()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string msj = e.Message;
                return false;
            }

        }


        public void Dispose()
        {
            context.Dispose();
        }
    }
}
