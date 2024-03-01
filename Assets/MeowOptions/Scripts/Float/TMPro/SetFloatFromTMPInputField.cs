using TMPro;
using UnityEngine;

namespace MeowOptions
{
    public class SetFloatFromTMPInputField : MonoBehaviour
    {
        public FloatOption floatOption;
        public TMP_InputField field;

        private void Awake()
        {
            if (!field)
            {
                field = GetComponent<TMP_InputField>();
                if (!field)
                {
                    Debug.LogWarning(name + " does not have a Slider!", gameObject);
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