using System.Runtime.CompilerServices;

public class Application : ITypedObject
{
// ## Generated Code ##
	public static string GetTypeID()
	{
		return "Application";
	}


	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static string GetInstallLocation();

// ## Generated Code ##
}