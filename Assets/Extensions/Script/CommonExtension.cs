using UnityEngine;

namespace Extension
{
    public static class CommonExtension
    {
        /// <summary>
        /// Write the log(string message) in console.Equivalent to Debug.Log()
        /// Example:
        /// <code>
        /// "Message".Log();
        /// "Message in RedColor".Log(logColorCode: "#ff0000");
        /// "Message in Red Color with 18 font Size".Log(logColorCode: "#ff0000",fontSize: 18);
        /// </code>
        /// </summary>
        /// <param name="message">Message to be wrriten in Unity Console</param>
        /// <param name="logColorCode">hexcode of color</param>
        /// <param name="fontSize">font size of message</param>
        public static void Log(this string message, string logColorCode = "#ffffff", int fontSize = 12)
        {
            Debug.Log($"<color={logColorCode}><size={fontSize}>{message}</size></color>");
        }
    } 
}
