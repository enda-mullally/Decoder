using System.Reflection;

namespace Decoder
{
    public class AppUtils
    {
        public static string GetAppVersion()
        {
            var version = Assembly
                .GetExecutingAssembly()
                .GetName()
                .Version;

            return version.Major.ToString("D1") + "." +
                   version.Minor.ToString("D1") + "." +
                   version.MinorRevision.ToString("D1");
        }
    }
}
