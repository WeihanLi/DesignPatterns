namespace InterpreterPattern;

internal abstract class MusicalExpression
{
    public virtual void Interpret(PlayContext context)
    {
        if (string.IsNullOrEmpty(context.PlayText))
        {
            return;
        }

        var playKey = context.PlayText.Substring(0, 1);
        context.PlayText = context.PlayText.Substring(2);
        var playValue = context.PlayText.IndexOf(" ", StringComparison.Ordinal) > 0 ? Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ", StringComparison.Ordinal))) : 0;

        context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ", StringComparison.Ordinal) + 1);

        Execute(playKey, playValue);
    }

    public abstract void Execute(string key, double value);
}

internal class MusicalNote : MusicalExpression
{
    public override void Execute(string key, double value)
    {
        var note = key switch
        {
            "C" => "1",
            "D" => "2",
            "E" => "3",
            "F" => "4",
            "G" => "5",
            "A" => "6",
            "B" => "7",
            _ => string.Empty
        };
        Console.Write($"{note} ");
    }
}

internal class MusicalScale : MusicalExpression
{
    public override void Execute(string key, double value)
    {
        var scale = string.Empty;

        switch (value)
        {
            case 1:
                scale = "低音";
                break;

            case 2:
                scale = "中音";
                break;

            case 3:
                scale = "高音";
                break;
        }

        Console.Write(scale + " ");
    }
}

internal class MusicalSpeed : MusicalExpression
{
    public override void Execute(string key, double value)
    {
        string speed;
        if (value < 500)
        {
            speed = "快速";
        }
        else if (value >= 1000)
        {
            speed = "快速";
        }
        else
        {
            speed = "中速";
        }
        Console.Write(speed + " ");
    }
}
