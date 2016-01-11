using System;

namespace TreeSurgeon.Core.Generators
{
    public class StandardDotNetUpperCaseGuidGenerator : IGenerateGuids
    {
        #region IGenerateGuids Members

        public string GenerateGuid()
        {
            return Guid.NewGuid().ToString().ToUpper();
        }

        #endregion
    }
}