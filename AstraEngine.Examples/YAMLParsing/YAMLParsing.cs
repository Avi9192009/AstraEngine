using AstraEngine.Core;
using AstraEngine.Serialization;
using AstraEngine.Canvas2D.RaylibAdapter;

namespace AstraEngine.Examples.YAMLParsing;

public static class YAMLParsingExample
{
    public static void Run()
    {
        // Create a Windowed Game from a YAML hierarchy
        WindowedGame game = new()
        {
            Root = YAMLUtils.DeserializeEntityFromFile("YAMLParsing/Hierarchy.yaml")
        };
        // Run the game
        Engine.Run(game);
    }
}