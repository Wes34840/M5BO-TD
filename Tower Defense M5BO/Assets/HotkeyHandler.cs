using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotkeyHandler : MonoBehaviour
{
    [SerializeField] private WaveHolder waveHolder;
    [SerializeField] private DraggableSpawner draggable;
    [SerializeField] private FastForwardButton FF;
    [SerializeField] private OptionsControl optionsControl;
    void Start()
    {

    }
    // at this point I don't fucking care anymore, YandereDev coding time
    void Update()
    {
        if (!GlobalData.gameIsActive)
        {
            return;
        }
        if (Input.anyKeyDown && !GlobalData.isPlacing)
        {
            HandleInput(Input.inputString);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && !GlobalData.isPlacing)
        { 
            if (GlobalData.optionsIsOpen)
            {
                optionsControl.CloseMenu();
                return;
            }
            optionsControl.OpenMenu();
        }
    }

    private void HandleInput(string key)
    {
        switch (key.ToLower())
        {
            case "q":
                draggable.SpawnDraggable(Draggables.Monkey);
                break;
            case "w":
                draggable.SpawnDraggable(Draggables.BigTower);
                break;
            case "e":
                draggable.SpawnDraggable(Draggables.Bomb);
                break;
            case " ":
                if (waveHolder.waveIsActive)
                {
                    FF.OnClick();
                }
                else
                {
                    waveHolder.StartWave();
                }
                waveHolder.waveIsActive = true;
                break;
        }
    }
}
