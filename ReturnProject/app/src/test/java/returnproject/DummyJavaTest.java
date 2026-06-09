package returnproject;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class DummyJavaTest {   
    @Test void doCalcWorks(){
        DummyJava testDoCalc = new DummyJava(1,2);
        assertTrue(testDoCalc.doCalc() == 5);
    }
}
