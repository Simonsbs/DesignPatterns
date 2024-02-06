using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repositories;

/// <summary>
/// Defines a basic interface for repository operations, encapsulating common CRUD functionalities.
/// </summary>
/// <typeparam name="T">The entity type this repository works with.</typeparam>
public interface IRepositoryBase<T> where T : class {
	/// <summary>
	/// Retrieves all instances of type T.
	/// </summary>
	/// <returns>An IQueryable of T representing all instances.</returns>
	IQueryable<T> FindAll();

	/// <summary>
	/// Retrieves instances of type T that satisfy a specified condition.
	/// </summary>
	/// <param name="condition">A lambda expression representing the condition to filter the instances.</param>
	/// <returns>An IQueryable of T representing the filtered instances.</returns>
	IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition);

	/// <summary>
	/// Adds a new instance of type T to the repository.
	/// </summary>
	/// <param name="item">The instance to add.</param>
	/// <returns>The added instance.</returns>
	T Create(T item);

	/// <summary>
	/// Updates an existing instance of type T in the repository.
	/// </summary>
	/// <param name="item">The instance to update.</param>
	/// <returns>The updated instance.</returns>
	T Update(T item);

	/// <summary>
	/// Removes an instance of type T from the repository.
	/// </summary>
	/// <param name="item">The instance to remove.</param>
	void Delete(T item);

	/// <summary>
	/// Saves all changes made in the repository to the underlying data store.
	/// </summary>
	void Save();
}