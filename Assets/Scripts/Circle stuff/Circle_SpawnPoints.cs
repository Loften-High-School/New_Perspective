using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_SpawnPoints : MonoBehaviour

{
    [SerializeField] public List <GameObject> pointerspawnpoints = new List <GameObject> {};
    [SerializeField] public List <GameObject> mediumpointerspawnpoints = new List <GameObject> {};
    [SerializeField] public List <GameObject> hardpointerspawnpoints = new List <GameObject> {};
    [SerializeField] public List <GameObject> insanepointerspawnpoints = new List <GameObject> {};
    [SerializeField] public GameObject Easy_pointer;
    [SerializeField] public GameObject Medium_pointer;
    [SerializeField] public GameObject Hard_pointer;
    [SerializeField] public GameObject Insane_pointer;
    public Circle_Difficulty difficulty; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D collider)
    {  
        if(collider.gameObject.CompareTag("point"))
            {
                Debug.Log("You got a point");
                if(difficulty.easy == true)
                {
                    GenerateNextPointer();
                }
                if(difficulty.medium == true)
                {
                    GenerateNextmediumPointer();
                }
                if(difficulty.hard == true)
                {
                    GenerateNexthardPointer();
                }
                if(difficulty.insane == true)
                {
                    GenerateNextinsanePointer();
                }
                Destroy(collider.gameObject); //destroys the gameobject it is colliding with. due to the if staetment it will only run when it's with the compare tag of point
            }
    }

     public void GenerateNextPointer()
    {
        GeneratePointer();
    }

     public void GenerateNextmediumPointer()
    {
        mediumGeneratePointer();
    }

     public void GenerateNexthardPointer()
    {
        hardGeneratePointer();
    }

     public void GenerateNextinsanePointer()
    {
        insaneGeneratePointer();
    }

    public void GeneratePointer()
    {
        Debug.Log("Pointer has spawned");

     
     for (var i= 0; i < 1  ; i++)
     
     { 
      int randomIndex  = Random.Range(0, pointerspawnpoints.Count-1);
      Vector3 pos = new Vector3 (pointerspawnpoints[randomIndex].transform.position.x, pointerspawnpoints[randomIndex].transform.position.y, pointerspawnpoints[randomIndex].transform.position.z);
      GameObject pointerInstantiate = Instantiate(Easy_pointer, pos, Quaternion.identity);
     }
    }

    public void mediumGeneratePointer()
    {
        Debug.Log("Pointer has spawned");

     
     for (var i= 0; i < 1  ; i++)
     
     { 
      int randomIndex  = Random.Range(0, mediumpointerspawnpoints.Count-1);
      Vector3 pos = new Vector3 (mediumpointerspawnpoints[randomIndex].transform.position.x, mediumpointerspawnpoints[randomIndex].transform.position.y, mediumpointerspawnpoints[randomIndex].transform.position.z);
      GameObject pointerInstantiate = Instantiate(Medium_pointer, pos, Quaternion.identity);
     }
    }

    public void hardGeneratePointer()
    {
        Debug.Log("Pointer has spawned");

     
     for (var i= 0; i < 1  ; i++)
     
     { 
      int randomIndex  = Random.Range(0, hardpointerspawnpoints.Count-1);
      Vector3 pos = new Vector3 (hardpointerspawnpoints[randomIndex].transform.position.x, hardpointerspawnpoints[randomIndex].transform.position.y, hardpointerspawnpoints[randomIndex].transform.position.z);
      GameObject pointerInstantiate = Instantiate(Hard_pointer, pos, Quaternion.identity);
     }
    }

    public void insaneGeneratePointer()
    {
        Debug.Log("Pointer has spawned");

     
     for (var i= 0; i < 1  ; i++)
     
     { 
      int randomIndex  = Random.Range(0, insanepointerspawnpoints.Count-1);
      Vector3 pos = new Vector3 (insanepointerspawnpoints[randomIndex].transform.position.x, insanepointerspawnpoints[randomIndex].transform.position.y, insanepointerspawnpoints[randomIndex].transform.position.z);
      GameObject pointerInstantiate = Instantiate(Insane_pointer, pos, Quaternion.identity);
     }
    }
}
