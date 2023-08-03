using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class depremDusme : MonoBehaviour
{
    public GameObject dolap, televizyon, mutfakDolabi1 , microFirin, monitor, pcSandalye;
    public Camera cam;

    public Vector3 dolapDustuktenSonra = new Vector3(-9.47700024f, 0.860000014f, 14.1891975f);
    public Vector3 televizyonSonra = new Vector3(-0.59799999f, 0.166999996f, -5.19099998f);
    public Vector3 mutDolabiSonra = new Vector3(-16.9482899f, 1.67700005f, 11.1999998f);
    public Vector3 microFirinSonra = new Vector3(-15.1662245f, 0.349000007f, 13.665f);
    public Vector3 monitorSonra = new Vector3(12.9119997f, 0.123000003f, -5.55299997f);
    public Vector3 pcSandalyeSonra = new Vector3(-1.5f, 2.1f, 4.6f);








    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cam.DOShakePosition(5,1,1);
        if (Input.GetKeyDown(KeyCode.T))
        {
            dolap.transform.DOMove(dolapDustuktenSonra, 1f);
            dolap.transform.DORotate(new Vector3(-90f, 0, 0), 1f);
            
            
            televizyon.transform.DOMove(televizyonSonra, 1f);
            televizyon.transform.DORotate(new Vector3(86.3856201f, 180f, 0), 1f);



            
            mutfakDolabi1.transform.DOMove(mutDolabiSonra, 1f);
            mutfakDolabi1.transform.DORotate(new Vector3(-120f, -90f, 0), 1f);

            microFirin.transform.DOMove(microFirinSonra, 1f);
            microFirin.transform.DORotate(new Vector3(-90f,0,0),1f);

            monitor.transform.DOMove(monitorSonra, 1f);
            monitor.transform.DORotate(new Vector3(0,115f,180), -90);

            pcSandalye.transform.DOMove(pcSandalyeSonra, 1f);
            pcSandalye.transform.DORotate(new Vector3(64f , -90f ,0), 1f);



        }
    }
}
