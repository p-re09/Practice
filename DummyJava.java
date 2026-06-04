public class DummyJava{

    public String practiceString;
    public static int x = 2 , y = 4, z = 5;
    public boolean practiceBool;
    public double practiceDouble;

    public static int doCalc(){
        x +=5;
        return x;
    }

    public static void main(String [] args){
        int j = doCalc();
        System.out.println(j);
    }
}
