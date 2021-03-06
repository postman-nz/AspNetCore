// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Mvc.Infrastructure
{
    public class SystemTextJsonResultExecutorTest : JsonResultExecutorTestBase
    {
        protected override IActionResultExecutor<JsonResult> CreateExecutor(ILoggerFactory loggerFactory)
        {
            return new SystemTextJsonResultExecutor(Options.Create(new MvcOptions()), loggerFactory.CreateLogger<SystemTextJsonResultExecutor>());
        }

        protected override object GetIndentedSettings()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }
    }
}
