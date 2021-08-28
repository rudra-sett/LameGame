using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCity : MonoBehaviour
{
    [SerializeField]
    GameObject buildingunit;

    // Start is called before the first frame update
    void Start()
    {
        //so uh, we've got a 500x 500 map
        //coordinates for buildings range from -225,Y,-225 all the way to 225,Y,225
        //or uh buildings can only spawn on areas that are multiples of 10

        for (int x = -24; x < 25; x++) {
            for (int z = -24; z < 25; z++)
            {
                //yay new building place
                //let's say like... 4/7 chance of a building existing
                int buildingornot = Random.Range(1, 7);
                if (buildingornot < 3)
                {
                    //yay building!
                    int stories = Random.Range(1, 10);
                    for (int i = 0; i < stories; i++)
                    {
                        Instantiate(buildingunit, new Vector3(x*10, 2.5f+5*i, z*10), Quaternion.identity);
                    }

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
