using UnityEngine;

namespace MeowOptions
{
    [CreateAssetMenu(fileName = "FloatOption", menuName = "Meowzors/Float Option", order = 1)]
    public class FloatOption : Option<float>
    {
        public FloatOption(string key) : base(key) { }

        public override float Value
        {
            get
            {
                return PlayerPrefs.GetFloat(key, defaultValue);
            }
            set
            {
                PlayerPrefs.SetFloat(key, value);
                base.Value = value;
            }
        }
    }
}