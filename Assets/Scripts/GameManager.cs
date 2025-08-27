using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    GameObject[] cubes;
    GameObject[] spheres;


    void Start()
    {
        //cubes = GameObject.FindGameObjectsWithTag("Cubes");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    foreach (GameObject i in cubes)
        //    {
        //        Destroy(i.gameObject);
        //    }
        //}\
        
   }

    private void OnMouseDown()
    {
        if(this.gameObject.tag == "Cubes")
        {
            Destroy(gameObject);
        }
    }
}
