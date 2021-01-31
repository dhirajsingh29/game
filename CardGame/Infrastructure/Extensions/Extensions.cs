using System;

namespace CardGame.Infrastructure.Extensions
{
    public static class Extensions
    {
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase: true);
        }
    }
}
