// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Tester
// Author           : David McCarter
// Created          : 01-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2021
// ***********************************************************************
// <copyright file="PersonCollection.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Tester.Collections
{
    /// <summary>
    /// Class PersonCollection.
    /// Implements the <see cref="System.Collections.Generic.List{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.List{T}" />
    [Serializable]
    public class PersonCollection<T> : List<T> where T : IPerson, new()
    {

        /// <summary>
        /// Initializes a new instance of <see cref="PersonCollection{T}" />.
        /// </summary>
        public PersonCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PersonCollection{T}" />.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new list.</param>
        public PersonCollection(IEnumerable<T> collection) : base(collection)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PersonCollection{T}" />.
        /// </summary>
        /// <param name="capacity">The number of elements that the new list can initially store.</param>
        public PersonCollection(int capacity) : base(capacity)
        {
        }
    }
}
