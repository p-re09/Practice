package returnproject;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.jar.Attributes.Name;

interface InnerDummyJava {
    public String getSound(String machine);
}

interface InnerDummyJava_2 {
    public int getWeight();
}

class NotUpToAge extends Exception{
    public NotUpToAge(String m) {
        super(m);
    }
}

class TooYoung extends RuntimeException{
    public TooYoung(String m){
        super(m);
    }
}

public class DummyJava implements InnerDummyJava, InnerDummyJava_2{

    int myX;
    int myY;
    private String foodName;
    protected static int money = 5;
    
    //public DummyJava(int x, int y){    
    //    myX = x + 1;
    //    myY = y + 2;
    //}

    public String getName(){
        return foodName;
    }

    public String setFoodName(String name){
        this.foodName = name;
        return name;
    }

    //public String getSound(){
    //    return "hehehehe";
    //}

    public String getSound(String machine){
        if (machine.toLowerCase().contains("car")){
            return "vroom";
        }
        else if (machine.toLowerCase().contains("train")) {
            return "chugachugachoochoo!!!";
        }
        else {
            machine = "";
        }
        
        return " ";
    }

    public int getWeight(){
        return 9;
    }

    

    //public static String practiceString;
    //public static int x = 2 , y = 4, z = 5;
    //public static boolean practiceBool;
    //public double practiceDouble;
    //public int testInt = App.count();

    /**int heHee(int num){
        if (num < 10) {
            throw new ArithmeticException("You're not old enough for this ride.");
        } 
        else {
            System.out.println("You can ride the ride");
        }
        
        return num;
    }**/

    public static int doCalc(int num){

        if (num < 10) {
            throw new TooYoung("You too young for this ride");
        }
        else{
            System.out.println("You are old enough. hehee");
        }
        //App myObj = new App();
        //int testInt = myObj.count();
        //int testInt = 5;
    //    x +=5;
    //    practiceString = "teststring";

    //    double y = 5;
    //    practiceBool = false;

    //    if (y == 5.0 && x == 7) {
    //        practiceBool = true;
            //System.out.println("5.0 " + practiceBool);
    //    }
    //    else {
    //        practiceBool = true;
            //System.out.println("NOT " + practiceBool);
    //    }

        /**switch (practiceString) {
            case "---":
                //System.out.println(practiceString);
                practiceBool = true;
                break;
            case "teststring":
                //System.out.println(x);
                practiceBool = true;
                break;
            case "--":
                //System.out.println(x);
                practiceBool = true;
                break;
            case "-":
                //System.out.println(x);
                practiceBool = true;
                break;
            case "-1":
                //System.out.println(x);
                practiceBool = true;
                break;
        }**/

        //for (int i = 0; i < 11; i++){
        //    //System.out.println("yes " + (i+1));
        //}

        //for (int i = 0; i <= 2 ; i++){
        //    for (int j = 0; j < 3; j++){
                //System.out.println(i + " " + j);
        //    }
        //}

        //int i = 10;
        //int j = 0;

        //while (j < i) {
        //    System.out.println(j);
        //    j++;
        //}

        //String [] fruits = {"wdfwde", "were", "ewrwee"};

        //for (i = 0; i < fruits.length; i++){
        //    System.out.println(fruits[i]);
        //}
        
        //ArrayList <String> testArrayList = new ArrayList<String>();
        //testArrayList.add("coin");
        //testArrayList.add("bag");
        //testArrayList.add("purse");
        //testArrayList.add("luggage");
        //testArrayList.add("bath");


        //for (i = 0; i < testArrayList.size(); i++){
        //    System.out.println(testArrayList.get(i));
        //}
        //String strNewTest = "gghjnbvcvb";
        //System.out.println(strNewTest.indexOf('g'));
        //System.out.println(strNewTest.lastIndexOf('g'));

        return num;
    }

    public static void main(String [] args){

        //DummyJava myTest = new DummyJava(1, 2);
        //System.out.println(myTest.myX + " " + myTest.myY);
        //Scanner myScanner = new Scanner(System.in);
        //System.out.println("Enter name: ");

        //String name = myScanner.nextLine();
        //System.out.println(name + "-----------------------");
        //int intJ = doCalc();
        //System.out.println(intJ);
        DummyJava myTest = new DummyJava();
        //System.out.println(myTest.getSound("car"));
        //System.out.println(myTest.getWeight());
        /**try {
            System.out.println(myTest.doCalc());
        } catch (Exception e) {
            // TODO: handle exception
            System.out.println("Can't divide integer by 0");
        } finally {
            System.out.println("Heheee");
        }**/
       //System.out.println(myTest.heHee(9));
       try {
            myTest.doCalc(9);
       } catch (TooYoung e) {
        // TODO: handle exception
            System.out.println("-----------" + e.getMessage());
       }
    }
}

class DummyJava_2 extends DummyJava{
    public static int myInt = 10;
    public static void main(String[] args) {
        DummyJava_2 pounds = new DummyJava_2();
        pounds.setFoodName("tim");
        System.out.println(pounds.getName());
        System.out.println(money * myInt);
    }
}