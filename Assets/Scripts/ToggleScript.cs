using TMPro;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public TextMeshProUGUI ZeroOrOne;
    public bool selection;

    void Update()
    {
        if(selection)
        {
            ZeroOrOne.text = "1";
        }
        else
        {
            ZeroOrOne.text = "0";
        }
    }

    public void updateSelection(bool selectionA)
    {
        selection = selectionA;
    }
}
