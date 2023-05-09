using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApp.identity
{
    public static class ExecuteIdentity
    {
        public static List<System.Type> getClassList()
        {
            List<System.Type> list = new List<System.Type>(); 
            list = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "IdentityApp.app")
                      .ToList();
            return list;
        }

        public static MethodInfo[] getMethodList(string selectedObjcClass)
        {
            MethodInfo[] methodInfos = Type.GetType(selectedObjcClass)
                            .GetMethods(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Static | BindingFlags.Instance| BindingFlags.FlattenHierarchy);
            return methodInfos;
        }
    }
}
