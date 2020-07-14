using System;

namespace ESGI.DesignPattern.Projet
{
    /// <summary>
/// Used for getting DateTime.Now(), time is changeable for unit testing
/// </summary>
    public static class SystemTime
    {
        public static DateTime Now { get; set; } = DateTime.Now;
    }
}
