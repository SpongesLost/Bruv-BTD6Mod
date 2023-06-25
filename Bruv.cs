using MelonLoader;
using BTD_Mod_Helper;
using Bruv;

[assembly: MelonInfo(typeof(Bruv.Bruv), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Bruv;

public class Bruv : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<Bruv>("Bruv loaded!");
    }
}