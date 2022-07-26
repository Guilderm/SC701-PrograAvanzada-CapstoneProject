using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public class LoansStateDALImpl : ILoansStateDAL
    {
        ProyectoCreditosContext context;

        public LoansStateDALImpl()
        {
            context = new ProyectoCreditosContext();
        }

        public bool Add(LoansState entity)
        {
            try
            {
                using (UnidadDeTrabajo<LoansState> unidad = new UnidadDeTrabajo<LoansState>(context))
                {
                    unidad.genericDAL.Add(entity);
                    return unidad.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddRange(IEnumerable<LoansState> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoansState> Find(Expression<Func<LoansState, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LoansState Get(int id)
        {
            try
            {
                LoansState loansStateList;
                using (UnidadDeTrabajo<LoansState> unidad = new UnidadDeTrabajo<LoansState>(context))
                {
                    loansStateList = unidad.genericDAL.Get(id);
                }
                return loansStateList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        List<LoansState> Get()
        {
            try
            {
                IEnumerable<LoansState> loansStateList;
                using (UnidadDeTrabajo<LoansState> unidad = new UnidadDeTrabajo<LoansState>(context))
                {
                    loansStateList = unidad.genericDAL.GetAll();
                }
                return loansStateList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public IEnumerable<LoansState> GetAll()
        {
            try
            {
                IEnumerable<LoansState> loansStateList;
                using (UnidadDeTrabajo<LoansState> unidad = new UnidadDeTrabajo<LoansState>(context))
                {
                    loansStateList = unidad.genericDAL.GetAll();
                }
                return loansStateList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Remove(LoansState entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<LoansState> unidad = new UnidadDeTrabajo<LoansState>(context))
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

        public bool Update(global::BackEndAPI.Models.LoansStateModel loansState)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<LoansState> entities)
        {
            throw new NotImplementedException();
        }

        LoansState IDALGenerico<LoansState>.SingleOrDefault(Expression<Func<LoansState, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(LoansState entity)
        {
            bool result = false;
            try
            {
                using (UnidadDeTrabajo<LoansState> unidad = new UnidadDeTrabajo<LoansState>(context))
                {
                    unidad.genericDAL.Update(entity);
                    result = unidad.Complete();
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

    }
}
