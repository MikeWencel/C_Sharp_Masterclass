package com.mikewencel;

public class marsRobot {
    String status;
    int speed;
    float temperature;

    void checkTemperature(){
        if (temperature < -61){
            speed = 5;
            status = "Back to base";

        }
    }

    void showAttributes(){
        System.out.println("temperature: " + temperature);
        System.out.println("speed: " + speed);
        System.out.println("status " + status);
    }
}

