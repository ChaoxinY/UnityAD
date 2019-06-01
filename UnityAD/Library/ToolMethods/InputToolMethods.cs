using UnityEngine;
using UnityEditor;

namespace UnityAD
{
    public class InputToolMethod
    {
        public string lastInputString = null;
        public SerializedProperty axisArray;

        public bool IsInputRepeated()
        {
            bool isRepeated = false;
            string curretnStringInput = ReturnInputString();
            if (string.IsNullOrEmpty(curretnStringInput))
            {
                lastInputString = null;
                return isRepeated;
            }
            if (curretnStringInput != lastInputString)
            {
                lastInputString = curretnStringInput;
            }
            else if (curretnStringInput == lastInputString)
            {
                isRepeated = true;
            }

            return isRepeated;
        }

        public string ReturnInputString()
        {
            string buttonString = null;

            if (axisArray == null)
            {
                Object inputManager = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0];
                SerializedObject obj = new SerializedObject(inputManager);
                axisArray = obj.FindProperty("m_Axes");
            }

            for (int i = 0; i < axisArray.arraySize; ++i)
            {
                SerializedProperty axis = axisArray.GetArrayElementAtIndex(i);
                string name = axis.FindPropertyRelative("m_Name").stringValue;
                //int axisType = axis.FindPropertyRelative("type").enumValueIndex;
                //Might not work if controller axis are considered as buttons 
                //Not returning string when hitting buttons 
                if (Input.GetButton(name))
                {
                    buttonString = name;
                    return buttonString;
                }
                else if (Input.GetAxis(name) != 0)
                {
                    buttonString = name;
                    return buttonString;
                }
            }
            return buttonString;
        }

        public string ReturnJoyStickOrder(string inputString)
        {
            string JoyStickOrder = inputString.Substring(0, 3);
            return JoyStickOrder;
        }
    }
}

