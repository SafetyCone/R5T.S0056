using System;


namespace R5T.S0056
{
	public class PathScripts : IPathScripts
	{
		#region Infrastructure

	    public static IPathScripts Instance { get; } = new PathScripts();

	    private PathScripts()
	    {
        }

	    #endregion
	}
}