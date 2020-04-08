package com.mikewencel;

public class Investment {
    private int percent;
    private double money;

    public String FirstQuoter(double money,double percent){
        double percentage = money * percent;
        double allMoney = money + percentage;
        String Firstsum = "If you'll invest: " + money +" You'll earn: " + percentage + " in first quarter, you'll have " + allMoney;
        return Firstsum;

    }

    public String secondQuoter(double money,double percent){
        double percentage = money * percent;
        String sum = "If you'll invest" + money +"You'll earn " + percentage + "in second quarter";
        return sum;

    }

}
