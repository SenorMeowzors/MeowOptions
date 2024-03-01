using UnityEngine;
using UnityEngine.UI;

namespace MeowOptions
{
    public class SetStringFromInputField : MonoBehaviour
    {
        public StringOption stringOption;
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

                if (!stringOption)
                {
                    Debug.LogWarning(name + " does not have a StringOption!", gameObject);
                    return;
                }
            }

            field.text = stringOption.Value;
            field.onValueChanged.AddListener(delegate (string value) { stringOption.Value = value; });
        }
    }
}