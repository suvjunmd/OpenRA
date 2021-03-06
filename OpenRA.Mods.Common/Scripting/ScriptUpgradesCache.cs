#region Copyright & License Information
/*
 * Copyright 2007-2015 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using OpenRA.Traits;

namespace OpenRA.Mods.Common.Scripting
{
	[Desc("Allows granting upgrades to actors from Lua scripts.")]
	public class ScriptUpgradesCacheInfo : ITraitInfo
	{
		[UpgradeGrantedReference]
		[Desc("Upgrades that can be granted from the scripts.")]
		public readonly string[] Upgrades = { };

		public object Create(ActorInitializer init) { return new ScriptUpgradesCache(this); }
	}

	public sealed class ScriptUpgradesCache
	{
		public readonly ScriptUpgradesCacheInfo Info;

		public ScriptUpgradesCache(ScriptUpgradesCacheInfo info)
		{
			Info = info;
		}
	}
}
