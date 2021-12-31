// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.AspNet
// Author           : David McCarter
// Created          : 02-22-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="ActionResultThrower.cs" company="dotNetTips.Spargine.5.AspNet">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace dotNetTips.Spargine._5.AspNet
{
    /// <summary>
    /// Class ActionResultThrower.
    /// </summary>
    public class ActionResultThrower
    {
        /// <summary>
        /// The controller
        /// </summary>
        static readonly ResultController _controller = new();

        /// <summary>
        /// Logs the error create bad request.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="logger">The logger.</param>
        /// <returns>BadRequestObjectResult.</returns>
        /// <exception cref="ArgumentNullException">ErrorMessage cannot be null or empty.</exception>
        /// <exception cref="ArgumentNullException">Exception cannot be null or empty.</exception>
        [Information(nameof(LogErrorCreateBadRequest), "David McCarter", "2/22/21", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public BadRequestObjectResult LogErrorCreateBadRequest(string errorMessage, [NotNull] Exception ex, ILogger logger)
        {
            Validate.TryValidateParam(errorMessage, nameof(errorMessage));

            if (logger.IsNotNull())
            {
                logger.LogError(ex, message: $"{errorMessage}");
            }

            return _controller.BadRequest(new ProblemDetails { Title = errorMessage, Detail = ex.GetAllMessages() });
        }
    }
}
