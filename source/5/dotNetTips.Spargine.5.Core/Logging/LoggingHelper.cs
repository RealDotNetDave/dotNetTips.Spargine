//![](05CD5CE05AF2C0FDDE3210EB79859750_1.png;http://dotnettips.com )
// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core
// Author           : David McCarter
// Created          : 09-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-09-2020
// ***********************************************************************
// <copyright file="LoggingHelper.cs" company="dotNetTips.Spargine.Core">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using dotNetTips.Spargine.Core.Properties;

namespace dotNetTips.Spargine.Core.Logging
{
    /// <summary>
    /// Logging Helper.
    /// </summary>
    public static class LoggingHelper
    {
        /// <summary>
        /// Retrieves all exception messages.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        [Information(nameof(RetrieveAllExceptionMessages), UnitTestCoverage = 99, Status = Status.Available)]
        public static string[] RetrieveAllExceptionMessages(Exception ex)
        {
            if (ex == null)
            {
                ExceptionThrower.ThrowArgumentNullException(Resources.ExMessageNullException, nameof(ex));
            }

            var exceptions = RetrieveAllExceptions(ex);

            var messages = new string[exceptions.Length];

            for (var i = 0; i < exceptions.Length; i++)
            {
                messages[i] = exceptions[i].Message;
            }

            return messages;
        }

        /// <summary>
        /// Retrieves all exceptions (including inner exceptions).
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>IEnumerable&lt;Exception&gt;.</returns>
        [Information(nameof(RetrieveAllExceptions), UnitTestCoverage = 99, Status = Status.Available)]
        public static Exception[] RetrieveAllExceptions(Exception ex)
        {
            if (ex == null)
            {
                ExceptionThrower.ThrowArgumentNullException(Resources.ExMessageNullException, nameof(ex));
            }

            var collection = new List<Exception>();

            if (ex != null)
            {
                collection = new List<Exception> { ex };

                if (( ex.InnerException is null ) == false)
                {
                    collection.AddRange(RetrieveAllExceptions(ex.InnerException));
                }
            }

            return collection.ToArray();
        }
    }
}
