namespace TreeSurgeon.Core.Generators.Content
{
    public class DefaultVelocityTransformerConfig : IConfigureTheTransformer
    {
        private readonly string _templateDirectory;

        public DefaultVelocityTransformerConfig(string templateDirectory)
        {
            _templateDirectory = templateDirectory;
        }

        #region IConfigureTheTransformer Members

        public string TemplateDirectory
        {
            get { return _templateDirectory; }
        }

        #endregion

        public override bool Equals(object obj)
        {
            return (obj is DefaultVelocityTransformerConfig &&
                    ((DefaultVelocityTransformerConfig) obj).TemplateDirectory == TemplateDirectory);
        }

        public override int GetHashCode()
        {
            return TemplateDirectory.GetHashCode();
        }
    }
}