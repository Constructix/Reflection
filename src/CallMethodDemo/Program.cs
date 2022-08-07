using System.Reflection;
using System.Reflection.Emit;

Type? t =  Type.GetType("Foo");
Object obj = Activator.CreateInstance(t);
MethodInfo mi = t.GetMethod("Bar");
mi.Invoke(obj, null);


mi = t.GetMethod("DisplayMessage");
mi.Invoke(obj, new object?[] { "Hello World"});


var p = new Person("Rodney", "Dangerfield");
mi = t.GetMethod("PassInPersonObject");
mi.Invoke(obj, new object?[] { p });

