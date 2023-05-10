// See https://aka.ms/new-console-template for more information
using IdentityApp.identity;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

List<System.Type> classList = ExecuteIdentity.getClassList();

Dictionary<string, Dictionary<string,bool>> MyDic = new Dictionary<string, Dictionary<string, bool>>(classList.Count);

foreach (var val in classList)
{
    Dictionary<string, bool> list = new Dictionary<string, bool>();
    MethodInfo[] methodList = ExecuteIdentity.getMethodList(val.ToString());

    Console.WriteLine(val);
    foreach (var item in methodList)
    {
        Console.WriteLine("-"+item);
        list.Add(item.ToString(), false);
    }
    MyDic.Add(val.ToString(), list);
}

//string result = IdentityApp.common.Helper.MyDictionaryToJson(MyDic);
//Console.WriteLine(result);
string ketnoi = IdentityApp.data.Data.connectDb();
Console.WriteLine(ketnoi);

//struct permission
//{
//    public string name;
//    public List<Dictionary<string, bool>>
//};
// var output = JsonConvert.DeserializeObject<object>(result);

///Console.WriteLine(output);
