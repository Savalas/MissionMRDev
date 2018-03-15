using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    // Use this for initialization
    void Start()

    {

        //GameObject.Instantiate(TextHolder);
        //Transform txtMeshTransform = (Transform)Instantiate(TextHolder);
        //TextMesh txtMesh = txtMeshTransform.GetComponent<TextMesh>();
        // txtMesh.text = "New text set through script";
        // txtMesh.color = Color.red; // Set the text's color to red

        Debug.Log("i am here");

    }




    // Update is called once per frame
    void Update()
    {
        {
            string a = Input.inputString.ToString();
            var p = GameObject.Find("TextHolder");
            var fun = p.GetComponent("TextMesh");
            var textblob = (TextMesh)fun;

            
            textblob.text = a;
            Debug.Log("shorav");
        }
    }


    //if (Input.GetKey("up"))
    //  {
    //       textblob.text = "up key pressed";
    //  }
    //    if (Input.GetKey("down"))
    //    {
    //        textblob.text = "downkey pressed";
    //    }
    //     if (Input.GetKey("left"))
    //     {
    //         textblob.text = "left key pressed";
    //     }


    //  }
    //}
    //}
}