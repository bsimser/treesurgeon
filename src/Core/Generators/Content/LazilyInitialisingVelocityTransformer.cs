using System.Collections;
using System.IO;
using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;

namespace TreeSurgeon.Core.Generators.Content
{
    public class LazilyInitialisingVelocityTransformer : ITransformFiles
    {
        private readonly IConfigureTheTransformer _config;
        private VelocityEngine _engine;

        public LazilyInitialisingVelocityTransformer(IConfigureTheTransformer config)
        {
            _config = config;
        }

        private VelocityEngine VelocityEngine
        {
            get
            {
                lock (this)
                {
                    if (_engine == null)
                    {
                        _engine = new VelocityEngine();
                        _engine.SetProperty(RuntimeConstants_Fields.RUNTIME_LOG_LOGSYSTEM_CLASS,
                                            "NVelocity.Runtime.Log.NullLogSystem");
                        _engine.SetProperty(RuntimeConstants_Fields.FILE_RESOURCE_LOADER_PATH,
                                            _config.TemplateDirectory);
                        _engine.SetProperty(RuntimeConstants_Fields.RESOURCE_MANAGER_CLASS,
                                            "NVelocity.Runtime.Resource.ResourceManagerImpl");
                        _engine.Init();
                    }
                }
                return _engine;
            }
        }

        #region ITransformFiles Members

        public string Transform(string transformName, Hashtable transformParameters)
        {
            string output;
            using (TextWriter writer = new StringWriter())
            {
                VelocityEngine.MergeTemplate(transformName, new VelocityContext(transformParameters), writer);
                output = writer.ToString();
            }
            return output;
        }

        #endregion
    }
}