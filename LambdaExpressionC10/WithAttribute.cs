
var WriteOutputAsString = [Obsolete](string output) => Console.WriteLine(output);
var WriteOutputAsStringNew = (string output) => Console.WriteLine($"New {output}");

Console.WriteLine("Hello, World!");
