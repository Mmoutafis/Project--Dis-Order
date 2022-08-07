using UnrealBuildTool;

public class DisOrderTarget : TargetRules
{
	public DisOrderTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DisOrder");
	}
}
