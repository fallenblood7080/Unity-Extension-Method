using UnityEngine;
using TMPro;
using UnityEditor;
using System.Collections.Generic;

namespace Extension.Example
{
    public class CommonExtensionExample : MonoBehaviour
    {
        [Header("Log")]
        [SerializeField] private string logInput;
        [SerializeField] private Color logColor = Color.white;
        [SerializeField] private int fontSize = 10;

        [Header("RandomItems")]
        [SerializeField] private List<int> someNum = new List<int>() { 2, 5, 8, 1, 67, 76, 7, 78, 55, 56 };
        [SerializeField] private int howManyRandomNeeded = 1;

        public void ShowMsg()
        {
            //General syntax => <String>.log([Color],[fontsize])
            string colorCode = ColorUtility.ToHtmlStringRGB(logColor);
            logInput.Log(colorCode, fontSize);
        }
        public void GiveSomeRandomItems()
        {
            List<int> randomItems = someNum.GetRandomItems<int>(howManyRandomNeeded);
            string items = "";
            foreach (var item in randomItems)
            {
                items += $"{item}   ";
            }
            items.Log();
        }
    }
    [CustomEditor(typeof(CommonExtensionExample))]
    public class CommonExtensionExampleEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            CommonExtensionExample common = (CommonExtensionExample)target;
            if(GUILayout.Button("Log Message"))
            {
                common.ShowMsg();
            }
            if (GUILayout.Button("GetRandomItems"))
            {
                common.GiveSomeRandomItems();
            }
        }
    }
}
