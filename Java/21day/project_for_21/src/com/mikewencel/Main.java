package com.mikewencel;

public class Main {

    public static void main(String[] args) {

        marsRobot spirit = new marsRobot();
        spirit.showAttributes();
        System.out.println("***********");
        spirit.status = "Exploration";
        spirit.speed = 3;
        spirit.temperature = 20;
        System.out.println("***********");
        spirit.temperature = -90;
        System.out.println("Temperature changed to " + spirit.temperature);
        System.out.println("***********");
        spirit.showAttributes();
        System.out.println("***********");
        System.out.println("Checking temperature");
        spirit.checkTemperature();
        spirit.showAttributes();


    }
}
