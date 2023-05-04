using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{

    // liste des sites
    public GameObject[] objSites;

    //menu
    public GameObject canvasMainMenu;

    //un boolean pour vérifier si on est dans le menu ou dans une visite
    public bool isCameraMove = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCameraMove){
            if(Input.GetKeyDown(KeyCode.Escape)){
                ReturnToMenu();
            }
        }
    }

    public void LoadSite(int siteNum){
        //affichage des Sites
        objSites[siteNum].SetActive(true);
        //cacher menu
        canvasMainMenu.SetActive(false);
        //activer la camera
        isCameraMove = true;
    }

    public void ReturnToMenu(){
        //afficher le menu
        canvasMainMenu.SetActive(true);
        //cacher les sites
        for(int i=0; i < objSites.Length; i++){
            objSites[i].SetActive(false);
        }
        //désactiver la camera
        isCameraMove = false;
    }
}
