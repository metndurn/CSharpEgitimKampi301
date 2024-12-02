using CSharpEgitimKampi301.DataAccsessLayer.Abstract;
using CSharpEgitimKampi301.DataAccsessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccsessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		CampContext context = new CampContext();//nesne turettik
		private readonly DbSet<T> _object;//bu bir field demektir
        public GenericRepository()
        {
			_object = context.Set<T>();
        }
        public void Delete(T entity)
		{
			var deletedEntity = context.Entry(entity);
			deletedEntity.State = EntityState.Detached;
			context.SaveChanges();
		}
		public List<T> GetAll()
		{
			return _object.ToList();
		}
		public T GetById(int id)
		{
			return _object.Find(id);
		}
		public void Insert(T entity)
		{
			var addedEntity = context.Entry(entity);
			addedEntity.State = EntityState.Added;
			context.SaveChanges();
		}
		public void Update(T entity)
		{
			var updatedEntity = context.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			context.SaveChanges();
		}
	}
}
