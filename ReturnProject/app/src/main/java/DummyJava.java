import java.util.ArrayList;

public class DummyJava{

    public static String practiceString;
    public static int x = 2 , y = 4, z = 5;
    public static boolean practiceBool;
    public double practiceDouble;

    public static boolean doCalc(){

        x +=5;
        practiceString = "teststring";

        double y = 5;
        practiceBool = false;

        if (y == 5.0 && x == 7) {
            practiceBool = true;
            //System.out.println("5.0 " + practiceBool);
        }
        else {
            practiceBool = true;
            //System.out.println("NOT " + practiceBool);
        }

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

        int i = 10;
        int j = 0;

        //while (j < i) {
        //    System.out.println(j);
        //    j++;
        //}

        String [] fruits = {"wdfwde", "were", "ewrwee"};

        //for (i = 0; i < fruits.length; i++){
        //    System.out.println(fruits[i]);
        //}
        
        ArrayList <String> testArrayList = new ArrayList<String>();
        testArrayList.add("coin");
        testArrayList.add("bag");
        testArrayList.add("purse");
        testArrayList.add("luggage");
        testArrayList.add("bath");


        //for (i = 0; i < testArrayList.size(); i++){
        //    System.out.println(testArrayList.get(i));
        //}
        String strNewTest = "gghjnbvcvb";
        System.out.println(strNewTest.indexOf('g'));
        System.out.println(strNewTest.lastIndexOf('g'));

        return practiceBool;
    }

    public static void main(String [] args){
        boolean boolJ = doCalc();
        //System.out.println(j);
    }
}
