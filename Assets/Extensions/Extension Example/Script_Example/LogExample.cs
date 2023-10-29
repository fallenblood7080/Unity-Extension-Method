using UnityEngine;
using TMPro;

namespace Extension.Example
{
    public class LogExample : MonoBehaviour
    {
        [SerializeField] private TMP_InputField logInputField;
        [SerializeField] private Color logColor = Color.white;
        [SerializeField] private int fontSize = 10;
        public void ShowMsg()
        {
            //General syntax => <String>.log([Color],[fontsize])
            string colorCode = ColorUtility.ToHtmlStringRGB(logColor);
            logInputField.text.Log(colorCode, fontSize);
        }
    } 
}
