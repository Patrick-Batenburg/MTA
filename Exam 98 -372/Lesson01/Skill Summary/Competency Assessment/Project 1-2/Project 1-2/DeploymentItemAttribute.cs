using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CompanyA.Acounting
{
    // https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.deploymentitemattribute.aspx
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class DeploymentItemAttribute : Attribute
    {
        public string Path { get; }
        public string OutputDirectory { get; }
        public DeploymentItemAttribute(string path, string outputDirectory)
        {

        }
    }
}
