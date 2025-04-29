using TMPro;
using UnityEngine;

public class RowCount : MonoBehaviour
{
    public TextMeshProUGUI rowLabel;
    public int number;

    void Start()
    {
        rowLabel.text = "Row " + number.ToString();
    }
}
