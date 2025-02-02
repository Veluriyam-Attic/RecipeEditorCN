using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;

namespace RecipeEditorCN
{
	public class RecipeEditor : Mod
	{
        public override void PostSetupContent()
        {
            TigerForceLocalizationHelper.LocalizeAll("RecipeEditorCN", "RecipeEditor", false);
        }

	}
}
