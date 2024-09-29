
using System.Linq.Expressions;


namespace Core.Interfaces
{
    public interface ISpecification<T>
    {
        /*
         * 
         * Criteria. This property is an Expression<Func<T, bool>>,
         * which is a predicate (function) that can be used to filter
         * a collection or query a database.
         * 
         * Criteria is an expression that returns true or 
         * false for any given entity of type T.
         */
        Expression<Func<T, bool>>? Criteria { get; }
        Expression<Func<T, object>>? OrderBy { get; }
        Expression<Func<T, object>>? OrderByDescending { get; }
        bool IsDistinct { get; }

    }
    public interface ISpecification<T,TResult> : ISpecification<T>
    {

        Expression<Func<T, TResult>>? Select { get; }

    }
}
