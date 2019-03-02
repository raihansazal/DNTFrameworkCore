﻿using DNTFrameworkCore.Functional;
using DNTFrameworkCore.Validation;
using System.Collections.Generic;

namespace DNTFrameworkCore.Application.Services
{
    /// <summary>
    /// base class of application services for support versioning
    /// </summary>
    public abstract class ApplicationService : IApplicationService
    {
        protected static Result Ok() => Result.Ok();

        protected static Result Failed(string message) => Result.Failed(message);
        protected static Result Failed(string message, IEnumerable<ModelValidationResult> failures) => Result.Failed(message, failures);

        protected static Result<T> Ok<T>(T value) => Result.Ok(value);

        protected static Result<T> Failed<T>(string message) => Result.Failed<T>(message);
        protected static Result<T> Failed<T>(string message, IEnumerable<ModelValidationResult> failures) => Result.Failed<T>(message, failures);
    }
}