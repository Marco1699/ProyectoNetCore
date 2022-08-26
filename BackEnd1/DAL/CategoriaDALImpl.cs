using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BackEnd1.Entities;

namespace BackEnd1.DAL
{
  public class CategoriaDALImpl : ICateogriaDal
    {
        NetCoreFinalContext context;

        public CategoriaDALImpl()
        {
            context = new NetCoreFinalContext();

        }

        public bool Add(Categorium entity)
        {
            try
            {
                //sumar o calcular 

                using (UnidadDeTrabajo<Categorium> unidad = new UnidadDeTrabajo<Categorium>(context))
                {
                    unidad.genericDAL.Add(entity);
                    return unidad.Complete();
                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public void AddRange(IEnumerable<Categorium> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categorium> Find(Expression<Func<Categorium, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Categorium Get(int CategoryId)
        {
            try
            {
                Categorium category;
                using (UnidadDeTrabajo<Categorium> unidad = new UnidadDeTrabajo<Categorium>(context))
                {
                    category = unidad.genericDAL.Get(CategoryId);
                }
                return category;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Categorium> Get()
        {
            try
            {
                IEnumerable<Categorium> categories;
                using (UnidadDeTrabajo<Categorium> unidad = new UnidadDeTrabajo<Categorium>(context))
                {
                    categories = unidad.genericDAL.GetAll();
                }
                return categories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Categorium> GetAll()
        {
            try
            {
                IEnumerable<Categorium> categories;
                using (UnidadDeTrabajo<Categorium> unidad = new UnidadDeTrabajo<Categorium>(context))
                {
                    categories = unidad.genericDAL.GetAll();
                }
                return categories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Categorium entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Categorium> unidad = new UnidadDeTrabajo<Categorium>(context))
                {
                    unidad.genericDAL.Remove(entity);
                    result = unidad.Complete();
                }

            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        public void RemoveRange(IEnumerable<Categorium> entities)
        {
            throw new NotImplementedException();
        }

        public Categorium SingleOrDefault(Expression<Func<Categorium, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categorium category)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Categorium> unidad = new UnidadDeTrabajo<Categorium>(context))
                {
                    unidad.genericDAL.Update(category);
                    result = unidad.Complete();
                }

            }
            catch (Exception)
            {

                return false;
            }

            return result;
        }
    }
}
