// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.AspNet
// Author           : David McCarter
// Created          : 02-22-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="ActionResultThrower.cs" company="dotNetTips.Spargine.5.AspNet">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        private static ResultController _controller = new ResultController();

        /// <summary>
        /// Logs the error create bad request.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="logger">The logger.</param>
        /// <returns>BadRequestObjectResult.</returns>
        /// <exception cref="ArgumentNullException">ErrorMessage cannot be null or empty.</exception>
        /// <exception cref="ArgumentNullException">Exception cannot be null or empty.</exception>
        [Information(nameof(LogErrorCreateBadRequest), "David McCarter", "2/22/21", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New)]
        public BadRequestObjectResult LogErrorCreateBadRequest(string errorMessage, Exception ex, ILogger logger)
        {
            Validate.TryValidateParam(errorMessage, nameof(errorMessage));
            Validate.TryValidateNullParam(ex, nameof(ex));

            if (logger.IsNotNull())
            {
                logger.LogError(ex, message: $"{errorMessage}");
            }

            return _controller.BadRequest(new ProblemDetails { Title = errorMessage, Detail = ex.GetAllMessages() });
        }
    }

    /// <summary>
    /// Class ResultController.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    internal class ResultController : ControllerBase
    {

    }
}
