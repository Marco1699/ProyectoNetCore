using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BackEnd1.Entities;

namespace BackEnd1.DAL
{
    public class PersonalDALImpl : IPersonalDal
    {
        NetCoreFinalContext context;

        public PersonalDALImpl()
        {
            context = new NetCoreFinalContext();

        }

        public bool Add(Personal entity)
        {
            try
            {
                //sumar o calcular 

                using (UnidadDeTrabajo<Personal> unidad = new UnidadDeTrabajo<Personal>(context))
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

        public void AddRange(IEnumerable<Personal> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personal> Find(Expression<Func<Personal, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Personal Get(int CategoryId)
        {
            try
            {
                Personal category;
                using (UnidadDeTrabajo<Personal> unidad = new UnidadDeTrabajo<Personal>(context))
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

        public List<Personal> Get()
        {
            try
            {
                IEnumerable<Personal> categories;
                using (UnidadDeTrabajo<Personal> unidad = new UnidadDeTrabajo<Personal>(context))
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

        public IEnumerable<Personal> GetAll()
        {
            try
            {
                IEnumerable<Personal> categories;
                using (UnidadDeTrabajo<Personal> unidad = new UnidadDeTrabajo<Personal>(context))
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

        public bool Remove(Personal entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Personal> unidad = new UnidadDeTrabajo<Personal>(context))
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

        public void RemoveRange(IEnumerable<Personal> entities)
        {
            throw new NotImplementedException();
        }

        public Personal SingleOrDefault(Expression<Func<Personal, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Personal category)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Personal> unidad = new UnidadDeTrabajo<Personal>(context))
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
