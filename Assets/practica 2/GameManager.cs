using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameState currentGameState;
    static GameManager Gm;
    public int vida;
    public MeshRenderer jugador;
    public Transform jugadorT;
    public _PlayerController playerControlerr;

    private void Awake()
    {
        jugador = GameObject.Find("Jugador").GetComponent<MeshRenderer>();
        jugadorT = GameObject.Find("Jugador").GetComponent<Transform>();
        Gm = this;
        playerControlerr = GameObject.Find("Jugador").GetComponent<_PlayerController>();
    }
    private void Update()
    {
        MotorDelJuego();
        ChangeGameEstate(currentGameState);
    }
    public void salud(int pvd)
    {
        vida += pvd;
    }
    public static GameManager GetInstance()
    {
        return Gm;
    }
    public enum GameState
    {
        Menu,
        InGame,
        GameOver,      
    }
    public void ChangeGameEstate(GameState NewGameState)
    { 
        switch (NewGameState)
        {
            case GameState.Menu:
                currentGameState = GameState.Menu;
                
                playerControlerr.enabled = false;
                jugador.enabled = false;
                break;
            case GameState.InGame:
                currentGameState = GameState.InGame;
                playerControlerr.enabled = true;
                jugador.enabled = true;
                
                break;
            case GameState.GameOver:
                currentGameState = GameState.GameOver;
                playerControlerr.enabled = false;
                jugador.enabled = false;
                
                break;
            default:
                currentGameState = GameState.Menu;
                break;
        }
    }
    public void BackToMainMenu()
    {
        ChangeGameEstate(GameState.Menu);
    }
    public void MotorDelJuego()
    {
         if (currentGameState == GameState.Menu && Input.GetKeyDown("r"))
         {
           ChangeGameEstate(GameState.InGame);           
           jugadorT.position = new Vector3(0, 2, 0);
         }
        else if (vida == 0)
        {
            ChangeGameEstate(GameState.GameOver);
            vida = 2;
        }
        else if (currentGameState == GameState.GameOver && Input.GetKeyDown("m"))
        {
            ChangeGameEstate(GameState.Menu);           
        }        
    }
}
