﻿using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.RP.RestApi.Extensions
{
    public static class GuidExtensions
    {
        public static Guid ToGuid(this string text)
        {
            if (string.IsNullOrEmpty(text)) throw new ArgumentNullException(nameof(text));
            if (!Guid.TryParse(text, out var result)) throw new RpcException(new Status(StatusCode.InvalidArgument, "Not a valid guid."));
            return result;
        }
    }
}
