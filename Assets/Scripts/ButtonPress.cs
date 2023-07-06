using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
   
    public GameObject[] buttonArray;

    public Sprite buttonSelected;
    public Sprite buttonNotPressed;

    private int _selectedButtton;

    private float _horizontal;
    private float _veritcal;


    private bool _isButtonPressed = false;

    private GameObject _firstButton;


    private void Update()
    {
        buttonArray = GameObject.FindGameObjectsWithTag("Button");

        if (buttonArray.Length > 0)
        {
            _selectedButtton = 0;
        }

        _firstButton = buttonArray[0];

        for (int i = 0; i < buttonArray.Length; i++)
        {
            if (i == _selectedButtton)
            {
                buttonArray[i].GetComponent<Button>().Select();
                buttonArray[i].GetComponent<Image>().sprite = buttonNotPressed;
            }
            else
            {
                buttonArray[i].GetComponent<Image>().sprite = buttonSelected;
            }
        }
        Vector3 buttonPos = buttonArray[_selectedButtton].GetComponent<RectTransform>().position;

        float[] horizontalDif = new float[buttonArray.Length];
        float[] verticalDif = new float[buttonArray.Length];

        for (int i = 0; i < buttonArray.Length; i++)
        {
            if (i != _selectedButtton)
            {
                Vector3 buttonPos2 = buttonArray[_selectedButtton].GetComponent<RectTransform>().position;
                horizontalDif[i] = buttonPos2.x - buttonPos2.x;
                verticalDif[i] = buttonPos2.y - buttonPos2.y;
            }
        }

        float newHorizontalDif = 9999f;
        float newVerticalDif = 9999f;


        if(Input.GetKeyDown(KeyCode.S)&& !buttonNotPressed)
        {
            _isButtonPressed = true;

            for(int i = 0; i < buttonArray.Length; i++)
            {
                if(i != _selectedButtton)
                {
                    if (verticalDif[i]>0)
                    {
                        if (MathF.Abs(horizontalDif[i]) < MathF.Abs(newHorizontalDif))
                        {
                            newHorizontalDif = horizontalDif[i];

                            if (MathF.Abs(verticalDif[i]) < MathF.Abs(newVerticalDif))
                            {
                                newVerticalDif = verticalDif[i];
                                _selectedButtton = i;
                            }

                            else
                            {
                                _selectedButtton = i;
                            }
                        }
                    }
                }
            }

        } 
        if(Input.GetKeyDown(KeyCode.W)&& !buttonNotPressed)
        {
            _isButtonPressed = true;

            for(int i = 0; i < buttonArray.Length; i++)
            {
                if(i != _selectedButtton)
                {
                    if (verticalDif[i]>0)
                    {
                        if (MathF.Abs(horizontalDif[i]) < MathF.Abs(newHorizontalDif))
                        {
                            newHorizontalDif = horizontalDif[i];

                            if (MathF.Abs(verticalDif[i]) < MathF.Abs(newVerticalDif))
                            {
                                newVerticalDif = verticalDif[i];
                                _selectedButtton = i;
                            }

                            else
                            {
                                _selectedButtton = i;
                            }
                        }
                    }
                }
            }

        } 
        
        if(Input.GetKeyDown(KeyCode.A)&& !buttonNotPressed)
        {
            _isButtonPressed = true;

            for(int i = 0; i < buttonArray.Length; i++)
            {
                if(i != _selectedButtton)
                {
                    if (verticalDif[i]>0)
                    {
                        if (MathF.Abs(horizontalDif[i]) < MathF.Abs(newHorizontalDif))
                        {
                            newHorizontalDif = horizontalDif[i];

                            if (MathF.Abs(verticalDif[i]) < MathF.Abs(newVerticalDif))
                            {
                                newVerticalDif = verticalDif[i];
                                _selectedButtton = i;
                            }

                            else
                            {
                                _selectedButtton = i;
                            }
                        }
                    }
                }
            }

        }
        
        if(Input.GetKeyDown(KeyCode.D)&& !buttonNotPressed)
        {
            _isButtonPressed = true;

            for(int i = 0; i < buttonArray.Length; i++)
            {
                if(i != _selectedButtton)
                {
                    if (verticalDif[i]>0)
                    {
                        if (MathF.Abs(horizontalDif[i]) < MathF.Abs(newHorizontalDif))
                        {
                            newHorizontalDif = horizontalDif[i];

                            if (MathF.Abs(verticalDif[i]) < MathF.Abs(newVerticalDif))
                            {
                                newVerticalDif = verticalDif[i];
                                _selectedButtton = i;
                            }

                            else
                            {
                                _selectedButtton = i;
                            }
                        }
                    }
                }
            }

        }

        if (_horizontal == 0 && _veritcal == 0)
        {
            _isButtonPressed = false;
        }

        else
        {
            _selectedButtton = 0;
        }
        
    }


}
