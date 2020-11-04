﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenDebugAD7 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AD7Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AD7Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenDebugAD7.AD7Resources", typeof(AD7Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Execute debugger commands using &quot;-exec &lt;command&gt;&quot;, for example &quot;-exec info registers&quot; will list registers in use (when GDB is the debugger).
        /// </summary>
        internal static string DebugConsoleStartMessage {
            get {
                return ResourceManager.GetString("DebugConsoleStartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debugger has disconnected from the program &apos;{0}&apos;..
        /// </summary>
        internal static string DebuggerDisconnectMessage {
            get {
                return ResourceManager.GetString("DebuggerDisconnectMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Condition &quot;{0}&quot; : {1}.
        /// </summary>
        internal static string Error_ConditionBreakpoint {
            get {
                return ResourceManager.GetString("Error_ConditionBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Env&apos; and &apos;Environment&apos; properties cannot both be defined..
        /// </summary>
        internal static string Error_ConflictingEnvProps {
            get {
                return ResourceManager.GetString("Error_ConflictingEnvProps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal error in OpenDebugAD7. Exception of type &apos;{0}&apos; was thrown.
        ///
        ///{1}.
        /// </summary>
        internal static string Error_CorruptingException {
            get {
                return ResourceManager.GetString("Error_CorruptingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occurred: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_ExceptionOccured {
            get {
                return ResourceManager.GetString("Error_ExceptionOccured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Breakpoint Error: function &quot;{0}&quot;, {1}.
        /// </summary>
        internal static string Error_FunctionBreakpoint {
            get {
                return ResourceManager.GetString("Error_FunctionBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Error. Launch type &apos;{0}&apos; unsupported. Args &apos;{1}&apos;.
        /// </summary>
        internal static string Error_Internal_Launch {
            get {
                return ResourceManager.GetString("Error_Internal_Launch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to interpolate logMessage because frames could not be retrieved..
        /// </summary>
        internal static string Error_InterpolateMissingFrames {
            get {
                return ResourceManager.GetString("Error_InterpolateMissingFrames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to interpolate logMessage because current thread is missing..
        /// </summary>
        internal static string Error_InterpolateMissingThread {
            get {
                return ResourceManager.GetString("Error_InterpolateMissingThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to interpolate logMessage because there is no top frame..
        /// </summary>
        internal static string Error_InterpolateMissingTopFrame {
            get {
                return ResourceManager.GetString("Error_InterpolateMissingTopFrame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to evaluate expression..
        /// </summary>
        internal static string Error_InterpolateVariableEvaluateFailed {
            get {
                return ResourceManager.GetString("Error_InterpolateVariableEvaluateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get context from frame..
        /// </summary>
        internal static string Error_InterpolateVariableMissingContext {
            get {
                return ResourceManager.GetString("Error_InterpolateVariableMissingContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No expression object found..
        /// </summary>
        internal static string Error_InterpolateVariableMissingExpressionObject {
            get {
                return ResourceManager.GetString("Error_InterpolateVariableMissingExpressionObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get property information..
        /// </summary>
        internal static string Error_InterpolateVariableMissingProperties {
            get {
                return ResourceManager.GetString("Error_InterpolateVariableMissingProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DNX runtime process exited unexpectedly with error code {0}..
        /// </summary>
        internal static string Error_LaunchFailedNoError {
            get {
                return ResourceManager.GetString("Error_LaunchFailedNoError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DNX Runtime failed to start. Error output:
        ///
        ///{0}.
        /// </summary>
        internal static string Error_LaunchFailedWithError {
            get {
                return ResourceManager.GetString("Error_LaunchFailedWithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal implementation error. Missing required output param..
        /// </summary>
        internal static string Error_MissingOutParam {
            get {
                return ResourceManager.GetString("Error_MissingOutParam", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: property &apos;{1}&apos; is missing, null, or empty.
        /// </summary>
        internal static string Error_PropertyMissing {
            get {
                return ResourceManager.GetString("Error_PropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to attach. {0}.
        /// </summary>
        internal static string Error_Scenario_Attach {
            get {
                return ResourceManager.GetString("Error_Scenario_Attach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to continue. {0}.
        /// </summary>
        internal static string Error_Scenario_Continue {
            get {
                return ResourceManager.GetString("Error_Scenario_Continue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to evaluate expression. {0}.
        /// </summary>
        internal static string Error_Scenario_Evaluate {
            get {
                return ResourceManager.GetString("Error_Scenario_Evaluate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to launch. {0}.
        /// </summary>
        internal static string Error_Scenario_Launch {
            get {
                return ResourceManager.GetString("Error_Scenario_Launch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read memory. {0}.
        /// </summary>
        internal static string Error_Scenario_ReadMemory {
            get {
                return ResourceManager.GetString("Error_Scenario_ReadMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to step in. {0}.
        /// </summary>
        internal static string Error_Scenario_Step_In {
            get {
                return ResourceManager.GetString("Error_Scenario_Step_In", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to step next. {0}.
        /// </summary>
        internal static string Error_Scenario_Step_Next {
            get {
                return ResourceManager.GetString("Error_Scenario_Step_Next", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to step out. {0}.
        /// </summary>
        internal static string Error_Scenario_Step_Out {
            get {
                return ResourceManager.GetString("Error_Scenario_Step_Out", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not set variable.
        /// </summary>
        internal static string Error_SetVariableFailed {
            get {
                return ResourceManager.GetString("Error_SetVariableFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified path &apos;{0}&apos; in sourceFileMap is invalid.
        /// </summary>
        internal static string Error_SourceFileMapEntryInvalid {
            get {
                return ResourceManager.GetString("Error_SourceFileMapEntryInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified path in sourceFileMap is empty.
        /// </summary>
        internal static string Error_SourceFileMapEntryNull {
            get {
                return ResourceManager.GetString("Error_SourceFileMapEntryNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the current stack frame.
        /// </summary>
        internal static string Error_StackFrameNotFound {
            get {
                return ResourceManager.GetString("Error_StackFrameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to perform this action because the process is running..
        /// </summary>
        internal static string Error_TargetNotStopped {
            get {
                return ResourceManager.GetString("Error_TargetNotStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse &apos;logMessage&apos;..
        /// </summary>
        internal static string Error_UnableToParseLogMessage {
            get {
                return ResourceManager.GetString("Error_UnableToParseLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error setting breakpoint. {0}.
        /// </summary>
        internal static string Error_UnableToSetBreakpoint {
            get {
                return ResourceManager.GetString("Error_UnableToSetBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be assigned to.
        /// </summary>
        internal static string Error_VariableIsReadonly {
            get {
                return ResourceManager.GetString("Error_VariableIsReadonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find variable.
        /// </summary>
        internal static string Error_VariableNotFound {
            get {
                return ResourceManager.GetString("Error_VariableNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Launching browser ({0} {1}).
        /// </summary>
        internal static string Info_LaunchBrowser {
            get {
                return ResourceManager.GetString("Info_LaunchBrowser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Locals.
        /// </summary>
        internal static string Locals_Scope_Name {
            get {
                return ResourceManager.GetString("Locals_Scope_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debugger failed to signal process termination..
        /// </summary>
        internal static string MissingDebuggerTerminationEvent {
            get {
                return ResourceManager.GetString("MissingDebuggerTerminationEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message is improperly formatted or was damaged in transit..
        /// </summary>
        internal static string Msg_COMQC_E_BAD_MESSAGE {
            get {
                return ResourceManager.GetString("Msg_COMQC_E_BAD_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access is denied..
        /// </summary>
        internal static string Msg_E_ACCESSDENIED {
            get {
                return ResourceManager.GetString("Msg_E_ACCESSDENIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is not supported when debugging dump files..
        /// </summary>
        internal static string Msg_E_CRASHDUMP_UNSUPPORTED {
            get {
                return ResourceManager.GetString("Msg_E_CRASHDUMP_UNSUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object invoked has disconnected from its clients..
        /// </summary>
        internal static string Msg_RPC_E_DISCONNECTED {
            get {
                return ResourceManager.GetString("Msg_RPC_E_DISCONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The debug engine threw an exception..
        /// </summary>
        internal static string Msg_RPC_E_SERVERFAULT {
            get {
                return ResourceManager.GetString("Msg_RPC_E_SERVERFAULT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation failed with error code 0x{0:x8}..
        /// </summary>
        internal static string Msg_UnknownError {
            get {
                return ResourceManager.GetString("Msg_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: .
        /// </summary>
        internal static string Prefix_Error {
            get {
                return ResourceManager.GetString("Prefix_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: .
        /// </summary>
        internal static string Prefix_Warning {
            get {
                return ResourceManager.GetString("Prefix_Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The program &apos;{0}&apos; has exited with code {1} (0x{1:x8}).
        ///.
        /// </summary>
        internal static string ProcessExitMessage {
            get {
                return ResourceManager.GetString("ProcessExitMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not detect launch url..
        /// </summary>
        internal static string Warning_LaunchBrowserCannotDetectUrl {
            get {
                return ResourceManager.GetString("Warning_LaunchBrowserCannotDetectUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: Launching browser failed. Error = {0}.
        /// </summary>
        internal static string Warning_LaunchBrowserFailed {
            get {
                return ResourceManager.GetString("Warning_LaunchBrowserFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING: Unable to terminate &apos;{0}&apos; process. {1}
        ///.
        /// </summary>
        internal static string Warning_Scenario_TerminateProcess {
            get {
                return ResourceManager.GetString("Warning_Scenario_TerminateProcess", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to get memory context.
        ///.
        /// </summary>
        internal static string Error_GetMemoryContext {
            get {
                return ResourceManager.GetString("Error_GetMemoryContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get disassembly stream.
        ///.
        /// </summary>
        internal static string Error_GetDisassemblyStream {
            get {
                return ResourceManager.GetString("Error_GetDisassemblyStream", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to read disassembly stream.
        ///.
        /// </summary>
        internal static string Error_ReadDisassemblyStream {
            get {
                return ResourceManager.GetString("Error_ReadDisassemblyStream", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to convert memory context to code context.
        ///.
        /// </summary>
        internal static string Error_ConvertMemoryContext {
            get {
                return ResourceManager.GetString("Error_ConvertMemoryContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to seek disassembly stream.
        ///.
        /// </summary>
        internal static string Error_SeekDisassemblyStream {
            get {
                return ResourceManager.GetString("Error_SeekDisassemblyStream", resourceCulture);
            }
        }
    }
}
