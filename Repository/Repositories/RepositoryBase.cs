using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Contexts;

namespace Repository.Repositories;

/// <summary>
/// A generic repository base class providing CRUD operations on entities.
/// </summary>
/// <typeparam name="T">The type of the entity this repository works with. Must be a class.</typeparam>
public class RepositoryBase<T> : IRepositoryBase<T> where T : class {
    private readonly MainContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="RepositoryBase{T}"/> class.
    /// </summary>
    /// <param name="context">The database context to be used by the repository.</param>
    public RepositoryBase(MainContext context) {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    /// <summary>
    /// Creates a new entity in the database.
    /// </summary>
    /// <param name="item">The entity to add.</param>
    /// <returns>The added entity.</returns>
    public T Create(T item) {
        EntityEntry<T> newItem = _context.Set<T>().Add(item);
        Save();
        return newItem.Entity;
    }

    /// <summary>
    /// Deletes an entity from the database.
    /// </summary>
    /// <param name="item">The entity to remove.</param>
    public void Delete(T item) {
        _context.Set<T>().Remove(item);
        Save();
    }

    /// <summary>
    /// Retrieves all entities of type T.
    /// </summary>
    /// <returns>An <see cref="IQueryable{T}"/> containing all the entities.</returns>
    public IQueryable<T> FindAll() {
        return _context.Set<T>();
    }

    /// <summary>
    /// Finds entities based on a condition.
    /// </summary>
    /// <param name="condition">The condition to evaluate for each entity.</param>
    /// <returns>An <see cref="IQueryable{T}"/> containing the entities that match the condition.</returns>
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition) {
        return _context.Set<T>().Where(condition);
    }

    /// <summary>
    /// Saves all changes made in the context to the database.
    /// </summary>
    public void Save() {
        _context.SaveChanges();
    }

    /// <summary>
    /// Updates an existing entity in the database.
    /// </summary>
    /// <param name="item">The entity to update.</param>
    /// <returns>The updated entity.</returns>
    public T Update(T item) {
        EntityEntry<T> updatedItem = _context.Set<T>().Update(item);
        Save();
        return updatedItem.Entity;
    }
}
