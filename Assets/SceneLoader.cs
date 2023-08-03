using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{

    public Text sorakiText;
    public Button sonrakiButon;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //sorakiText.text = "Texte ne yazacagimiz buraya gelecek";
        //sonrakiButon.GetComponentInChildren<Text>().text = "tikla";
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // BUTONA BASILDIGINDA OLMALI
        if (Input.GetKeyDown(KeyCode.L))
        {
            SahneDegis();
        }
    }

    void SahneDegis()
    {
        // NEW SCENE ADINDAKI SAHNEYI YUKLER
        SceneManager.LoadScene("New Scene");


        
    }
    
    
    // Butona tiklandiginda sahneyi degistiren fonksiyonu cagir.
    public void OnButtonClicked()
    {
       
        
        SahneDegis();

    }
    








}
