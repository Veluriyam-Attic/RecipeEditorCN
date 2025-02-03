using Terraria.ModLoader;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;

namespace RecipeEditorCN;

public class RecipeEditorCN : Mod
{
    private static readonly bool firstRegister = false;
    public override void PostSetupContent()
    {
        if (firstRegister)
        {
            TigerForceLocalizationHelper.LocalizeAll(nameof(RecipeEditorCN), "RecipeEditor", true, filters: new()
            {
                MethodFilter = MethodFilter.CommonMethodFilter,
                CursorFilter = ILCursorFilter.CommonCursorFilter,
            });
            TigerForceLocalizationHelper.ShowLocalizationRegisterProgress();
        }
        else
        {
            TigerForceLocalizationHelper.LocalizeAll(nameof(RecipeEditorCN), "RecipeEditor");
        }
    }
}
