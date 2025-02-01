public class Reference
{
    public string ReferenceText { get; private set; }

    public Reference(string referenceText)
    {
        ReferenceText = referenceText;
    }

    public override string ToString()
    {
        return ReferenceText;
    }