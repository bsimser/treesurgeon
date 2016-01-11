using System.Collections;

namespace TreeSurgeon.Core.Generators.Content
{
    public interface ITransformFiles
    {
        string Transform(string transformName, Hashtable transformParameters);
    }
}