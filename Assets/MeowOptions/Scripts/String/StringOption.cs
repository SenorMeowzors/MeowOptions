using UnityEngine;

namespace MeowOptions
{
    [CreateAssetMenu(fileName = "StringOption", menuName = "Meowzors/String Option", order = 1)]
    public class StringOption : Option<string>
    {
        public StringOption(string key) : base(key) { }

        public override string Value
        {
            get
            {
                return PlayerPrefs.GetString(key, defaultValue);
            }
            set
            {
                PlayerPrefs.SetString(key, value);
                base.Value = value;
            }
        }
    }
}