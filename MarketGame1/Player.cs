using MarketGame1;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

/// <summary>
/// Summary description for Player
/// Ian Moon 11/6/2015
/// Contains the information for the player class and sets stats
/// </summary>
public class Player
{
    //Player stats
    private const int MAXSPEED = 20;
    private int currSpeed;
    private Fruits[] itemArray = new Fruits[6];
    private int points;
    private bool hasJumped;

    //Int to keep track of position in the Fruit Array
    int fruitPos = 0;

    //Properties
    public int CurrSpeed
    {
        get { return currSpeed; }
        set { currSpeed = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    
    //Player constructor that sets player speed, player points, and the item array elements to 0
    public Player()
    {
        currSpeed = MAXSPEED;
        points = 0;
    }

    //Override ToString to print player stats
    public override string ListPlayer()
    {
        foreach(Fruits fruit in itemArray)
        {
            Console.WriteLine("Fruit in Array: " + fruit + "\n");
        }
        return "Current Speed: " + currSpeed + " Max Speed: " + MAXSPEED + " Points: " + points;
    }

    //Method for adding an item
    public void PickUpFruit(Fruits fruit)
    {
        //Checking each array spot to see if it is empty
        if(itemArray[0] == null)
        {
            itemArray[0] = fruit;
        }
        else if (itemArray[1] == null)
        {
            fruitPos = 1;
            itemArray[1] = fruit;
        }
        else if (itemArray[2] == null)
        {
            fruitPos = 2;
            itemArray[2] = fruit;
        }
        else if (itemArray[3] == null)
        {
            fruitPos = 3;
            itemArray[3] = fruit;
        }
        else if (itemArray[4] == null)
        {
            fruitPos = 4;
            itemArray[4] = fruit;
        }
        else if (itemArray[5] == null)
        {
            fruitPos = 5;
            itemArray[5] = fruit;
        }

        //If the array is full, tell the player
        else
        {
            Console.WriteLine("You are carrying too many items!");
        }
    }

    //Throwing the fruit
    public void Throw()
    {
        //Setting the position back to nyll
        itemArray[fruitPos] = null;

        //Adjusting fruit position
        if (fruitPos != 0)
        {
            fruitPos = fruitPos - 1;
        }
    }

    //If you get hit by a fruit method
    public void GetStunned()
    {
        //Seeing how many fruits to drop
        double takeAway = fruitPos/ 2;
        takeAway = Math.Ceiling(takeAway);

        //While the fruit to drop is greater than zero, keep dropping and adjusting
        while(itemArray.Length >0)
        {
            itemArray[fruitPos] = null;
            fruitPos--;
            takeAway--;
        }
    }

    //Turning in the fruit
    public void TurnInFruit()
    {
        foreach(Fruits fruit in itemArray)
        {
            switch(fruit.Name)
            {
            }
        }
    }
    
}

