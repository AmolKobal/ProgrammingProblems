using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExamples.AppicationDomain
{
    class AppicationDomain : _AppDomain
    {
        #region [ _AppDomain Members ]

        void _AppDomain.AppendPrivatePath(string path)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        event AssemblyLoadEventHandler _AppDomain.AssemblyLoad
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        event ResolveEventHandler _AppDomain.AssemblyResolve
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        string _AppDomain.BaseDirectory
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        void _AppDomain.ClearPrivatePath()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.ClearShadowCopyPath()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Runtime.Remoting.ObjectHandle _AppDomain.CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Runtime.Remoting.ObjectHandle _AppDomain.CreateInstance(string assemblyName, string typeName, object[] activationAttributes)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Runtime.Remoting.ObjectHandle _AppDomain.CreateInstance(string assemblyName, string typeName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Runtime.Remoting.ObjectHandle _AppDomain.CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Runtime.Remoting.ObjectHandle _AppDomain.CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Runtime.Remoting.ObjectHandle _AppDomain.CreateInstanceFrom(string assemblyFile, string typeName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Emit.AssemblyBuilder _AppDomain.DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.DoCallBack(CrossAppDomainDelegate theDelegate)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        event EventHandler _AppDomain.DomainUnload
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        string _AppDomain.DynamicDirectory
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        bool _AppDomain.Equals(object other)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Security.Policy.Evidence _AppDomain.Evidence
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        int _AppDomain.ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int _AppDomain.ExecuteAssembly(string assemblyFile)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int _AppDomain.ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        string _AppDomain.FriendlyName
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        System.Reflection.Assembly[] _AppDomain.GetAssemblies()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        object _AppDomain.GetData(string name)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int _AppDomain.GetHashCode()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        object _AppDomain.GetLifetimeService()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        Type _AppDomain.GetType()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.GetTypeInfoCount(out uint pcTInfo)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        object _AppDomain.InitializeLifetimeService()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(byte[] rawAssembly, byte[] rawSymbolStore)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(byte[] rawAssembly)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(string assemblyString)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Reflection.Assembly _AppDomain.Load(System.Reflection.AssemblyName assemblyRef)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        event EventHandler _AppDomain.ProcessExit
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        string _AppDomain.RelativeSearchPath
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        event ResolveEventHandler _AppDomain.ResourceResolve
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        void _AppDomain.SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.SetCachePath(string s)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.SetData(string name, object data)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.SetShadowCopyPath(string s)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void _AppDomain.SetThreadPrincipal(System.Security.Principal.IPrincipal principal)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        bool _AppDomain.ShadowCopyFiles
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        string _AppDomain.ToString()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        event ResolveEventHandler _AppDomain.TypeResolve
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        event UnhandledExceptionEventHandler _AppDomain.UnhandledException
        {
            add { throw new Exception("The method or operation is not implemented."); }
            remove { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion
    }
}
