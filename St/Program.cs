
using St;

var path = "../../../PublicKey.txt";
var content = File.ReadAllText(path);
var path2 = "../../../PrivateKey.txt";
var privateKey = File.ReadAllText(path2);

Console.WriteLine("-------######## DataToEncrpyt= 'Hello Amos' ########---------------");

var encryptedData = RsaEncry.Encrypt("Hello Amos", content);
Console.WriteLine(encryptedData);

Console.WriteLine("-------######## Decrypt The encrypted Data ########---------------");

var decryptedData = RsaEncry.Decrypt(encryptedData, privateKey);
Console.WriteLine(decryptedData);