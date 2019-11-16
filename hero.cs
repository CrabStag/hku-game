using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    private bool spaceIngedrukt = false;
    // Start is called before the first frame update
    void Start()
    {
    }

	private void Awake()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceIngedrukt = true;
            Debug.Log("Space key was pressed."+spaceIngedrukt);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            spaceIngedrukt = false;
            Debug.Log("Space key was released."+spaceIngedrukt);
        }
        if (spaceIngedrukt)
        {
            m_Rigidbody2D.AddForce(new Vector2(10f, 0f));
        }
        
    }
}
