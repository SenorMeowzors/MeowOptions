# MeowOptions

 A quick way to setup `PlayerPrefs` using Scriptable Objects.

# Usage
See Examples in `Assets/MeowOptions/Examples/Scenes/MeowOptionsSample`

1. Create an Option from the Create menu `(Create -> Meowzors -> <Bool/Float/Int/String>Option)`
2. Assign a default value and PlayerPref name to your Option
3. Create your Slider/Textbox/Toggle
4. Attach a Set<Bool/Float/Int/String>From<Toggle/Slider/InputField/TMP_InputField> script to the adjustable component and assign your Option and the component
5. Create a separate `MonoBehavior` to manage functionality of your newly created Option Scriptable Object. (Preferably an options class)

![image](https://github.com/SenorMeowzors/MeowOptions/assets/33797022/30d877f3-367a-4db8-8c96-1d6c38ec1fec)


![image](https://github.com/SenorMeowzors/MeowOptions/assets/33797022/ed87e3fa-1ba8-4b31-9f80-a39d8b67cb69)

```
    [SerializeField] BoolOption boolOption;
    [SerializeField] TextMeshProUGUI boolLabel;

    private void Start()
    {
        boolOption.OnValueChanged += delegate { SomeMethod(); };
        boolOption.Refresh()
    }

    private void SomeMethod()
    {
        boolLabel.text = boolOption.Value.ToString();
    }
```

# Preview
https://github.com/SenorMeowzors/MeowOptions/assets/33797022/28bccdc2-1736-4552-aceb-3ab1ef90c905
