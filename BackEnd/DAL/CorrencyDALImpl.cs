using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public class CorrencyDALImpl : ICorrencyDAL

    {
        ProyectoCreditosContext context;

        public CorrencyDALImpl()
        {
            context = new ProyectoCreditosContext();
        }

        public bool Add(Corrency entity)
        {
            try
            {
                using (UnidadDeTrabajo<Corrency> unidad = new UnidadDeTrabajo<Corrency>(context))
                {
                    unidad.genericDAL.Add(entity);
                    return unidad.Complete();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void AddRange(IEnumerable<Corrency> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomOrderList> Find(Expression<Func<Corrency, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Corrency Get(int id)
        {
            try
            {
                Corrency correncyslist;
                using (UnidadDeTrabajo<Corrency> unidad = new UnidadDeTrabajo<Corrency>(context))
                {
                    correncyslist = unidad.genericDAL.Get(id);
                }
                return correncyslist;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Corrency> GetAll()
        {
            try
            {
                IEnumerable<Corrency> correncyslist;
                using (UnidadDeTrabajo<Corrency> unidad = new UnidadDeTrabajo<Corrency>(context))
                {
                    correncyslist = unidad.genericDAL.GetAll();
                }
                return correncyslist;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Remove(Corrency entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Corrency> unidad = new UnidadDeTrabajo<Corrency>(context))
                {
                    unidad.genericDAL.Remove(entity);
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        IEnumerable<Corrency> IDALGenerico<Corrency>.Find(Expression<Func<Corrency, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Corrency IDALGenerico<Corrency>.SingleOrDefault(Expression<Func<Corrency, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public void RemoveRange(IEnumerable<Corrency> entities)
        {
            throw new NotImplementedException();
        }

        public bool Update(Corrency entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<Corrency> unidad = new UnidadDeTrabajo<Corrency>(context))
                {
                    unidad.genericDAL.Update(entity);
                    result = unidad.Complete();
                }
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

    }
}
