using UnityEngine;

public class DropObjectScript : MonoBehaviour {

    public TextMesh textObj;
    Transform objTrans;

    [HideInInspector]
    public float speed = 2f;
	// Use this for initialization
	void Start () {
        objTrans = this.GetComponent<Transform>();
        if (textObj != null)
        {
            textObj.text = MainDriver.Instance().GetRandomLetter().ToString();
            textObj.color = MainDriver.Instance().GetRandomColor();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (objTrans != null)
        {
            Vector3 movePOs = Vector3.down;
            movePOs.y *= Time.deltaTime * speed; 
            transform.Translate(movePOs, Space.World);
        }
	}

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
