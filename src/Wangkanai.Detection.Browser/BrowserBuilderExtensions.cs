﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.Detection;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{    
    public static class BrowserBuilderExtensions
    {
        // concept idea on adding platform detection to client service
        public static IDetectionBuilder AddBrowser(this IDetectionBuilder builder)
        {
            builder.Services.AddTransient<IBrowserResolver, BrowserResolver>();

            return builder;
        }
    }
}
