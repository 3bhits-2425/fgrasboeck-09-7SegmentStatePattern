// Represents 9 digit for a 7 segment display
public class State9 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 9;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State0.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State8();
    }


}
