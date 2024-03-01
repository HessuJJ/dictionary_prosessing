using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

(int Len,List<string> Most) ProcessDictionary(Dictionary<string, int> input)
{	
	int count = 0;
	int maxvalue = 0;
	List<string> strings = new List<string>();
	
	if(input.Count() == 0)
	{
		return(Len: count, Most: strings );
	}	
	foreach (var item in input)
	{
		count += item.Value;
		
		if(maxvalue <= item.Value)
		{ 
			maxvalue = item.Value;
		}
	}
	foreach (var item2 in input)
	{
		if(item2.Value == maxvalue)
		{
			strings.Add(item2.Key);
		}
	}
	return(Len: count, Most: strings);
}

var palatus = ProcessDictionary(new Dictionary<string, int>(){{"a",1},{"b",3},{"c",5},{"d",5}});

Console.WriteLine(palatus);