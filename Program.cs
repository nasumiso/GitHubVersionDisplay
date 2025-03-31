using System.Reflection;

class Program
{
    /// <summary>
    ///C#プロジェクトのバージョンを表示する
    /// 例：アセンブリバージョン+Gitバージョン
    /// Version: 1.0.0+014129cfcdc87493909bd12bd2b7383d086439aa
    /// </summary>
    static void Main()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        Console.WriteLine($"Version: {version}");
    }
}