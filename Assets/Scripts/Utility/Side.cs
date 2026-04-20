/// <summary>
/// Class to represent the sides of the court.
/// Allows for interchangeable use of "Side1", "Side2", "Left", and "Right" in code.
/// </summary>
public class Side
{
    private readonly bool value;
    private Side(bool value) => this.value = value;

    // Named constructors (clear intent)
    public static Side Left => new(false);
    public static Side Right => new(true);

    public static Side Side1 => new(false);
    public static Side Side2 => new(true);

    // Implicit conversions
    public static implicit operator bool(Side side) => side.value;
    public static implicit operator Side(bool value) => new(value);

    // Equality
    public static bool operator ==(Side a, Side b) => a.value == b.value;
    public static bool operator !=(Side a, Side b) => a.value != b.value;
    public static bool operator !(Side side) => !side.value;
    public override int GetHashCode() => value.GetHashCode();

    // Contexts
    public static bool operator true(Side s) => s.value;
    public static bool operator false(Side s) => !s.value;

    public override bool Equals(object obj) => obj is Side other && this == other;
}
