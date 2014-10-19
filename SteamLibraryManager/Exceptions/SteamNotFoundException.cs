using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamLibraryManager
{
    class SteamNotFoundException : Exception
    {
        public SteamNotFoundException()
            : base() { }

        public SteamNotFoundException(string message)
            : base(message) { }

        public SteamNotFoundException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public SteamNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }

        public SteamNotFoundException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
