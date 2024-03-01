using UnityEngine;

namespace MeowOptions
{
    [CreateAssetMenu(fileName = "BoolOption", menuName = "Meowzors/Bool Option", order = 1)]
    public class BoolOption : Option<bool>
    {
        public BoolOption(string key) : base(key) { }

        public override bool Value
        {
            get
            {
                return PlayerPrefs.GetInt(key, AsInt(defaultValue)) == 1;
            }
            set
            {
                PlayerPrefs.SetInt(key, AsInt(value));
                base.Value = value;
            }
        }

        int AsInt(bool value)
        {
            var val = 0;
            if (value == true)
            {
                val = 1;
            }

            return val;
        }
    }
}
