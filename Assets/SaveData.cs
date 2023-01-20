﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static SaveData instance;
    Player player;

    public static int JunChromaSave; //1 si esta desbloqueado y 0 si esta bloqueado
    public static int MarieChromaSave;
    public static int MikuChromaSave;
    public static int TaroChromaSave;

    public static int BanosSave;
    public static int ArcadeSave;
    public static int DojoSave;
    public static int DistritoSave;

    public void NewGame()
    {
        SaveData.JunChromaSave= 0;
        SaveData.MarieChromaSave = 0;
        SaveData.MikuChromaSave = 0;
        SaveData.TaroChromaSave = 0;

        SaveData.BanosSave = 0;
        SaveData.ArcadeSave = 0;
        SaveData.DojoSave = 0;
        SaveData.DistritoSave = 0;


        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Junchromasave", SaveData.JunChromaSave);
        PlayerPrefs.SetInt("Mariechromasave", SaveData.MarieChromaSave);
        PlayerPrefs.SetInt("Mikuchromasave", SaveData.MarieChromaSave);
        PlayerPrefs.SetInt("Tarochromasave", SaveData.TaroChromaSave);

        PlayerPrefs.SetInt("Banossave", SaveData.BanosSave);
        PlayerPrefs.SetInt("Arcadesave", SaveData.ArcadeSave);
        PlayerPrefs.SetInt("Dojosave", SaveData.DojoSave);
        PlayerPrefs.SetInt("Distritosave", SaveData.DistritoSave);
    }


    public void Continue()
    {
        if (PlayerPrefs.HasKey("Junchromasave"))
        {
            JunChromaSave = PlayerPrefs.GetInt("Junchromasave");
            MarieChromaSave = PlayerPrefs.GetInt("Mariechromasave");
            MikuChromaSave = PlayerPrefs.GetInt("Mikuchromasave");
            TaroChromaSave = PlayerPrefs.GetInt("Tarochromasave");

            BanosSave = PlayerPrefs.GetInt("Banossave");
            ArcadeSave = PlayerPrefs.GetInt("Arcadesave");
            DojoSave = PlayerPrefs.GetInt("Dojosave");
            DistritoSave = PlayerPrefs.GetInt("Distritosave");

            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }

    public void Save_Data()
    {
       
        PlayerPrefs.SetInt("Junchromasave", JunChromaSave);
        PlayerPrefs.SetInt("Mariechromasave", MarieChromaSave);
        PlayerPrefs.SetInt("Mikuchromasave", MikuChromaSave);
        PlayerPrefs.SetInt("Tarochromasave", TaroChromaSave);

        PlayerPrefs.SetInt("Banossave", BanosSave);
        PlayerPrefs.SetInt("Arcadesave", ArcadeSave);
        PlayerPrefs.SetInt("Dojosave", DojoSave);
        PlayerPrefs.SetInt("Distritosave", DistritoSave);

        PlayerPrefs.Save();
    }

    public void Check_data()
    {
        Debug.Log("Jun Save Game: " + JunChromaSave);
        Debug.Log("Marie Save Game: " + MarieChromaSave);
        Debug.Log("Miku Save Game: " + MikuChromaSave);
        Debug.Log("Taro Save Game: " + TaroChromaSave);

        Debug.Log("Jun Save Game: " + BanosSave);
        Debug.Log("Marie Save Game: " + ArcadeSave);
        Debug.Log("Miku Save Game: " + DojoSave);
        Debug.Log("Taro Save Game: " + DistritoSave);

    }
    
    public void Set_1_Chroma()
    {
        SaveData.JunChromaSave = 1;
        SaveData.MarieChromaSave = 1;
        SaveData.MikuChromaSave = 1;
        SaveData.TaroChromaSave = 1;
    }

    public void Set_1_Taro()
    {
        SaveData.TaroChromaSave = 1;
        SaveData.DojoSave = 1;
        PlayerPrefs.SetInt("Tarochromasave", TaroChromaSave);
        PlayerPrefs.SetInt("Dojosave", DojoSave);
        PlayerPrefs.Save();
    }

    public void Set_1_Jun()
    {
        SaveData.JunChromaSave = 1;
        SaveData.BanosSave = 1;
        PlayerPrefs.SetInt("Junchromasave", JunChromaSave);
        PlayerPrefs.SetInt("Banossave", BanosSave);
        PlayerPrefs.Save();
    }

    public void Set_1_Miku()
    {
        SaveData.MikuChromaSave = 1;
        SaveData.ArcadeSave = 1;
        PlayerPrefs.SetInt("Mikuchromasave", MikuChromaSave);
        PlayerPrefs.SetInt("Arcadesave", ArcadeSave);
        PlayerPrefs.Save();
    }

    public void Set_1_Marie()
    {
        SaveData.MarieChromaSave = 1;
        SaveData.DistritoSave = 1;
        PlayerPrefs.SetInt("Mariechromasave", MarieChromaSave);
        PlayerPrefs.SetInt("Distritosave", DistritoSave); 
        PlayerPrefs.Save();
    }
    
    //MARIEEEEEEE
}
