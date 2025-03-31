using Xunit;
using System.Reflection;

namespace GitHubVersionDisplay.Tests
{
    public class VersionTests
    {
        [Fact]
        public void Version_Should_Contain_GitHash()
        {
            var version = Assembly.GetAssembly(typeof(Program))
                ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;

            Assert.NotNull(version);
            Assert.Matches(@"^1\.0\.0\+[0-9a-f]{7,40}$", version!); // GitのSHA-1
        }
    }
}