using UnityEngine;
using UnityEngine.UI;

namespace MeowOptions
{
    public class SetIntFromInputField : MonoBehaviour
    {
        public IntOption intOption;
        public InputField field;

        private void Awake()
        {
            if (!field)
            {
                field = GetComponent<InputField>();
                if (!field)
                {
                    Debug.LogWarning(name + " does not have a slider!", gameObject);
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