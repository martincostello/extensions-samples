// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Diagnostics.Metrics;
using static Metrics.Generators.Metric;

namespace Metrics.Generators;

// The structure that contains the metering information about the request.
internal struct RequestInfo
{
    // This annotated property will be used as a tag for the RequestStats histogram.
    [TagName(Tags.Target)]
    public RequestTarget Target { get; set; }

    // This annotated property will be used as a tag for the RequestStats histogram.
    // You can omit the [TagName] attribute if the tag name is the same as the property name.
    public string DayOfWeek { get; set; }
}
