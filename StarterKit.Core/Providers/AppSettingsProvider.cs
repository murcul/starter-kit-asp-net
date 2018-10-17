using System;
using System.Collections.Generic;
using System.Text;
using StarterKit.Core.Models;

namespace StarterKit.Core.Providers
{
    public static  class AppSettingsProvider
    {
        public static AppSettings Current { get; private set; }

        public static void Register(AppSettings settings)
        {
            Current = settings;
        }
    }
}
