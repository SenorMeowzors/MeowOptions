using UnityEngine;
using UnityEngine.UI;

namespace MeowOptions
{
    public class SetBoolFromToggle : MonoBehaviour
    {
        public BoolOption boolOption;
        public Toggle toggle;

        private void Awake()
        {
            if(!toggle)
            {
                toggle = GetComponent<Toggle>();
                if (!toggle)
                {
                    Debug.LogWarning(name + " does not have a Toggle!", gameObject);
                    return; 
                }
            }

            if (!boolOption)
            {
                Debug.LogWarning(name + " does not have a BoolOption!", gameObject);
                return;
            }

            toggle.isOn = boolOption.Value;
            toggle.onValueChanged.AddListener(delegate (bool value) { boolOption.Value = value; });
        }
    }
}