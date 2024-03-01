using UnityEngine;
using UnityEngine.UI;

namespace MeowOptions
{
    public class SetFloatFromInputField : MonoBehaviour
    {
        public FloatOption floatOption;
        public InputField field;

        private void Awake()
        {
            if (!field)
            {
                field = GetComponent<InputField>();
                if (!field)
                {
                    Debug.LogWarning(name + " does not have an InputField!", gameObject);
                    return;
                }
            }

            if (!floatOption)
            {
                Debug.LogWarning(name + " does not have a FloatOption!", gameObject);
                return;
            }

            field.text = floatOption.Value.ToString();
            field.onValueChanged.AddListener(delegate (string value) { if (float.TryParse(value, out var result)) floatOption.Value = result; });
        }
    }
}