using UnityEngine;

namespace MeowOptions
{
    [CreateAssetMenu(fileName = "IntOption", menuName = "Meowzors/Int Option", order = 1)]
    public class IntOption : Option<int>
    {
        public IntOption(string key) : base(key) { }

        public override int Value
        {
            get
            {
                return PlayerPrefs.GetInt(key, defaultValue);
            }
            set
            {
                PlayerPrefs.SetInt(key, value);
                base.Value = value;
            }
        }
    }
}