using TMPro;
using UnityEngine;

namespace MeowOptions
{
    public class SetIntFromTMPInputField : MonoBehaviour
    {
        public IntOption intOption;
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

            if (!intOption)
            {
                Debug.LogWarning(name + " does not have an IntOption!", gameObject);
                return;
            }

            field.text = intOption.Value.ToString();
            field.onValueChanged.AddListener(delegate (string value) { if (int.TryParse(value, out int result)) intOption.Value = result; });
        }
    }
}