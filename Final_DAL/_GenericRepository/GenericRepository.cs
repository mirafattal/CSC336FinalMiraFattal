using Final_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DAL._GenericRepository
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
            public readonly DbSet<T> _dbSet;
            public readonly AirplaneSystemContext _airplaneSystemContext;

            public GenericRepository(AirplaneSystemContext umsContext)
            {
                _airplaneSystemContext = umsContext;
                _dbSet = _airplaneSystemContext.Set<T>();
            }
            public T Add(T t)
            {
                var result = _dbSet.Add(t);
                _airplaneSystemContext.SaveChanges();
                return t;

            }

            public IEnumerable<T> GetAll()
            {
                return _dbSet.ToList();
            }

            public async Task<IEnumerable<T>> GetAllAsync()
            {
                return await _dbSet.ToListAsync();
            }

            public T GetById(int id)
            {
                return _dbSet.Find(id);
            }

            public T Update(T t)
            {
                _dbSet.Update(t);
                try
                {
                    _airplaneSystemContext.SaveChanges();

                }
                catch
                {

                }
                return t;
            }


            public bool Delete(T t)
            {
                _dbSet.Remove(t);
                try
                {
                    _airplaneSystemContext.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }

            public bool Delete(int id)
            {
                var entity = GetById(id);

                return Delete(entity);

            }

        }
    }
