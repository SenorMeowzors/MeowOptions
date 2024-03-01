using UnityEngine;
#pragma warning disable CS0693 // Type parameter has the same name as the type parameter from outer type

namespace MeowOptions
{
    public abstract class OptionBase : ScriptableObject
    {
        [Tooltip("The key of the PlayerPref to write to.")]
        [SerializeField]
        protected string key;

        /// <summary>
        /// Invokes the event OnValueChanged event.
        /// </summary>
        public abstract void Refresh();
    }

    public abstract class Option<T> : OptionBase
    {

        [Tooltip("The default value of this Option. Will written to PlayerPrefs when values is modified for the first time.")]
        [SerializeField]
        protected T defaultValue;

        public delegate void OnOptionChanged<T>(T loadedValue);
        public event OnOptionChanged<T> OnValueChanged;

        public Option(string key)
        {
            this.key = key;
        }

        public override void Refresh()
        {
            OnValueChanged?.Invoke(Value);
        }

        /// <summary>
        /// The Value of this Option.
        /// </summary>
        public virtual T Value
        {
            get
            {
                return default;
            }
            set
            {
                Refresh();
            }
        }

        /// <summary>
        /// Sets Value to defaultValue.
        /// </summary>
        public void ResetToDefault()
        {
            Value = defaultValue;
        }
    }
}