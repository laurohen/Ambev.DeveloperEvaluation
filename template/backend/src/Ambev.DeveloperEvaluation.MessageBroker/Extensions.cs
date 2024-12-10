﻿using MassTransit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker
{
    public static class Extensions
    {
        public static void SetCulture(this ConsumeContext context, string cultureValue)
        {
            if (context.Headers.TryGetHeader(cultureValue, out _))
                Thread.CurrentThread.CurrentUICulture =
                    CultureInfo.GetCultureInfo(context.Headers.Get<string>(cultureValue) ?? string.Empty);
        }

        public static string GetDistributedTracingData(this ConsumeContext context)
        {
            return context.Headers.Get<string>("Transaction") ?? "";
        }
    }
}