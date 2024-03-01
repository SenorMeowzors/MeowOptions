using UnityEngine;
using UnityEngine.UI;

namespace MeowOptions
{
    public class SetIntFromSlider : MonoBehaviour
    {
        public IntOption intOption;
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

            if (!intOption)
            {
                Debug.LogWarning(name + " does not have an IntOption!", gameObject);
                return;
            }

            slider.value = intOption.Value;
            slider.onValueChanged.AddListener(delegate (float value) { intOption.Value = (int)value; });
        }
    }
}