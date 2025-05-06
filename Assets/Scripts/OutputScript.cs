using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OutputScript : MonoBehaviour
{
    public ToggleScript A, B;

    public TextMeshProUGUI outputText;
    public int outputInt;
    public TMP_Dropdown dropdown;

    public Toggle aaa;
    public ToggleScript outputToggle;


    public enum LogicGateMode
    {
        AND,
        OR,
        NAND,
        NOR,
        XOR,
        XNOR,
        IMPLY,
        NIMPLY,
    }

    public LogicGateMode mode;

    void Update()
    {
        changeMode();
        outputText.text = outputInt.ToString();
        switch (mode)
        {
            case LogicGateMode.AND:
                if (A.selection == true && B.selection == true)
                {
                    outputInt = 1;
                }
                else
                {
                    outputInt = 0;
                }
                break;
            case LogicGateMode.OR:
                if (A.selection == true || B.selection == true)
                {
                    outputInt = 1;
                }
                else
                {
                    outputInt = 0;
                }
                break;
            case LogicGateMode.NAND:
                if(A.selection == true && B.selection == true)
                {
                    outputInt = 0;
                }
                else
                {
                    outputInt = 1;
                }
                break;
            case LogicGateMode.NOR:
                if(A.selection == false && B.selection == false)
                {
                    outputInt = 1;
                }
                else
                {
                    outputInt = 0;
                }
                break;
            case LogicGateMode.XOR:
                if(A.selection == B.selection)
                {
                    outputInt = 0;
                }
                else
                {
                    outputInt = 1;
                }
                break;
            case LogicGateMode.XNOR:
                if (A.selection == B.selection)
                {
                    outputInt = 1;
                }
                else
                {
                    outputInt = 0;
                }
                break;
            case LogicGateMode.IMPLY:
                if(A.selection == B.selection)
                {
                    outputInt = 1;
                }
                else if(B.selection == true)
                {
                    outputInt = 1;
                }
                else if(B.selection == false)
                {
                    outputInt = 0;
                }
                break;
            case LogicGateMode.NIMPLY:
                if (A.selection == B.selection)
                {
                    outputInt = 0;
                }
                else if (B.selection == true)
                {
                    outputInt = 0;
                }
                else if (B.selection == false)
                {
                    outputInt = 1;
                }
                break;
        }
        if(outputToggle != null)
        {
            if (outputInt == 1)
            {
                aaa.isOn = true;
                outputToggle.selection = true;
            }
            else
            {
                aaa.isOn = false;
                outputToggle.selection = false;
            }
        }
    }

    public void changeMode()
    {
        switch (dropdown.value)
        {
            case 0:
                mode = LogicGateMode.AND; break;
            case 1:
                mode = LogicGateMode.OR; break;
            case 2:
                mode = LogicGateMode.NAND; break;
            case 3:
                mode = LogicGateMode.NOR; break;
            case 4:
                mode = LogicGateMode.XOR; break;
            case 5:
                mode = LogicGateMode.XNOR; break;
            case 6:
                mode = LogicGateMode.IMPLY; break;
            case 7:
                mode = LogicGateMode.NIMPLY; break;
        }
    }
}
