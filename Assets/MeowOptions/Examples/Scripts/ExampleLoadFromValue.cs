using MeowOptions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExampleLoadFromValue : MonoBehaviour
{
   
    [SerializeField] BoolOption boolOption;
    [SerializeField] TextMeshProUGUI boolLabel;

    [Space(10)]
    [SerializeField] FloatOption floatOption;
    [SerializeField] TextMeshProUGUI floatLabelInput;

    [Space(10)]
    [SerializeField] IntOption intOption;
    [SerializeField] TextMeshProUGUI intLabelInput;

    [Space(10)]
    [SerializeField] StringOption stringOption;
    [SerializeField] TextMeshProUGUI stringLabelInput;

    [Space(10)]
    [SerializeField] FloatOption floatOptionSlider;
    [SerializeField] TextMeshProUGUI floatSliderLabel;
    [SerializeField] Slider floatSlider;

    [Space(10)]
    [SerializeField] IntOption intOptionSlider;
    [SerializeField] TextMeshProUGUI intSliderLabel;
    [SerializeField] Slider intSlider;

    private void Start()
    {
        SubscribeToValueChanges();

        LoadOptions();
    }

    /// <summary>
    /// Applies the current values listeners
    /// </summary>
    private void LoadOptions()
    {
        boolOption.Refresh();
        floatOption.Refresh();
        intOption.Refresh();
        stringOption.Refresh();
        floatOptionSlider.Refresh();
        intOptionSlider.Refresh();
    }

    /// <summary>
    /// Assign logic to whenever the values changes
    /// </summary>
    private void SubscribeToValueChanges()
    {
        boolOption.OnValueChanged += delegate { boolLabel.text = boolOption.Value.ToString(); };
        floatOption.OnValueChanged += delegate { floatLabelInput.text = floatOption.Value.ToString(); };
        intOption.OnValueChanged += delegate { intLabelInput.text = intOption.Value.ToString(); };
        stringOption.OnValueChanged += delegate { stringLabelInput.text = stringOption.Value.ToString(); };
        floatOption.OnValueChanged += delegate { floatLabelInput.text = floatOption.Value.ToString(); };
        floatOptionSlider.OnValueChanged += delegate { floatSliderLabel.text = floatOptionSlider.Value.ToString(); };
        intOptionSlider.OnValueChanged += delegate { intSliderLabel.text = intOptionSlider.Value.ToString(); };
    }

    public void Button_ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
