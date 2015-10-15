using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Button m_Button;
    public Image m_Image;
    public RawImage m_RawImage;

    public Toggle m_Toggle;
    public Toggle m_Toggle2;
    public ToggleGroup m_ToggleGroup;
    public Slider m_Slider;
    public Dropdown m_DropDown;
    public InputField m_InputField;
    public ScrollRect m_ScrollRect;
    public Scrollbar m_ScrollBar;

    // Use this for initialization
    void Start()
    {
        JustDoIt();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnGUI()
    {
        if (GUILayout.Button("gettogglegroup"))
        {
            gettogglegroup();
        }

        GUILayout.TextField(temp);
    }

    private string temp="";
    void JustDoIt()
    {
        m_Button.onClick.AddListener(onbuttonclick);

        m_ToggleGroup.RegisterToggle(m_Toggle);
        m_ToggleGroup.RegisterToggle(m_Toggle2);

        m_Toggle.onValueChanged.AddListener(togglevaluechanged);

        m_Slider.onValueChanged.AddListener(slidervaluechanged);

        m_DropDown.onValueChanged.AddListener(dpdownvaluechanged);
        m_InputField.onValueChange.AddListener(inputnvaluechanged);

        m_ScrollRect.onValueChanged.AddListener(scrollvaluechanged);
    }

    void gettogglegroup()
    {
        temp = m_ToggleGroup.ActiveToggles().Any()? string.Join(",", m_ToggleGroup.ActiveToggles().Select(item=>item.transform.name).ToArray()) : "";
    }

    void togglevaluechanged(bool adfa)
    {
        temp = adfa.ToString();
    }

    void slidervaluechanged(float adfa)
    {
        temp = adfa.ToString();
    }

    void dpdownvaluechanged(int adfa)
    {
        temp = adfa.ToString();
    }

    void inputnvaluechanged(string adfa)
    {
        temp = adfa.ToString();
    }

    void scrollvaluechanged(Vector2 adfasd)
    {
        temp = adfasd.ToString();
    }
    void onbuttonclick()
    {
        temp = "button";
    }
}
