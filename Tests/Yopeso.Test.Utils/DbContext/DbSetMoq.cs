using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Yopeso.Test.Utils.DbContext
{
    public class DbSetMoq
    {
        /// <summary>
        /// Creates a stub for the given T model type
        /// </summary>
        /// <param name="data"> a queryable list of values</param>
        /// <typeparam name="T"> model's type</typeparam>
        /// <returns>database set of values for the given T</returns>
        public static Mock<DbSet<T>> CreateDBSet<T>(IQueryable<T> data) where T : class
        {
            var testMockSet = new Mock<DbSet<T>>();
            testMockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
            testMockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
            testMockSet.As<IQueryable<T>>().Setup(m => m.ElementType)
                .Returns(data.ElementType);
            testMockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator())
                .Returns(data.GetEnumerator());
            return testMockSet;
        }
    }
}