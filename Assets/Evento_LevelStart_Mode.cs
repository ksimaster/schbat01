﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UFE3D;
using UnityEngine.Analytics;

public class Evento_LevelStart_Mode : MonoBehaviour
{
    
    
    public int contadorIndex = 0;

 


    //*************abrir calificaciones post-versus*******************
    public static bool TerminoLaPeleaVersus = false;
    public  GameObject PanelOp;
    public GameObject Panel;

    //*************ver_controles_menu Variables globales*******************
    public static bool AbrirMenu = false;
    public bool activadobotoncontrol = false;

    //*************LevelStart Variables globales*******************
    //LevelIndex
    public GameObject tagStage;
    private int levelindex1_valor;

    //cartel extras
    //public static bool MostrarCartelExtra = false;
    //public GameObject ObjetivoCartel;


    //Modos
    public static string ContenedorModo;
    public static bool Check1PVP = false;
    public static bool Check1PVCPU = false;
    public static bool Check1CPUVCPU = false;
    public static bool Check2 = false;
	public static bool Check1Story = false;
	public static bool Check1Training = false;
	public string MODO;


    //Escenario
    public GameObject tagEscenario;




    void Start()
    {
        
   //     ObjetivoCartel.SetActive(false);
    }


    void Update()
    {

    
        if (Check1PVP){
            MODO = "PvsP";
            Debug.Log(MODO);
            Check1PVP = false;
            

        }

        if (Check1PVCPU)
        {
            MODO = "PvsCPU";
            Debug.Log(MODO);
            Check1PVCPU = false;
           

        }

        if (Check1CPUVCPU)
        {
            MODO = "CPUvsCPU";
			Debug.Log(MODO);
            Check1CPUVCPU = false;
           

        }
		
		if (Check1Story ){
            MODO = "StoryMode";
            Debug.Log(MODO);
            Check1Story = false;
          
            
        }
		
		if (Check1Training ){
            MODO = "TrainingRoom";
            Debug.Log(MODO);
            Check1Training = false;
           

        }

      //  if  (MostrarCartelExtra == true){
      //      ObjetivoCartel.SetActive(true);

      //  }
        



        if (Check2){
			Analytics.CustomEvent("mode_selected", new Dictionary<string, object>{
			{"modo", MODO}  });
			//Debug.Log(MODO);
			Check2 = false;
		}

		
        if(TerminoLaPeleaVersus == true && AbrirMenu == true) { 


            Panel.SetActive(true);
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }

           
            
            TerminoLaPeleaVersus = false;
            AbrirMenu = false;
        } //abrir calificaciones post versus
    }

    public void FirstCheckPVP()
    {
        Check1PVP = true;
    }

    public void FirstCheckPVCPU()
    {
        Check1PVCPU = true;
    }

    public void FirstCheckCPUVCPU()
    {
        Check1CPUVCPU = true;
    }
	
	public void FirstCheckStory()
    {
        Check1Story = true;
    }
	
	public void FirstCheckTraining()
    {
        Check1Training = true;
    }
	
    public void SecondCheck()
    {
        Check2 = true;
    }

	
    public void abrirCalificacionesVersus()
    {
        TerminoLaPeleaVersus = true;
        AbrirMenu = false;
    }

    public void AbrirMenuPrincipal()
    {
        AbrirMenu = true;
    }

  //  public void DesactivarCartelExtra()
  //  {
   //     MostrarCartelExtra = false;
   //     ObjetivoCartel.SetActive(false);
   // }



    public void ver_controles_menu()
    {
        if (activadobotoncontrol == false)
        {
            string menu = "menu";
            Analytics.CustomEvent("ver_controles_menu", new Dictionary<string, object>{
        {"donde", menu}

        });

            activadobotoncontrol = true;
        }
        else
            activadobotoncontrol = false;




    }
 

    public void CambiarValorLevelIndex()
    {
        levelindex1_valor= levelindex1_valor;
    }

  public void PingParaEnviarAnalytic()
    {
        Debug.Log("Analytic Enviadox");
        //ESTE EVENTO TIENE QUE ENVIARSE EN LA PELEA EL PRIMER SEGUNDO


        //Level index
        Debug.Log("LevelIndex= " + levelindex1_valor);
        Debug.Log("Personaje1= " + UFE.config.player1Character.characterName); //personnaje elegido p1
        Debug.Log("Personaje2= " + UFE.config.player2Character.characterName); //personnaje elegido p2
                                                              //Modo   contenedorModo

    }




 

}
