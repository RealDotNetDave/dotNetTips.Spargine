// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-01-2018
// ***********************************************************************
// <copyright file="ISingleton.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace dotNetTips.Spargine.Core
{
    /// <summary>
    /// Interface ISingleton
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISingleton<T>
        where T : class
    {
        /// <summary>
        /// Returns instance for the object.
        /// </summary>
        /// <returns>T.</returns>
        T Instance();
    }
}