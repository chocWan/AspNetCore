// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Allows customization of the <see cref="EndpointModel"/>.
    /// </summary>
    /// <remarks>
    /// This interface is used at application startup to customize endpoints for the application.
    /// </remarks>
    public interface IEndpointConventionBuilder
    {
        /// <summary>
        /// Called to apply the convention to the <see cref="EndpointModel"/>.
        /// </summary>
        /// <param name="convention">The convention to apply to the <see cref="EndpointModel"/>.</param>
        void Apply(Action<EndpointModel> convention);
    }
}