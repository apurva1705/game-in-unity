using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour {
    public Button Button1;
    public GameObject Room2;
    public GameObject Parent;
    public ParticleSystem particlePrefab;

    // Use this for initialization
    void Start() {
        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        StartCoroutine(CreateParticleSystem());
    }

    IEnumerator CreateParticleSystem()
    {
        var newdoor=Instantiate(Room2, Parent.transform.position, Quaternion.identity, Parent.transform.parent);
        var rt = newdoor.transform as RectTransform;
        rt.offsetMin = rt.offsetMax = Vector2.zero;
        Parent.SetActive(false);
        Vector3 instantiatePosition = Input.mousePosition;
        instantiatePosition.z = -5;
        ParticleSystem particles = Instantiate(particlePrefab, instantiatePosition, Quaternion.identity);
        Debug.Log(instantiatePosition);

        yield return new WaitForSeconds(particles.main.startLifetime.constant);
        
        Destroy(Parent);
    }


}
