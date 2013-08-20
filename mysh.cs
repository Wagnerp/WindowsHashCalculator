using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;

public static class mysh{

  public static void Main(string[] args){
    if(args.Length != 2){
      Console.WriteLine("Usage:");
      Console.WriteLine("");
      Console.WriteLine("mysh -algoName fileName");
      Console.WriteLine("");
      Console.WriteLine("(where -algoName is -md5 or -sha1 or -sha256)");

      return;  
    }
    
    string algoName = args[0].ToLower();
    string fileName = args[1];

    Dictionary<string, HashAlgorithm> nameAlgo = new Dictionary<string, HashAlgorithm>();


    using(HashAlgorithm md5 = new MD5CryptoServiceProvider())
    using(HashAlgorithm sha1 = new SHA1CryptoServiceProvider())
    using(HashAlgorithm sha256 = new SHA256CryptoServiceProvider())
    { 
      nameAlgo.Add("-md5", md5); 
      nameAlgo.Add("-sha1", sha1);
      nameAlgo.Add("-sha256", sha256);

      Console.WriteLine(CalculateHash(fileName, nameAlgo[algoName]));
    }
  }


  private static string CalculateHash(string fileName, HashAlgorithm algo){

    using (FileStream fs = new FileStream(fileName, FileMode.Open))
    using (BufferedStream bs = new BufferedStream(fs))
    {
        byte[] hash = algo.ComputeHash(bs);
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }
  }

}
