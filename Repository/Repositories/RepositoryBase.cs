using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Contexts;

namespace Repository.Repositories {
	public class RepositoryBase<T>(MainContext context) : 
		IRepositoryBase<T> where T : class
	{
		private readonly MainContext _context = context ?? throw new ArgumentNullException(nameof(context));

		public T Create(T item) {
			EntityEntry<T> newItem = _context.Set<T>().Add(item);
			Save();
			return newItem.Entity;
		}

		public void Delete(T item) {
			_context.Set<T>().Remove(item);
			Save();
		}

		public IQueryable<T> FindAll() {
			return _context.Set<T>();
		}

		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition) {
			return _context.Set<T>().Where(condition);
		}

		public void Save() {
			_context.SaveChanges();
		}

		public T Update(T item) {
			EntityEntry<T> updatedItem = _context.Set<T>().Update(item);
			Save();
			return updatedItem.Entity;
		}
	}
}
