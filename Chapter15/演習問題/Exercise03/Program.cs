using Exercise03;

var service = new Take20Service();
var processor = new TextFileProcessor(service);
string filename = @"C:\Users\infosys\source\repos\OOP2026\Chapter15\演習問題\Exercise03\枕草子.txt";
processor.Run(filename);
