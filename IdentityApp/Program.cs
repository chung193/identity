// See https://aka.ms/new-console-template for more information
using IdentityApp.identity;
using System.Reflection;

List<System.Type> classList = ExecuteIdentity.getClassList();

dynamic obj;
foreach (var val in classList)
{
    MethodInfo[] methodList = ExecuteIdentity.getMethodList(val.ToString());
    foreach (var item in methodList)
    {
        Console.WriteLine("=== "+item);
    }
}

