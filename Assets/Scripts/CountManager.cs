using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    public int number,limit;
    public GameObject rowPrefab;
    public GameObject contianer;

    public List<GameObject> rowList;
    public List<RowCount> rowNumberList;

    public void increaseNum()
    {
        if (number < limit-1)
        {
            number++;
            createRow();
        }
    }
    public void decreaseNum()
    {
        if (number > 0)
        {
            number--;
            removeRow();
        }
    }

    public void createRow()
    {
        GameObject thisrow = Instantiate(rowPrefab,new Vector3(0,0,0),this.transform.rotation,contianer.transform);
        RowCount rowNUM = thisrow.GetComponent<RowCount>();

        rowNUM.number = number + 1;

        rowList.Add(thisrow);
        rowNumberList.Add(rowNUM);
    }

    public void removeRow()
    {
        Destroy(rowList[rowList.Count-1]);
        Destroy(rowNumberList[rowNumberList.Count - 1]);

        rowList.RemoveAt(rowList.Count - 1);
        rowNumberList.RemoveAt(rowNumberList.Count - 1);
    }
}
