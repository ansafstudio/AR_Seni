using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour {
    public GameObject MainMenu;
    public GameObject PetunjukMenu;
    public GameObject MateriMenu;
    public GameObject PenugasanMenu;
    public GameObject TentangMenu;

	public AudioSource soundPenugasan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartAR()
    {
        MainMenu.SetActive(false);
        PetunjukMenu.SetActive(false);
        MateriMenu.SetActive(false);
        PenugasanMenu.SetActive(false);
        TentangMenu.SetActive(false);
    }

    public void BackToMainMenu()
    {
        MainMenu.SetActive(true);
        PetunjukMenu.SetActive(false);
        MateriMenu.SetActive(false);
        PenugasanMenu.SetActive(false);
        TentangMenu.SetActive(false);

		soundPenugasan.Stop ();
    }

    public void OpenEvaluasi()
    {
        Application.OpenURL("https://goo.gl/forms/YNaUYQMDFRheOWrM2");
    }

    public void OpenPetunjuk()
    {
        MainMenu.SetActive(false);
        PetunjukMenu.SetActive(true);
        MateriMenu.SetActive(false);
        PenugasanMenu.SetActive(false);
        TentangMenu.SetActive(false);
    }

    public void OpenMateri()
    {
        MainMenu.SetActive(false);
        PetunjukMenu.SetActive(false);
        MateriMenu.SetActive(true);
        PenugasanMenu.SetActive(false);
        TentangMenu.SetActive(false);
    }

    public void OpenPenugasan()
    {
        MainMenu.SetActive(false);
        PetunjukMenu.SetActive(false);
        MateriMenu.SetActive(false);
        PenugasanMenu.SetActive(true);
        TentangMenu.SetActive(false);

		soundPenugasan.Play ();
    }

    public void OpenTentang()
    {
        MainMenu.SetActive(false);
        PetunjukMenu.SetActive(false);
        MateriMenu.SetActive(false);
        PenugasanMenu.SetActive(false);
        TentangMenu.SetActive(true);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
