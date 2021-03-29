using System.Diagnostics;
using System.Runtime.CompilerServices;
using ProGraphGroup.Singletons;
using Sirenix.Utilities;
using UnityEditor.PackageManager;

namespace ProGraphGroup.Manager
{
    public class LogManager : MonoSingleton<LogManager>
    {
        public bool isActive = true;
        public LogLevel logLevel = LogLevel.Debug;


        public void debug(string msg, string data = "", [CallerMemberName] string callerName = "", [CallerLineNumber] int callerLineNumber = 0)
        {
            if (!isActive && logLevel < LogLevel.Debug)
                return;
            StackFrame parentStackFrame = (new StackTrace()).GetFrame(1);
            string className = parentStackFrame.GetMethod().ReflectedType.GetNiceName();
            className=  className.Substring(0, className.IndexOf('.'));
            Debug.Log($"[{className}][{callerName}][{callerLineNumber}] - {msg}: {data}");
        }


        public void error(string msg, string data = "")
        {
            if (!isActive && logLevel < LogLevel.Error)
                return;
            StackFrame parentStackFrame = (new StackTrace()).GetFrame(1);
            Debug.LogError($"[{parentStackFrame.GetType().Name}][{parentStackFrame.GetMethod().Name}] - {msg}: {data}");
        }

        public void warn(string msg, string data = "")
        {
            if (!isActive && logLevel < LogLevel.Warn)
                return;
            StackFrame parentStackFrame = (new StackTrace()).GetFrame(1);
            Debug.LogWarning(
                $"[{parentStackFrame.GetType().Name}][{parentStackFrame.GetMethod().Name}] - {msg}: {data}");
        }

        public void info(string msg, string data = "")
        {
            if (!isActive && logLevel < LogLevel.Info)
                return;
            StackFrame parentStackFrame = (new StackTrace()).GetFrame(1);
            Debug.Log($"[{parentStackFrame.GetType().Name}][{parentStackFrame.GetMethod().Name}] - {msg}: {data}");
        }
    }
}