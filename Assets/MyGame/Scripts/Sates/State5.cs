// Represents 0 digit for a 7 segment display
public class State5 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 5;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State6();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State4();
    }


}
