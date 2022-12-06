using System;

using R5T.T0132;


namespace R5T.S0056
{
	[FunctionalityMarker]
	public partial interface IPathScripts : IFunctionalityMarker
	{
		public void RebaseGlobbedRelativePath()
		{
			/// Inputs.
			var globbedRelativePath = @"./Components/**/*.razor";
			var initialContainingDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0065.Private\source\R5T.E0065.Server\";
			var newContainingDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Testing\source\R5T.Testing.Server\";


			/// Run.
			var globbedPath = Instances.PathOperator.Combine_EnsureResolved(
				initialContainingDirectoryPath,
				globbedRelativePath);

			var newRelativeGlobbedPath = Instances.PathOperator.GetRelativePath(
				newContainingDirectoryPath,
				globbedPath);

			Console.WriteLine($"{newRelativeGlobbedPath}\n\n{newContainingDirectoryPath}\n{globbedPath}");
		}

        public void ResolveGlobbedRelativePath()
        {
            /// Inputs.
            var globbedRelativePath = @"./Components/**/*.razor";
            var initialContainingDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0065.Private\source\R5T.E0065.Server\";


            /// Run.
            var globbedPath = Instances.PathOperator.Combine_EnsureResolved(
                initialContainingDirectoryPath,
                globbedRelativePath);

			Console.WriteLine($"{globbedPath}\n\n{initialContainingDirectoryPath}\n{globbedRelativePath}");
        }
    }
}