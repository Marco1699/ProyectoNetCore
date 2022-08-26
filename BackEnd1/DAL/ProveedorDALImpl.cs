using BackEnd1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BackEnd1.DAL
{
    public class ProveedorDALImpl : IProveedorDal
    {
        NetCoreFinalContext context;

        public ProveedorDALImpl()
        {
            context = new NetCoreFinalContext();

        }

        public bool Add(Proveedore entity)
        {
            try
            {
                //sumar o calcular 

                using (UnidadDeTrabajo<Proveedore> unidad = new UnidadDeTrabajo<Proveedore>(context))
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

        public void AddRange(IEnumerable<Proveedore> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedore> Find(Expression<Func<Proveedore, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Proveedore Get(int CategoryId)
        {
            try
            {
                Proveedore category;
                using (UnidadDeTrabajo<Proveedore> unidad = new UnidadDeTrabajo<Proveedore>(context))
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

        public List<Proveedore> Get()
        {
            try
            {
                IEnumerable<Proveedore> categories;
                using (UnidadDeTrabajo<Proveedore> unidad = new UnidadDeTrabajo<Proveedore>(context))
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

        public IEnumerable<Proveedore> GetAll()
        {
            try
            {
                IEnumerable<Proveedore> categories;
                using (UnidadDeTrabajo<Proveedore> unidad = new UnidadDeTrabajo<Proveedore>(context))
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

        public bool Remove(Proveedore entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Proveedore> unidad = new UnidadDeTrabajo<Proveedore>(context))
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

        public void RemoveRange(IEnumerable<Proveedore> entities)
        {
            throw new NotImplementedException();
        }

        public Proveedore SingleOrDefault(Expression<Func<Proveedore, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(Proveedore category)
        {
            bool result = false;

            try
            {
                using (UnidadDeTrabajo<Proveedore> unidad = new UnidadDeTrabajo<Proveedore>(context))
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
