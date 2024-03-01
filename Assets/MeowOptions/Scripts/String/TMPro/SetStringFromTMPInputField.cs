using TMPro;
using UnityEngine;

namespace MeowOptions
{
    public class SetStringFromTMPInputField : MonoBehaviour
    {
        public StringOption stringOption;
        public TMP_InputField field;

        private void Awake()
        {
            if(!field)
            {
                field = GetComponent<TMP_InputField>();
                if (!field)
                {
                    Debug.LogWarning(name + " does not have a TMP_InputField!", gameObject);
                    return;
                }

                if (!stringOption)
                {
                    Debug.LogWarning(name + " does not have a stringOption!", gameObject);
                    return;
                }
            }

            field.text = stringOption.Value;
            field.onValueChanged.AddListener(delegate (string value) { stringOption.Value = value; });
        }
    }
}