public class DummyJava{

    public String practiceString;
    public static int x = 2 , y = 4, z = 5;
    public boolean practiceBool;
    public double practiceDouble;

    public static double doCalc(){
        x +=5;
        double y = 5.0;
        return y;
    }

    public static void main(String [] args){
        double j = doCalc();
        System.out.println(j);
    }
}
