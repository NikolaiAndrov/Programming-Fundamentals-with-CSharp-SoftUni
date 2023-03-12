public class StartUp
{
    public static void Main()
    {
        var pieces = new Dictionary<string, List<string>>();
        AddPieces(pieces);

        string input;

        while ((input = Console.ReadLine()) != "Stop")
        {
            var args = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var piece = args[1];

            if (command == "Add")
            {
                var composer = args[2];
                var key = args[3];
                AddPiece(pieces, piece, composer, key);
            }
            else if (command == "Remove")
            {
                RemovePiece(pieces, piece);
            }
            else if (command == "ChangeKey")
            {
                var newKey = args[2];
                ChangeKey(pieces, piece, newKey);
            }
        }

        PrintPieces(pieces);
    }

    static void PrintPieces(Dictionary<string, List<string>> pieces)
    {
        foreach (var piece in pieces)
        {
            Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
        }
    }
    static void ChangeKey(Dictionary<string, List<string>> pieces, string piece, string newKey)
    {
        if (!pieces.ContainsKey(piece))
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
        else
        {
            pieces[piece][1] = newKey;
            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
        }
    }
    static void RemovePiece(Dictionary<string, List<string>> pieces, string piece)
    {
        if (pieces.ContainsKey(piece))
        {
            pieces.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    static void AddPiece(Dictionary<string, List<string>> pieces, string piece, string composer, string key)
    {
        if (pieces.ContainsKey(piece))
        {
            Console.WriteLine($"{piece} is already in the collection!");
        }
        else
        {
            pieces[piece] = new List<string>();
            pieces[piece].Add(composer);
            pieces[piece].Add(key);

            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
    }
    static void AddPieces(Dictionary<string, List<string>> pieces)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var pieceInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            var piece = pieceInfo[0];
            var composer = pieceInfo[1];
            var key = pieceInfo[2];

            if (!pieces.ContainsKey(piece))
            {
                pieces[piece] = new List<string>();
                pieces[piece].Add(composer);
                pieces[piece].Add(key);
            }
        }
    }
}