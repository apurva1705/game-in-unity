using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour {
    public Button Button1;
    public GameObject Room2;
    public GameObject Parent;
    // Use this for initialization
    void Start () {
        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Vector3 pos = new Vector3(0,0,0);
        Instantiate(Room2, pos, Quaternion.identity);
        Destroy(Parent);
    }


}
