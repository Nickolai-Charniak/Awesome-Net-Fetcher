using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace AwesomeNet.Infrastructure.Helpers
{
    //Stub classes, until I will used monads and some other stuff
    //In other hand, maybe will be rewrite according with any others ideas

    /// <summary>
    /// Represent stuff to make code contracts - asserts and requirements according business or devs rules  
    /// </summary>
    public static class CodeContract
    {
        /// <summary>
        /// Check provided condition, and if it fail - throw exception
        /// </summary>
        /// <param name="condition">user provided condition</param>
        /// <param name="userMessage">message for semantic exception</param>
        /// <typeparam name="TException">Any type which inherited from standard Exception</typeparam>
        /// <exception cref="TException">User exception for condition failed event</exception>
        public static void Requires<TException>(bool condition, string userMessage) where TException : Exception
        {
            if (condition != false) return;
            var errMessage = userMessage == null ? "" : $" '{userMessage}'";
            if (Activator.CreateInstance(typeof(TException), "Contract Requires condition" + errMessage) is TException
                exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Check provided condition, and if it fail - throw CodeContractException exception
        /// </summary>
        /// <param name="condition">user provided condition</param>
        /// <param name="userMessage">message for semantic exception</param>
        public static void Requires(bool condition, string userMessage) =>
            Requires<CodeContractException>(condition, userMessage);

        /// <summary>Determines whether all the elements in a collection exist within a function.</summary>
        /// <param name="collection">The collection from which elements of type T will be drawn to pass to <paramref name="predicate" />.</param>
        /// <param name="predicate">The function to evaluate for the existence of all the elements in <paramref name="collection" />.</param>
        public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            return collection.All(obj => predicate(obj));
        }
    }

    /// <summary>
    /// The exception raised from CodeContract 
    /// </summary>
    [Serializable]
    public class CodeContractException : Exception
    {
        public CodeContractException()
        {
        }

        public CodeContractException(string message) : base(message)
        {
        }

        public CodeContractException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CodeContractException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}