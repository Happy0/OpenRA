#region Copyright & License Information
/*
 * Copyright 2007-2014 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

namespace OpenRA.Scripting
{
	[ScriptGlobal("CPos")]
	public class CPosGlobal : ScriptGlobal
	{
		public CPosGlobal(ScriptContext context) : base(context) { }

		[Desc("Create a new CPos with the specified coordinates.")]
		public CPos New(int x, int y) { return new CPos(x, y); }

		[Desc("The cell coordinate origin.")]
		public CPos Zero { get { return CPos.Zero; } }
	}

	[ScriptGlobal("CVec")]
	public class CVecGlobal : ScriptGlobal
	{
		public CVecGlobal(ScriptContext context) : base(context) { }

		[Desc("Create a new CVec with the specified coordinates.")]
		public CVec New(int x, int y) { return new CVec(x, y); }

		[Desc("The cell zero-vector.")]
		public CVec Zero { get { return CVec.Zero; } }
	}

	[ScriptGlobal("WPos")]
	public class WPosGlobal : ScriptGlobal
	{
		public WPosGlobal(ScriptContext context) : base(context) { }

		[Desc("Create a new WPos with the specified coordinates.")]
		public WPos New(int x, int y, int z) { return new WPos(x, y, z); }

		[Desc("The world coordinate origin.")]
		public WPos Zero { get { return WPos.Zero; } }
	}

	[ScriptGlobal("WVec")]
	public class WVecGlobal : ScriptGlobal
	{
		public WVecGlobal(ScriptContext context) : base(context) { }

		[Desc("Create a new WVec with the specified coordinates.")]
		public WVec New(int x, int y, int z) { return new WVec(x, y, z); }

		[Desc("The world zero-vector.")]
		public WVec Zero { get { return WVec.Zero; } }
	}

	[ScriptGlobal("WRange")]
	public class WRangeGlobal : ScriptGlobal
	{
		public WRangeGlobal(ScriptContext context) : base(context) { }

		[Desc("Create a new WRange.")]
		public WRange New(int r) { return new WRange(r); }

		[Desc("Create a new WRange by cell distance")]
		public WRange FromCells(int numCells) { return WRange.FromCells(numCells); }
	}
}
