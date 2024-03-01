using UnityEngine;
using UnityEngine.UI;

namespace MeowOptions
{
    public class SetFloatFromSlider : MonoBehaviour
    {
        public FloatOption floatOption;
        public Slider slider;

        private void Awake()
        {
            if(!slider)
            {
                slider = GetComponent<Slider>();
                if (!slider)
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

            slider.value = floatOption.Value;
            slider.onValueChanged.AddListener(delegate (float value) { floatOption.Value = value; });
        }
    }
}