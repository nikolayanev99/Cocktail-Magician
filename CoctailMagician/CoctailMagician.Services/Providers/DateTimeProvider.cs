using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailMagician.Services.Providers
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime() => DateTime.UtcNow;
    }
}
