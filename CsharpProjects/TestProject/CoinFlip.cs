using System;

public class CoinFlip{

    public void coinFlipMethod(){

        Random coin = new Random();
        int flip = coin.Next(0,2);
        Console.WriteLine((flip == 0) ? "heads" : "tails");


    }






}