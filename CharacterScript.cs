using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{

    public Animator anim;
    private float inputV;
    private float counter;
    private bool sahne2, sahne3;



    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        anim = GetComponent<Animator>();
        sahne2 = true;
        sahne3 = false;
    }

    // Update is called once per frame
    void Update()  //sahne2 ve sahne3'e gecis yaparak farkli yukseklik seviyeleri denenmesi saglaniyor.
    {
        counter = counter + Time.deltaTime;

        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputV", inputV);

        transform.Translate(0, 0, inputV * Time.deltaTime * 5f);

        if (counter >= 20 && sahne2 == true)
        {
            transform.position = new Vector3(2, 24, -10);
            sahne2 = false;
            sahne3 = true;
        }
        else if (counter >= 40 && sahne3 == true)
        {
            transform.position = new Vector3(144, 40, -55);
            sahne3 = false;
        }
    }
}