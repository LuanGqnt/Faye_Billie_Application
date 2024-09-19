using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InspectPanel : MonoBehaviour {

    public TextMeshProUGUI nameUI;
    public TextMeshProUGUI elementUI;
    public TextMeshProUGUI descriptionUI;
    public RawImage imageUI;

    void Start() {
        nameUI = transform.Find("name").GetComponent<TextMeshProUGUI>();
        elementUI = transform.Find("element").GetComponent<TextMeshProUGUI>();
        descriptionUI = transform.Find("description").GetComponent<TextMeshProUGUI>();
        imageUI = transform.Find("RawImage").GetComponent<RawImage>();

        Hide();
    }

    public void Inspect(string name_, string element, string description, Texture image) {
        nameUI.text = name_;
        elementUI.text = element;
        descriptionUI.text = description;
        imageUI.texture = image;

        Show();
    }

    public void Show() {
        GetComponent<RectTransform>().localPosition = new Vector3(0f, 0f, 0f);
    }

    public void Hide() {
        GetComponent<RectTransform>().localPosition = new Vector3(5000f, 0f, 0f);
    }

}
