#addin nuget:?package=Cake.Git&version=0.19.0
#addin nuget:?package=Cake.FileHelpers&version=3.1.0

var target = Argument("target", "");
var solutionPath = Argument("SolutionPath", "./");
var thisRepo = MakeAbsolute(Directory(solutionPath));
var assemblyInfo = File(thisRepo.FullPath + "/GeneratedSolutionVersion.cs");

Task("Version")
    .Does(() => 
{
	Information($"Exporting to {assemblyInfo.Path}");

    var branch = GitBranchCurrent(thisRepo);

    // The following is not the best approach
    // We should use LibGit2Sharp's ObjectDatabase.ShortenObjectId(),
    // but Cake.Git doesn't currently support it.
    var sha = branch.Tip.Sha.Substring(0, 8);

    // TODO: branch.FriendlyName produces a name too long when using gitflow,
    // e.g. "1.0.12fa582d-feature/MYPROJ-2732-title_of_story_or_defect".
    // There should be an attempt to extract maybe the issue identifier
    // so that we end with something like "1.0.12fa582d-MYPROJ-2732"
    // or "1.0.12fa582d-f-title_of_story"
    CreateAssemblyInfo(assemblyInfo, new AssemblyInfoSettings {
        InformationalVersion	= string.Format("1.0.{0}-{1}", branch.FriendlyName, sha),
		Version					=				"1.0.*",
    });
	FileAppendLines(assemblyInfo, new string[]
		{
			"namespace SM2",
			"{",
			"    internal class BuildInfo",
			"    {",
			"        public const string CompileSHA = \"" + sha + "\";",
			"        public const string CompileBranch = \"" + branch.FriendlyName + "\";",
			"        #if DEBUG",
			"        public const string CompileMode = \"Debug\";",
			"        #else",
			"        public const string CompileMode = \"Release\";",
			"        #endif",
			"    }",
			"}"
		});
});

RunTarget(target);