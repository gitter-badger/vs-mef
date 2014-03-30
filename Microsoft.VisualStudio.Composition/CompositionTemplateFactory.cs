﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Microsoft.VisualStudio.Composition
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.Reflection;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class CompositionTemplateFactory : CompositionTemplateFactoryBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Microsoft.VisualStudio.Composition
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition.Hosting;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.Composition;

internal class CompiledExportProvider : ExportProvider
{
    public CompiledExportProvider()
        : this(null, null)
    {
    }

    public CompiledExportProvider(ExportProvider parent, string[] freshSharingBoundaries)
        : base(parent, freshSharingBoundaries)
    {
    }

    protected override object GetExport(ExportDefinition exportDefinition)
    {
        var provisionalSharedObjects = new Dictionary<Type, object>();
        Type exportTypeDefinition = exportDefinition.Contract.Type.IsGenericType ? exportDefinition.Contract.Type.GetGenericTypeDefinition() : exportDefinition.Contract.Type;");
            
            #line 41 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

foreach (var contractAndExports in this.RootExportsByContract)
{
    CompositionContract contract = contractAndExports.Key;
    IEnumerable<Export> exports = contractAndExports;
    if (exports.Count() != 1)
    {
        // This method returns matches when exactly one export exists.
        continue;
    }

    var onlyExport = exports.First();
    var part = onlyExport.PartDefinition;
    var member = onlyExport.ExportingMember;
    var partExport = onlyExport.ExportDefinition;

            
            #line default
            #line hidden
            this.Write("\r\n        if (");
            
            #line 58 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(contract.Type.IsGenericTypeDefinition ? "exportTypeDefinition" : "exportDefinition.Contract.Type"));
            
            #line default
            #line hidden
            this.Write(".IsEquivalentTo(");
            
            #line 58 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeExpression(contract.Type, contract.Type.IsGenericTypeDefinition)));
            
            #line default
            #line hidden
            this.Write("))\r\n        {\r\n");
            
            #line 60 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

            if (contract.ContractName == null)
            {

            
            #line default
            #line hidden
            this.Write("            if (exportDefinition.Contract.ContractName == null)\r\n");
            
            #line 65 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("            if (exportDefinition.Contract.ContractName == \"");
            
            #line 70 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(contract.ContractName));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 71 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

            }

            
            #line default
            #line hidden
            this.Write("            {\r\n");
            
            #line 75 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                if (part.Type.IsGenericType)
                {

            
            #line default
            #line hidden
            this.Write("                return ");
            
            #line 79 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPartOrMemberLazy(GetGenericPartFactoryMethodInvokeExpression(part), member, partExport, part)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 80 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                }
                else
                {
                    if (member.IsStaticExport())
                    {

            
            #line default
            #line hidden
            this.Write("                throw new InvalidOperationException(\"Static exports not supported" +
                    ".\");\r\n");
            
            #line 88 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("                var part = this.");
            
            #line 93 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPartFactoryMethodName(part)));
            
            #line default
            #line hidden
            this.Write("(provisionalSharedObjects);\r\n                return ");
            
            #line 94 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPartOrMemberLazy("part", member, partExport, part)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 95 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                    }
                }

            
            #line default
            #line hidden
            this.Write("            }\r\n        }\r\n");
            
            #line 101 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

}

            
            #line default
            #line hidden
            this.Write(@"
        throw new CompositionFailedException();
    }

    protected override IEnumerable<object> GetExports(ExportDefinition exportDefinition)
    {
        var provisionalSharedObjects = new Dictionary<Type, object>();
        Type exportTypeDefinition = exportDefinition.Contract.Type.IsGenericType ? exportDefinition.Contract.Type.GetGenericTypeDefinition() : exportDefinition.Contract.Type;");
            
            #line 111 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

foreach (var contractAndExports in this.RootExportsByContract)
{
    CompositionContract contract = contractAndExports.Key;
    IEnumerable<Export> exports = contractAndExports;


            
            #line default
            #line hidden
            this.Write("\r\n        if (");
            
            #line 119 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(contract.Type.IsGenericTypeDefinition ? "exportTypeDefinition" : "exportDefinition.Contract.Type"));
            
            #line default
            #line hidden
            this.Write(".IsEquivalentTo(");
            
            #line 119 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeExpression(contract.Type, contract.Type.IsGenericTypeDefinition)));
            
            #line default
            #line hidden
            this.Write("))\r\n        {\r\n");
            
            #line 121 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

            if (contract.ContractName == null)
            {

            
            #line default
            #line hidden
            this.Write("            if (exportDefinition.Contract.ContractName == null)\r\n");
            
            #line 126 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("            if (exportDefinition.Contract.ContractName == \"");
            
            #line 131 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(contract.ContractName));
            
            #line default
            #line hidden
            this.Write("\")\r\n");
            
            #line 132 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

            }

            
            #line default
            #line hidden
            this.Write("            {\r\n                ");
            
            #line 136 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
 EmitGetExportsReturnExpression(contract, exports); 
            
            #line default
            #line hidden
            this.Write("            }\r\n        }\r\n");
            
            #line 139 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

}

            
            #line default
            #line hidden
            this.Write("\r\n        return null;\r\n    }\r\n");
            
            #line 145 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

foreach (var part in this.Configuration.Parts) 
{

            
            #line default
            #line hidden
            this.Write("\r\n    protected ILazy<");
            
            #line 150 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(part.Definition.Type)));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 150 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPartFactoryMethodName(part.Definition)));
            
            #line default
            #line hidden
            this.Write("(Dictionary<Type, object> provisionalSharedObjects, bool nonSharedInstanceRequire" +
                    "d = false)\r\n    {\r\n        ILazy<");
            
            #line 152 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(part.Definition.Type)));
            
            #line default
            #line hidden
            this.Write("> value;\r\n        Type partType = ");
            
            #line 153 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.GetTypeExpression(part.Definition.Type)));
            
            #line default
            #line hidden
            this.Write(";\r\n        if (!nonSharedInstanceRequired && TryGetProvisionalSharedExport(provis" +
                    "ionalSharedObjects, partType, out value))\r\n        {\r\n            return value;\r" +
                    "\n        }\r\n\r\n        ILazy<");
            
            #line 159 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(part.Definition.Type)));
            
            #line default
            #line hidden
            this.Write("> lazyResult;\r\n");
            
            #line 160 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        if (part.Definition.IsShared)
        {

            
            #line default
            #line hidden
            this.Write("        if (nonSharedInstanceRequired || !this.TryGetSharedInstanceFactory(@\"");
            
            #line 164 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(part.Definition.SharingBoundary));
            
            #line default
            #line hidden
            this.Write("\", partType, out lazyResult))\r\n        {\r\n            lazyResult = ");
            
            #line 166 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
 using (EmitLazyConstruction(part.Definition.Type)) { 
            
            #line default
            #line hidden
            this.Write("                {\r\n");
            
            #line 168 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                if (part.Definition.IsInstantiable)
                {
                    using(Indent(5))
                    {
                        EmitInstantiatePart(part);
                    }
                }
                else
                {

            
            #line default
            #line hidden
            this.Write("                    return CannotInstantiatePartWithNoImportingConstructor();\r\n");
            
            #line 180 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                }

            
            #line default
            #line hidden
            this.Write("                }");
            
            #line 183 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
 } 
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n            if (!nonSharedInstanceRequired)\r\n            {\r\n                " +
                    "lazyResult = this.GetOrAddSharedInstanceFactory(@\"");
            
            #line 187 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(part.Definition.SharingBoundary));
            
            #line default
            #line hidden
            this.Write("\", partType, lazyResult);\r\n            }\r\n        }\r\n");
            
            #line 190 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("        lazyResult = ");
            
            #line 195 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
 using (EmitLazyConstruction(part.Definition.Type)) { 
            
            #line default
            #line hidden
            this.Write("            {\r\n");
            
            #line 197 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                using(Indent(4))
                {
                    if (part.Definition.IsInstantiable)
                    {
                        EmitInstantiatePart(part);
                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("                return CannotInstantiatePartWithNoImportingConstructor();\r\n");
            
            #line 208 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

                    }
                }

            
            #line default
            #line hidden
            this.Write("            }");
            
            #line 212 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
 } 
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 213 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n        return lazyResult;\r\n    }\r\n");
            
            #line 219 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

}

            
            #line default
            #line hidden
            this.Write(@"
    private static bool TryGetProvisionalSharedExport<T>(IReadOnlyDictionary<Type, object> provisionalSharedObjects, Type type, out ILazy<T> value)
    {
        object valueObject;
        if (provisionalSharedObjects.TryGetValue(type, out valueObject))
        {
            value = LazyPart.Wrap((T)valueObject);
            return true;
        }

        value = null;
        return false;
    }
");
            
            #line 235 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

    // Emit concrete types for each metadataview interface.
    foreach (Type interfaceType in GetMetadataViewInterfaces())
    {
        string className = GetClassNameForMetadataView(interfaceType);

            
            #line default
            #line hidden
            this.Write("\r\n    private class ");
            
            #line 242 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 242 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(interfaceType)));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 244 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        foreach (var member in interfaceType.EnumProperties(BindingFlags.Instance | BindingFlags.Public).Distinct(UniquePropertyNameComparer.Default))
        {

            
            #line default
            #line hidden
            this.Write("        private readonly ");
            
            #line 248 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(member.PropertyType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 248 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 249 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n        internal ");
            
            #line 253 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("(IReadOnlyDictionary<string, object> source)\r\n        {\r\n");
            
            #line 255 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        foreach (var member in interfaceType.EnumProperties(BindingFlags.Instance | BindingFlags.Public).Distinct(UniquePropertyNameComparer.Default))
        {

            
            #line default
            #line hidden
            this.Write("            this.");
            
            #line 259 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 259 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetValueOrDefaultForMetadataView(member, "source")));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 260 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 264 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        foreach (var member in interfaceType.EnumProperties(BindingFlags.Instance | BindingFlags.Public))
        {

            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 269 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(member.PropertyType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 269 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(member.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 269 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return this.");
            
            #line 271 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.Name));
            
            #line default
            #line hidden
            this.Write("; }\r\n        }\r\n");
            
            #line 273 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

        }

            
            #line default
            #line hidden
            this.Write("    }\r\n");
            
            #line 277 "D:\Users\andarno\git\Microsoft.VisualStudio.Composition\Microsoft.VisualStudio.Composition\CompositionTemplateFactory.tt"

    }

            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class CompositionTemplateFactoryBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
