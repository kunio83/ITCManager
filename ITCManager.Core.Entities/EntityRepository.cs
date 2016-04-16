using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITCManager.Core.Entities
{
    public static class EntityRepository
    {
        public static Type[] GetAllEntities()
        {
            Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "ITCManager.Core.Entities");
            return typelist;
        }

        private static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
            {
                return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
            }
    }
}
