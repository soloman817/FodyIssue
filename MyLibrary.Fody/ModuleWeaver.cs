using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace MyLibrary.Fody
{
    public class ModuleWeaver
    {
        public ModuleDefinition ModuleDefinition { get; set; }
        public string AssemblyFilePath { get; set; }
        public Action<string> LogDebug { get; set; }
        public Action<string> LogInfo { get; set; }
        public Action<string> LogWarning { get; set; }
        public Action<string, SequencePoint> LogWarningPoint { get; set; }
        public Action<string> LogError { get; set; }
        public Action<string, SequencePoint> LogErrorPoint { get; set; }
        public IAssemblyResolver AssemblyResolver { get; set; }
        public List<string> DefineConstants { get; set; }
        public string ProjectDirectoryPath { get; set; }
        public string AddinDirectoryPath { get; set; }
        public string SolutionDirectoryPath { get; set; }
        public string References { get; set; }

        public ModuleWeaver()
        {
        }

        public void Execute()
        {
            LogInfo(string.Format("Insert some fake resource for assembly '{0}'...", ModuleDefinition.Name));
            const string resourceName = "key";
            var resourceContent = new byte[10];
            resourceContent[0] = 83;
            resourceContent[1] = 23;
            ModuleDefinition.Resources.Add(new EmbeddedResource(resourceName, ManifestResourceAttributes.Public, resourceContent));
        }
    }
}
